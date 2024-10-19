using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets;
using EOS_SDK._Networking.Packets.ResponsePackets;
using LiteNetLib.Utils;
using LiteNetLib;
using System.Net;
using System.Text.Json;

namespace EOS_SDK._Networking.PacketWorkers;

public class PlayerPacketWorker
{
    public static void ReqPacket(PlayerPacket<ReqPacket> packet, IPEndPoint point)
    {
        if (packet.ToAccountId != EOS_Main.GetConfig().AccountId)
            return;
        if (EOS_Main.GetPlatform().Network.IsNull())
            return;
        switch (packet.PacketData.Request)
        {
            case ReqEnum.NONE:
                break;
            case ReqEnum.Ach:
                {
                    var ach = EOS_Main.GetPlatform().GetHandlerNoDummy<Achievements.Achievements_Handler>(SDK.AchievementPTR);
                    if (ach == null)
                        return;
                    var model = ach.GetAchievement_FromAccount(packet.ToAccountId);
                    var modelstring = JsonSerializer.Serialize(model, SourceGenerationContext.Default.ListAchievement_Model);
                    PlayerPacket<AchResponsePacket> achpacket = new()
                    {
                        PacketData = new()
                        {
                            JsonAchModel = modelstring,
                            AccountId = packet.ToAccountId,
                        },
                        SenderAccountId = EOS_Main.GetConfig().AccountId,
                        ToAccountId = packet.SenderAccountId
                    };
                    EOS_Main.GetPlatform().Network.SendNetPacketToUser(achpacket, packet.SenderAccountId);
                }
                break;
            default:
                break;
        }

    }

    internal static void AchResponsePacket(PlayerPacket<AchResponsePacket> packet, IPEndPoint point)
    {
        if (packet.ToAccountId != EOS_Main.GetConfig().AccountId)
            return;
        var ach = EOS_Main.GetPlatform().GetHandlerNoDummy<Achievements.Achievements_Handler>(SDK.AchievementPTR);
        if (ach == null)
            return;
        try
        {
            var data = JsonSerializer.Deserialize(packet.PacketData.JsonAchModel, SourceGenerationContext.Default.ListAchievement_Model);
            if (data == null)
                return;
            ach.SetAchForUser(packet.PacketData.AccountId, data);
        }
        catch
        {
            Logger.WriteError($"Cannot parse Achivement data from other User {packet.SenderAccountId}", Logging.LogCategory.Achievements);
        }

    }

    internal static void PingPacket(PlayerPacket<PingPongPacket> packet, IPEndPoint point)
    {
        if (EOS_Main.GetPlatform().Network.IsNull())
            return;
        if (EOS_Main.GetConfig().AccountId != packet.ToAccountId)
            return;
        Logger.WriteDebug($"Ping! {packet}");
        if (!packet.PacketData.IsPing)
        {
            Logger.WriteDebug($"Ping Pong success!");
            return;
        }
        //todo: check safely
        if (!EOS_Main.GetPlatform().Network.IsUserExists(packet.ToAccountId))
        {
            Logger.WriteDebug($"AccountId not exist in AccountId_To_PeerId ({packet.ToAccountId})");
            return;
        }
        int id = EOS_Main.GetPlatform().Network.BiNet!.AccountId_To_PeerId[packet.ToAccountId];
        NetDataWriter writer = new NetDataWriter();
        PlayerPacket<PingPongPacket> newPing = new()
        {
            PacketData = new()
            {
                PingTime = DateTimeOffset.Now,
                IsPing = false,
            },
            SenderAccountId = packet.ToAccountId,
            ToAccountId = packet.SenderAccountId,
        };
        EOS_Main.GetPlatform().Network.BiNet!.NetPacketProcessor.WriteNetSerializable(writer, ref packet);
        EOS_Main.GetPlatform().Network.NetManager!.GetPeerById(id).Send(writer, DeliveryMethod.ReliableOrdered);
        Logger.WriteDebug($"Sent Pong Packet! (Time To Pong: {newPing.PacketData.PingTime - packet.PacketData.PingTime})");
    }
}

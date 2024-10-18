using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets;
using EOS_SDK._Networking.Packets.ResponsePackets;
using System.Net;
using System.Text.Json;

namespace EOS_SDK._Networking;

public class PlayerPacketWorker
{
    public static void ReqPacket(PlayerPacket<ReqPacket> packet, IPEndPoint point)
    {
        if (packet.ToAccountId != EOS_Main.GetConfig().AccountId)
        {
            Logger.WriteDebug("To AccountId isnt the same as Config AccountId, dropping packet (We sent wrong ID initially?)", Logging.LogCategory.Core);
            return;
        }
        if (EOS_Main.GetPlatform().Network.BiNet == null)
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
                            JsonAchModel = modelstring
                        },
                        SenderAccountId = EOS_Main.GetConfig().AccountId,
                        ToAccountId = packet.SenderAccountId
                    };
                    if (EOS_Main.GetPlatform().Network.BiNet == null)
                        return;
                    EOS_Main.GetPlatform().Network.BiNet!.SendNetPacketToUser(achpacket, packet.SenderAccountId);
                }
                break;
            default:
                break;
        }

    }

    internal static void AchResponsePacket(PlayerPacket<AchResponsePacket> packet, IPEndPoint point)
    {
        var ach = EOS_Main.GetPlatform().GetHandlerNoDummy<Achievements.Achievements_Handler>(SDK.AchievementPTR);
        if (ach == null)
            return;
        try
        {
            var data = JsonSerializer.Deserialize(packet.PacketData.JsonAchModel, SourceGenerationContext.Default.ListAchievement_Model);
            if (data == null)
                return;
            ach.SetAchForUser(packet.SenderAccountId, data);
        }
        catch 
        {
            Logger.WriteError($"Cannot parse Achivement data from other User {packet.SenderAccountId}", Logging.LogCategory.Achievements);
        }
        
    }

    internal static void PingPacket(PlayerPacket<PingPacket> packet, IPEndPoint point)
    {
        
    }
}

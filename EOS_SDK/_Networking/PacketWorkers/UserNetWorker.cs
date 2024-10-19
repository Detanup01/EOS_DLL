using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets;
using System.Net;

namespace EOS_SDK._Networking.PacketWorkers;

public class UserNetWorker
{
    public static void DiscoveryResponse(DiscoveryResponsePacket packet, IPEndPoint remoteEndPoint)
    {
        Logger.WriteDebug($"DiscoveryResponsePacket: {packet} from: {remoteEndPoint}");
        if (EOS_Main.GetPlatform().Network.IsNull())
            return;
        if (packet.CanConnect)
            EOS_Main.GetPlatform().Network.NetManager!.Connect(remoteEndPoint, "EOS_BroadCast");
    }

    public static void UserDisconnected(UserDisconnectedPacket packet, IPEndPoint point)
    {
        Logger.WriteDebug($"UserDisconnectedPacket: {packet} from: {point}");
        if (packet.AppId != EOS_Main.GetConfig().AppId)
            return;
        if (EOS_Main.GetPlatform().Network.IsNull())
            return;
        EOS_Main.GetPlatform().Network.BiNet!.NetUsers.Remove(packet.IP);
        // Do we really need to send disconnect? (they automactly disconnect so no, I guess)
    }

    public static void UserConnected(UserConnectedPacket packet, IPEndPoint point)
    {
        Logger.WriteDebug($"UserConnectedPacket: {packet} from: {point}");
        if (packet.AppId != EOS_Main.GetConfig().AppId)
        {
            Logger.WriteDebug($"AppId is not the same as in our config ({packet.AppId})!=({EOS_Main.GetConfig().AppId})");
            return;
        }
        if (EOS_Main.GetPlatform().Network.IsNull())
            return;

        if (EOS_Main.GetPlatform().Network.BiNet!.NetUsers.TryGetValue(packet.IP, out var id))
        {
            Logger.WriteDebug($"User already connected. IP: {packet.IP}");
            if (id == string.Empty)
            {
                EOS_Main.GetPlatform().Network.BiNet!.NetUsers[packet.IP] = packet.AccountId;
                var peer = EOS_Main.GetPlatform().Network.NetManager!.ConnectedPeerList.Where(x => x.ToString() == packet.IP).FirstOrDefault();
                if (peer == null)
                {
                    Logger.WriteDebug($"Peer NULL!");
                    return;
                }
                EOS_Main.GetPlatform().Network.BiNet!.PeerId_To_AccountId.Add(peer.Id, packet.AccountId);
                EOS_Main.GetPlatform().Network.BiNet!.AccountId_To_PeerId.Add(packet.AccountId, peer.Id);
                Logger.WriteDebug($"Everything set!");
            }
            else
            {
                Logger.WriteDebug("Client Already connected before. Skipping connection sending.");
            }
            return;
        }

        EOS_Main.GetPlatform().Network.BiNet!.NetUsers.Add(packet.IP, packet.AccountId);
        var port = int.Parse(packet.IP.Split(":")[1]);
        var ip = IPAddress.Parse(packet.IP.Split(":")[0]);
        IPEndPoint endPoint = new(ip, port);
        EOS_Main.GetPlatform().Network.NetManager!.Connect(endPoint, EOS_Main.GetConfig().AppId);
        Logger.WriteDebug($"Connection Request send to: {endPoint.ToString()} ({packet.AccountId})");
    }
}

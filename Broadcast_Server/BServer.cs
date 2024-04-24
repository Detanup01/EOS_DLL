using EOS_SDK._Networking.Packets;
using LiteNetLib;
using LiteNetLib.Utils;
using System.Net;
using System.Net.Sockets;

namespace Broadcast_Server
{
    public class BServer : INetEventListener
    {
        public NetManager Server;
        public NetPacketProcessor NetPacketProcessor = new();
        public BServer()
        {
            NetPacketProcessor.RegisterNestedType<DiscoveryRequestPacket>();
            NetPacketProcessor.RegisterNestedType<DiscoveryResponsePacket>();
            NetPacketProcessor.SubscribeNetSerializable<DiscoveryResponsePacket, IPEndPoint>(DiscoveryResponse);
            NetPacketProcessor.SubscribeNetSerializable<DiscoveryRequestPacket, IPEndPoint>(DiscoveryRequest);
        }

        private void DiscoveryRequest(DiscoveryRequestPacket packet, IPEndPoint point)
        {
            Console.WriteLine(packet);
            DiscoveryResponsePacket discoveryResponsePacket = new()
            { 
                CanConnect = true,
                DenyReason = DiscoveryDenyEnums.None
            };
            NetDataWriter writer = new();
            NetPacketProcessor.WriteNetSerializable(writer, ref discoveryResponsePacket);
            Server.SendUnconnectedMessage(writer, point);
        }

        private void DiscoveryResponse(DiscoveryResponsePacket packet, IPEndPoint point)
        {
            Console.WriteLine(packet);
        }

        public void OnConnectionRequest(ConnectionRequest request)
        {
            request.AcceptIfKey("EOS_BroadCast");
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
        {
            
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {
            
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channelNumber, DeliveryMethod deliveryMethod)
        {
            
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            Console.WriteLine("[Server] ReceiveUnconnected {0}. From: {1}", messageType, remoteEndPoint);
            NetPacketProcessor.ReadPacket(reader, remoteEndPoint);
        }

        public void OnPeerConnected(NetPeer peer)
        {
            Console.WriteLine("[Server] Peer connected: " + peer);
            var peers = Server.ConnectedPeerList;
            foreach (var netPeer in peers)
            {
                Console.WriteLine("ConnectedPeersList: id={0}, ep={1}", netPeer.Id, netPeer);
                //send each client back some stuff (who are in the thing)
            }
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            
        }
    }
}

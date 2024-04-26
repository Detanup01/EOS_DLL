using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;

public struct DiscoveryResponsePacket : INetSerializable
{
    public bool CanConnect;

    public void Deserialize(NetDataReader reader)
    {
        CanConnect = reader.GetBool();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(CanConnect);
    }

    public override string ToString()
    {
        return $"DiscoveryResponsePacket | Can Connect: {CanConnect}";
    }
}

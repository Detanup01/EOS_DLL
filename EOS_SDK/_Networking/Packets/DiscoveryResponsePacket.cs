using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;
public enum DiscoveryDenyEnums : byte
{
    None = 0,
    SelfConnection,
    AppIdMissmatch,
    UserBanned,
}

public struct DiscoveryResponsePacket : INetSerializable
{
    public bool CanConnect;
    public DiscoveryDenyEnums DenyReason;

    public void Deserialize(NetDataReader reader)
    {
        CanConnect = reader.GetBool();
        DenyReason = (DiscoveryDenyEnums)reader.GetByte();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(CanConnect);
        writer.Put((byte)DenyReason);
    }

    public override string ToString()
    {
        return $"DiscoveryResponsePacket | Can Connect: {CanConnect} Deny Reason: {DenyReason}";
    }
}

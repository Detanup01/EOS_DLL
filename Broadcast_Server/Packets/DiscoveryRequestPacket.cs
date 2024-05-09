using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;

public struct DiscoveryRequestPacket : INetSerializable
{
    public string AccountId;
    public string AppId;
    public void Deserialize(NetDataReader reader)
    {
        AccountId = reader.GetString();
        AppId = reader.GetString();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(AccountId);
        writer.Put(AppId);
    }

    public override string ToString()
    {
        return $"DiscoveryRequestPacket | AccountId: {AccountId} AppId: {AppId}";
    }
}
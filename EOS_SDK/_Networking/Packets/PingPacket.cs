using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;

public struct PingPacket : INetSerializable
{
    public string AccountId;
    public DateTimeOffset PingTime;

    public void Deserialize(NetDataReader reader)
    {
        AccountId = reader.GetString();
        PingTime = DateTimeOffset.FromUnixTimeMilliseconds(reader.GetLong());
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(AccountId);
        writer.Put(PingTime.ToUnixTimeMilliseconds());
    }

    public override string ToString()
    {
        return $"PingPacket | Sender: {AccountId} PingTime: {PingTime} ({PingTime.ToUnixTimeMilliseconds()})";
    }
}

using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;

public struct PingPongPacket : INetSerializable
{
    public DateTimeOffset PingTime;
    public bool IsPing;

    public void Deserialize(NetDataReader reader)
    {
        PingTime = DateTimeOffset.FromUnixTimeMilliseconds(reader.GetLong());
        IsPing = reader.GetBool();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(PingTime.ToUnixTimeMilliseconds());
        writer.Put(IsPing);
    }

    public override string ToString()
    {
        return $"PingPacket | PingTime: {PingTime} ({PingTime.ToUnixTimeMilliseconds()}) IsPing: {IsPing}";
    }
}

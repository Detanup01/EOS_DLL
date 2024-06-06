using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;

public struct PlayerPacket<PacketType> : INetSerializable where PacketType : struct, INetSerializable
{
    public string SenderAccountId;
    public string ToAccountId;
    public PacketType PacketData;
    public void Deserialize(NetDataReader reader)
    {
        SenderAccountId = reader.GetString();
        ToAccountId = reader.GetString();
        PacketData = new();
        PacketData.Deserialize(reader);
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(SenderAccountId);
        writer.Put(ToAccountId);
        PacketData.Serialize(writer);
    }

    public override string ToString()
    {
        return $"PlayerPacket | SenderAccountId: {SenderAccountId} ToAccountId: {ToAccountId}";
    }
}
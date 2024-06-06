using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets.ResponsePackets;
public struct AchResponsePacket : INetSerializable
{
    public string JsonAchModel;

    public void Deserialize(NetDataReader reader)
    {
        JsonAchModel = reader.GetString();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(JsonAchModel);
    }

    public override string ToString()
    {
        return $"AchResponsePacket | JsonAchModel: {JsonAchModel.Length})";
    }
}

using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets.Ach;

public struct GetPlayerAchRspPacket : INetSerializable
{
    public string AchModelJson;
    public void Deserialize(NetDataReader reader)
    {
        AchModelJson = reader.GetString();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(AchModelJson);
    }

    public override string ToString()
    {
        return $"GetPlayerAchRspPacket | AchModelJson: {AchModelJson.Length}";
    }
}

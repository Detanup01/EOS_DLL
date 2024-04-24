using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets.Ach;

public struct GetPlayerAchReqPacket : INetSerializable
{
    public string AccountId;
    public string AchId;
    public void Deserialize(NetDataReader reader)
    {
        AccountId = reader.GetString();
        AchId = reader.GetString();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(AccountId);
        writer.Put(AchId);
    }

    public override string ToString()
    {
        return $"GetPlayerAchReqPacket | AccountId: {AccountId} AchId: {AchId}";
    }
}

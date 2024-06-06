using LiteNetLib.Utils;

namespace EOS_SDK._Networking.Packets;

public enum ReqEnum : byte
{
    NONE,
    Ach,
}

public struct ReqPacket : INetSerializable
{
    public ReqEnum Request;
    public void Deserialize(NetDataReader reader)
    {
        Request = (ReqEnum)reader.GetByte();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put((byte)Request);
    }

    public override string ToString()
    {
        return $"GetPlayerAchRspPacket | {Request}";
    }
}
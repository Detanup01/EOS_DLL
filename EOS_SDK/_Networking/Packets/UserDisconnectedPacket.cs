using LiteNetLib.Utils;
using System.Net;

namespace EOS_SDK._Networking.Packets;

public struct UserDisconnectedPacket : INetSerializable
{
    public string AccountId;
    public string AppId;
    public string IP;
    public void Deserialize(NetDataReader reader)
    {
        AccountId = reader.GetString();
        AppId = reader.GetString();
        IP = reader.GetString();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(AccountId);
        writer.Put(AppId);
        writer.Put(IP);
    }

    public override string ToString()
    {
        return $"UserDisconnectedPacket | AccountId: {AccountId} AppId: {AppId} IP: {IP}";
    }
}
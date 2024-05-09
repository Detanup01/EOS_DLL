using LiteNetLib.Utils;
using System.Net;

namespace EOS_SDK._Networking.Packets;

public struct UserConnectedPacket : INetSerializable
{
    public string AccountId;
    public string AppId;
    public IPEndPoint IP;
    public void Deserialize(NetDataReader reader)
    {
        AccountId = reader.GetString();
        AppId = reader.GetString();
        IP = reader.GetNetEndPoint();
    }

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(AccountId);
        writer.Put(AppId);
        writer.Put(IP);
    }

    public override string ToString()
    {
        return $"NewUserConnectedPacket | AccountId: {AccountId} AppId: {AppId} IP: {IP.Address}";
    }
}
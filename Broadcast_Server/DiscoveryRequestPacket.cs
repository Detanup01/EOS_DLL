using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        return $"DiscoveryRequestPacket | AccountId: {AccountId} UserId: {AppId}";
    }
}
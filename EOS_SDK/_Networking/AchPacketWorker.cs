using EOS_SDK._log;
using EOS_SDK._Networking.Packets.Ach;
using System.Net;

namespace EOS_SDK._Networking
{
    public class AchPacketWorker
    {
        public static void PlayerAchGet_Send(GetPlayerAchReqPacket getPlayerAchReqPacket, IPEndPoint iPEndPoint)
        {
            Logger.WriteDebug($"PlayerAchGet_Send: {getPlayerAchReqPacket} from {iPEndPoint}", Logging.LogCategory.Achievements);

        }

        public static void PlayerAchGet_Recv(GetPlayerAchRspPacket getPlayerAchRspPacket, IPEndPoint iPEndPoint)
        {
            Logger.WriteDebug($"PlayerAchGet_Send: {getPlayerAchRspPacket} from {iPEndPoint}", Logging.LogCategory.Achievements);

        }
    }
}

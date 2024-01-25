using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatClient
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddExternalIntegrityCatalogOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr PathToBinFile; // UTF-8 path to the .bin catalog file to add
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyClientIntegrityViolatedOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyMessageToPeerOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyMessageToServerOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyPeerActionRequiredOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyPeerAuthStatusChangedOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct BeginSessionOptions
    {
        public int ApiVersion { get => 3; }
        public IntPtr LocalUserId; //ProductUserId
        public AntiCheatClientMode Mode;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct EndSessionOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProtectMessageOutputLengthOptions
    {
        public int ApiVersion { get => 1; }
        public uint DataLengthBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PollStatusOptions
    {
        public int ApiVersion { get => 1; }
        public uint OutMessageLength;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ProtectMessageOptions
    {
        public int ApiVersion { get => 1; }
        public uint DataLengthBytes;
        /// <summary>
        /// The data to encrypt
        /// </summary>
        public IntPtr Data;
        /// <summary>
        /// The size in bytes of OutBuffer
        /// </summary>
        public uint OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ReceiveMessageFromPeerOptions
    {
        public int ApiVersion { get => 1; }
        /// <summary>
        /// The handle describing the sender of this message
        /// </summary>
        public IntPtr PeerHandle;
        public uint DataLengthBytes;
        /// <summary>
        /// The data received
        /// </summary>
        public IntPtr Data;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ReceiveMessageFromServerOptions
    {
        public int ApiVersion { get => 1; }
        public uint DataLengthBytes;
        /// <summary>
        /// The data received
        /// </summary>
        public IntPtr Data;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterPeerOptions
    {
        public int ApiVersion { get => 1; }
        /// <summary>
        /// Locally unique value describing the remote user (e.g. a player object pointer)
        /// </summary>
        public IntPtr PeerHandle;
        /// <summary>
        /// Type of remote user being registered
        /// </summary>
        public AntiCheatCommon.AntiCheatCommonClientType ClientType;
        /// <summary>
        /// Remote user's platform, if known
        /// </summary>
        public AntiCheatCommon.AntiCheatCommonClientPlatform ClientPlatform;
        /// <summary>
        /// Time in seconds to allow newly registered peers to send the initial message containing their token.
        /// </summary>
        public uint AuthenticationTimeout;
        /// <summary>
        /// Deprecated - use PeerProductUserId instead
        /// </summary>
        public IntPtr AccountId_DEPRECATED;
        /// <summary>
        /// Optional IP address for the remote user. May be null if not available.
        /// IPv4 format: "0.0.0.0"
        /// IPv6 format: "0:0:0:0:0:0:0:0"
        /// </summary>
        public IntPtr IpAddress;
        /// <summary>
        /// Identifier for the remote user
        /// </summary>
        public IntPtr PeerProductUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnprotectMessageOptions
    {
        public int ApiVersion { get => 1; }
        public uint DataLengthBytes;
        /// <summary>
        /// The data to decrypt
        /// </summary>
        public IntPtr Data;
        /// <summary>
        /// The size in bytes of OutBuffer
        /// </summary>
        public uint OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnregisterPeerOptions
    {
        public int ApiVersion { get => 1; }
        /// <summary>
        /// Locally unique value describing the remote user, as previously passed to RegisterPeer
        /// </summary>
        public IntPtr PeerHandle;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnClientIntegrityViolatedCallbackInfo
    {
        public IntPtr ClientData;
        public AntiCheatClientViolationType ViolationType;
        public IntPtr ViolationMessage;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnMessageToServerCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr MessageData;
        public uint MessageDataSizeBytes;
    }
}

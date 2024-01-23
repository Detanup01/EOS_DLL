﻿using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatClient
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddExternalIntegrityCatalogOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_PathToBinFile; // UTF-8 path to the .bin catalog file to add
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyClientIntegrityViolatedOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyMessageToPeerOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyMessageToServerOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyPeerActionRequiredOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyPeerAuthStatusChangedOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct BeginSessionOptions
    {
        public int m_ApiVersion { get => 3; }
        public IntPtr m_LocalUserId; //ProductUserId
        public AntiCheatClientMode m_Mode;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct EndSessionOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProtectMessageOutputLengthOptions
    {
        public int m_ApiVersion { get => 1; }
        public uint m_DataLengthBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PollStatusOptions
    {
        public int m_ApiVersion { get => 1; }
        public uint m_OutMessageLength;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ProtectMessageOptions
    {
        public int m_ApiVersion { get => 1; }
        public uint m_DataLengthBytes;
        /// <summary>
        /// The data to encrypt
        /// </summary>
        public IntPtr m_Data;
        /// <summary>
        /// The size in bytes of OutBuffer
        /// </summary>
        public uint m_OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ReceiveMessageFromPeerOptions
    {
        public int m_ApiVersion { get => 1; }
        /// <summary>
        /// The handle describing the sender of this message
        /// </summary>
        public IntPtr m_PeerHandle;
        public uint m_DataLengthBytes;
        /// <summary>
        /// The data received
        /// </summary>
        public IntPtr m_Data;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ReceiveMessageFromServerOptions
    {
        public int m_ApiVersion { get => 1; }
        public uint m_DataLengthBytes;
        /// <summary>
        /// The data received
        /// </summary>
        public IntPtr m_Data;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterPeerOptions
    {
        public int m_ApiVersion { get => 1; }
        /// <summary>
        /// Locally unique value describing the remote user (e.g. a player object pointer)
        /// </summary>
        public IntPtr m_PeerHandle;
        /// <summary>
        /// Type of remote user being registered
        /// </summary>
        public AntiCheatCommon.AntiCheatCommonClientType m_ClientType;
        /// <summary>
        /// Remote user's platform, if known
        /// </summary>
        public AntiCheatCommon.AntiCheatCommonClientPlatform m_ClientPlatform;
        /// <summary>
        /// Time in seconds to allow newly registered peers to send the initial message containing their token.
        /// </summary>
        public uint m_AuthenticationTimeout;
        /// <summary>
        /// Deprecated - use PeerProductUserId instead
        /// </summary>
        public IntPtr m_AccountId_DEPRECATED;
        /// <summary>
        /// Optional IP address for the remote user. May be null if not available.
        /// IPv4 format: "0.0.0.0"
        /// IPv6 format: "0:0:0:0:0:0:0:0"
        /// </summary>
        public IntPtr m_IpAddress;
        /// <summary>
        /// Identifier for the remote user
        /// </summary>
        public IntPtr m_PeerProductUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnprotectMessageOptions
    {
        public int m_ApiVersion { get => 1; }
        public uint m_DataLengthBytes;
        /// <summary>
        /// The data to decrypt
        /// </summary>
        public IntPtr m_Data;
        /// <summary>
        /// The size in bytes of OutBuffer
        /// </summary>
        public uint m_OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnregisterPeerOptions
    {
        public int m_ApiVersion { get => 1; }
        /// <summary>
        /// Locally unique value describing the remote user, as previously passed to RegisterPeer
        /// </summary>
        public IntPtr m_PeerHandle;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnClientIntegrityViolatedCallbackInfo
    {
        public IntPtr m_ClientData;
        public AntiCheatClientViolationType m_ViolationType;
        public IntPtr m_ViolationMessage;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnMessageToServerCallbackInfo
    {
        public IntPtr m_ClientData;
        public IntPtr m_MessageData;
        public uint m_MessageDataSizeBytes;
    }
}

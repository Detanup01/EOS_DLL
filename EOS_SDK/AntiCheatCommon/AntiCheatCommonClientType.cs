// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace EOS_SDK.AntiCheatCommon
{
    /// <summary>
    /// Flags describing the type of a remote client
    /// </summary>
    public enum AntiCheatCommonClientType : int
    {
        /// <summary>
        /// An ordinary player that requires anti-cheat client protection to play
        /// </summary>
        ProtectedClient = 0,
        /// <summary>
        /// The player does not need the anti-cheat client to play because of their platform or other factors
        /// </summary>
        UnprotectedClient = 1,
        /// <summary>
        /// The client is an AI bot, not an actual human
        /// </summary>
        AIBot = 2
    }
}
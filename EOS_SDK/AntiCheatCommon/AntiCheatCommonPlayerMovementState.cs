// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace EOS_SDK.AntiCheatCommon
{
    /// <summary>
    /// Details of a player's movement state
    /// </summary>
    public enum AntiCheatCommonPlayerMovementState : int
    {
        /// <summary>
        /// No particular state applies
        /// </summary>
        None = 0,
        /// <summary>
        /// Player is crouching
        /// </summary>
        Crouching = 1,
        /// <summary>
        /// Player is prone
        /// </summary>
        Prone = 2,
        /// <summary>
        /// Player is mounted in a vehicle or similar
        /// </summary>
        Mounted = 3,
        /// <summary>
        /// Player is swimming in a fluid volume
        /// </summary>
        Swimming = 4,
        /// <summary>
        /// Player is falling under the effects of gravity, such as when jumping or walking off the edge of a surface
        /// </summary>
        Falling = 5,
        /// <summary>
        /// Player is flying, ignoring the effects of gravity
        /// </summary>
        Flying = 6,
        /// <summary>
        /// Player is on a ladder
        /// </summary>
        OnLadder = 7
    }
}
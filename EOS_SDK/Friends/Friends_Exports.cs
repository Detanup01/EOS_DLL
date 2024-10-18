using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Friends
{
    public unsafe class Friends_Exports
    {
#if false
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Friends_AcceptInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AcceptInviteOptions = Marshal.PtrToStructure<AcceptInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnAcceptInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_Friends_AddNotifyBlockedUsersUpdate(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr blockedUsersUpdateHandler)
		{
			var _AddNotifyBlockedUsersUpdateOptions = Marshal.PtrToStructure<AddNotifyBlockedUsersUpdateOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)blockedUsersUpdateHandler; //Delegate Class was: Friends.OnBlockedUsersUpdateCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr friendsUpdateHandler)
		{
			var _AddNotifyFriendsUpdateOptions = Marshal.PtrToStructure<AddNotifyFriendsUpdateOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)friendsUpdateHandler; //Delegate Class was: Friends.OnFriendsUpdateCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_Friends_GetBlockedUserAtIndex(IntPtr handle, IntPtr options)
		{
			var _GetBlockedUserAtIndexOptions = Marshal.PtrToStructure<GetBlockedUserAtIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static int EOS_Friends_GetBlockedUsersCount(IntPtr handle, IntPtr options)
		{
			var _GetBlockedUsersCountOptions = Marshal.PtrToStructure<GetBlockedUsersCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, IntPtr options)
		{
			var _GetFriendAtIndexOptions = Marshal.PtrToStructure<GetFriendAtIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static int EOS_Friends_GetFriendsCount(IntPtr handle, IntPtr options)
		{
			var _GetFriendsCountOptions = Marshal.PtrToStructure<GetFriendsCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Friends.FriendsStatus EOS_Friends_GetStatus(IntPtr handle, IntPtr options)
		{
			var _GetStatusOptions = Marshal.PtrToStructure<GetStatusOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Friends_QueryFriends(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryFriendsOptions = Marshal.PtrToStructure<QueryFriendsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnQueryFriendsCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Friends_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptions = Marshal.PtrToStructure<RejectInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnRejectInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Friends_RemoveNotifyBlockedUsersUpdate(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Friends_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendInviteOptions = Marshal.PtrToStructure<SendInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnSendInviteCallback
        }
#endif
    }
}

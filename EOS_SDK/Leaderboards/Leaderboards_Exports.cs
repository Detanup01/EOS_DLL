using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Leaderboards
{
    public unsafe class Leaderboards_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, IntPtr options, IntPtr outLeaderboardDefinition)
		{
			var _CopyLeaderboardDefinitionByIndexOptions = Marshal.PtrToStructure<CopyLeaderboardDefinitionByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, IntPtr options, IntPtr outLeaderboardDefinition)
		{
			var _CopyLeaderboardDefinitionByLeaderboardIdOptions = Marshal.PtrToStructure<CopyLeaderboardDefinitionByLeaderboardIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, IntPtr options, IntPtr outLeaderboardRecord)
		{
			var _CopyLeaderboardRecordByIndexOptions = Marshal.PtrToStructure<CopyLeaderboardRecordByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, IntPtr options, IntPtr outLeaderboardRecord)
		{
			var _CopyLeaderboardRecordByUserIdOptions = Marshal.PtrToStructure<CopyLeaderboardRecordByUserIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, IntPtr options, IntPtr outLeaderboardUserScore)
		{
			var _CopyLeaderboardUserScoreByIndexOptions = Marshal.PtrToStructure<CopyLeaderboardUserScoreByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, IntPtr options, IntPtr outLeaderboardUserScore)
		{
			var _CopyLeaderboardUserScoreByUserIdOptions = Marshal.PtrToStructure<CopyLeaderboardUserScoreByUserIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, IntPtr options)
		{
			var _GetLeaderboardDefinitionCountOptions = Marshal.PtrToStructure<GetLeaderboardDefinitionCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, IntPtr options)
		{
			var _GetLeaderboardRecordCountOptions = Marshal.PtrToStructure<GetLeaderboardRecordCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, IntPtr options)
		{
			var _GetLeaderboardUserScoreCountOptions = Marshal.PtrToStructure<GetLeaderboardUserScoreCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryLeaderboardDefinitionsOptions = Marshal.PtrToStructure<QueryLeaderboardDefinitionsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Leaderboards.OnQueryLeaderboardDefinitionsCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryLeaderboardRanksOptions = Marshal.PtrToStructure<QueryLeaderboardRanksOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Leaderboards.OnQueryLeaderboardRanksCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryLeaderboardUserScoresOptions = Marshal.PtrToStructure<QueryLeaderboardUserScoresOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Leaderboards.OnQueryLeaderboardUserScoresCompleteCallback
        }
#endif
    }
}

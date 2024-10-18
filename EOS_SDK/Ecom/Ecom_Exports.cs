using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Ecom
{
    public unsafe class Ecom_Exports
    {
#if false
[UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_Checkout(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CheckoutOptions = Marshal.PtrToStructure<CheckoutOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnCheckoutCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyEntitlementById(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _CopyEntitlementByIdOptions = Marshal.PtrToStructure<CopyEntitlementByIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _CopyEntitlementByIndexOptions = Marshal.PtrToStructure<CopyEntitlementByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _CopyEntitlementByNameAndIndexOptions = Marshal.PtrToStructure<CopyEntitlementByNameAndIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyItemById(IntPtr handle, IntPtr options, IntPtr outItem)
		{
			var _CopyItemByIdOptions = Marshal.PtrToStructure<CopyItemByIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, IntPtr options, IntPtr outImageInfo)
		{
			var _CopyItemImageInfoByIndexOptions = Marshal.PtrToStructure<CopyItemImageInfoByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, IntPtr options, IntPtr outRelease)
		{
			var _CopyItemReleaseByIndexOptions = Marshal.PtrToStructure<CopyItemReleaseByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyLastRedeemedEntitlementByIndex(IntPtr handle, IntPtr options, IntPtr outRedeemedEntitlementId, [Out] int inOutRedeemedEntitlementIdLength)
		{
			var _CopyLastRedeemedEntitlementByIndexOptions = Marshal.PtrToStructure<CopyLastRedeemedEntitlementByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyOfferById(IntPtr handle, IntPtr options, IntPtr outOffer)
		{
			var _CopyOfferByIdOptions = Marshal.PtrToStructure<CopyOfferByIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, IntPtr options, IntPtr outOffer)
		{
			var _CopyOfferByIndexOptions = Marshal.PtrToStructure<CopyOfferByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, IntPtr options, IntPtr outImageInfo)
		{
			var _CopyOfferImageInfoByIndexOptions = Marshal.PtrToStructure<CopyOfferImageInfoByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, IntPtr options, IntPtr outItem)
		{
			var _CopyOfferItemByIndexOptions = Marshal.PtrToStructure<CopyOfferItemByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyTransactionById(IntPtr handle, IntPtr options, IntPtr outTransaction)
		{
			var _CopyTransactionByIdOptions = Marshal.PtrToStructure<CopyTransactionByIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, IntPtr options, IntPtr outTransaction)
		{
			var _CopyTransactionByIndexOptions = Marshal.PtrToStructure<CopyTransactionByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_Entitlement_Release(IntPtr entitlement)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, IntPtr options)
		{
			var _GetEntitlementsByNameCountOptions = Marshal.PtrToStructure<GetEntitlementsByNameCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, IntPtr options)
		{
			var _GetEntitlementsCountOptions = Marshal.PtrToStructure<GetEntitlementsCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, IntPtr options)
		{
			var _GetItemImageInfoCountOptions = Marshal.PtrToStructure<GetItemImageInfoCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, IntPtr options)
		{
			var _GetItemReleaseCountOptions = Marshal.PtrToStructure<GetItemReleaseCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetLastRedeemedEntitlementsCount(IntPtr handle, IntPtr options)
		{
			var _GetLastRedeemedEntitlementsCountOptions = Marshal.PtrToStructure<GetLastRedeemedEntitlementsCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetOfferCount(IntPtr handle, IntPtr options)
		{
			var _GetOfferCountOptions = Marshal.PtrToStructure<GetOfferCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, IntPtr options)
		{
			var _GetOfferImageInfoCountOptions = Marshal.PtrToStructure<GetOfferImageInfoCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetOfferItemCount(IntPtr handle, IntPtr options)
		{
			var _GetOfferItemCountOptions = Marshal.PtrToStructure<GetOfferItemCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_GetTransactionCount(IntPtr handle, IntPtr options)
		{
			var _GetTransactionCountOptions = Marshal.PtrToStructure<GetTransactionCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_QueryEntitlementToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryEntitlementTokenOptions = Marshal.PtrToStructure<QueryEntitlementTokenOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryEntitlementTokenCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_QueryEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryEntitlementsOptions = Marshal.PtrToStructure<QueryEntitlementsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryEntitlementsCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_QueryOffers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOffersOptions = Marshal.PtrToStructure<QueryOffersOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOffersCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_QueryOwnership(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOwnershipOptions = Marshal.PtrToStructure<QueryOwnershipOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOwnershipCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_QueryOwnershipBySandboxIds(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOwnershipBySandboxIdsOptions = Marshal.PtrToStructure<QueryOwnershipBySandboxIdsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOwnershipBySandboxIdsCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_QueryOwnershipToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOwnershipTokenOptions = Marshal.PtrToStructure<QueryOwnershipTokenOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOwnershipTokenCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_RedeemEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RedeemEntitlementsOptions = Marshal.PtrToStructure<RedeemEntitlementsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnRedeemEntitlementsCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _TransactionCopyEntitlementByIndexOptions = Marshal.PtrToStructure<TransactionCopyEntitlementByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, IntPtr options)
		{
			var _TransactionGetEntitlementsCountOptions = Marshal.PtrToStructure<TransactionGetEntitlementsCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Ecom_Transaction_Release(IntPtr transaction)
        {
        }
#endif
    }
}

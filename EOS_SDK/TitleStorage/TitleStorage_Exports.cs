using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.TitleStorage
{
    public unsafe class TitleStorage_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_TitleStorageFileTransferRequest_CancelRequest(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_TitleStorageFileTransferRequest_GetFileRequestState(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_TitleStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, [Out] int outStringLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_TitleStorageFileTransferRequest_Release(IntPtr titleStorageFileTransferHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr options, IntPtr outMetadata)
		{
			var _CopyFileMetadataAtIndexOptions = Marshal.PtrToStructure<CopyFileMetadataAtIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr options, IntPtr outMetadata)
		{
			var _CopyFileMetadataByFilenameOptions = Marshal.PtrToStructure<CopyFileMetadataByFilenameOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_TitleStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _DeleteCacheOptions = Marshal.PtrToStructure<DeleteCacheOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnDeleteCacheCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, IntPtr options)
		{
			var _GetFileMetadataCountOptions = Marshal.PtrToStructure<GetFileMetadataCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_TitleStorage_QueryFile(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileOptions = Marshal.PtrToStructure<QueryFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnQueryFileCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_TitleStorage_QueryFileList(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileListOptions = Marshal.PtrToStructure<QueryFileListOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnQueryFileListCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _ReadFileOptions = Marshal.PtrToStructure<ReadFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnReadFileCompleteCallback
        }
#endif
    }
}

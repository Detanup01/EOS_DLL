using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.PlayerDataStorage
{
    public unsafe class PlayerDataStorage_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorageFileTransferRequest_CancelRequest(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorageFileTransferRequest_GetFileRequestState(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, [Out] int outStringLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_PlayerDataStorageFileTransferRequest_Release(IntPtr playerDataStorageFileTransferHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr copyFileMetadataOptions, IntPtr outMetadata)
		{
			var _CopyFileMetadataAtIndexOptions = Marshal.PtrToStructure<CopyFileMetadataAtIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr copyFileMetadataOptions, IntPtr outMetadata)
		{
			var _CopyFileMetadataByFilenameOptions = Marshal.PtrToStructure<CopyFileMetadataByFilenameOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _DeleteCacheOptions = Marshal.PtrToStructure<DeleteCacheOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnDeleteCacheCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, IntPtr deleteOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _DeleteFileOptions = Marshal.PtrToStructure<DeleteFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnDeleteFileCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, IntPtr duplicateOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _DuplicateFileOptions = Marshal.PtrToStructure<DuplicateFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnDuplicateFileCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, IntPtr getFileMetadataCountOptions, [Out] int outFileMetadataCount)
		{
			var _GetFileMetadataCountOptions = Marshal.PtrToStructure<GetFileMetadataCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_PlayerDataStorage_QueryFile(IntPtr handle, IntPtr queryFileOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileOptions = Marshal.PtrToStructure<QueryFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnQueryFileCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, IntPtr queryFileListOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileListOptions = Marshal.PtrToStructure<QueryFileListOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnQueryFileListCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, IntPtr readOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _ReadFileOptions = Marshal.PtrToStructure<ReadFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnReadFileCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, IntPtr writeOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _WriteFileOptions = Marshal.PtrToStructure<WriteFileOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnWriteFileCompleteCallback
        }
#endif
    }
}

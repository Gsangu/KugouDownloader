using System;
using System.Runtime.InteropServices;

public static class XL
{
    [DllImport("xldl.dll", CharSet = CharSet.Unicode)]
    public static extern  bool XL_Init();

    [DllImport("xldl.dll", CharSet = CharSet.Unicode)]
    public static extern  bool XL_UnInit();

    [DllImport("xldl.dll", CallingConvention  = CallingConvention.Cdecl)]
    public static extern  IntPtr XL_CreateTask([In()]DownTaskParam stParam);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  bool XL_StartTask(IntPtr hTask);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  bool XL_StopTask(IntPtr hTask);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  object XL_SetSpeedLimit(Int32 nKBps);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int XL_CreateTaskByThunder(string pszUrl, string pszFileName, string pszReferUrl, string pszCharSet, string pszCookie);
    //LONG XL_CreateTaskByThunder(wchar_t *pszUrl, wchar_t *pszFileName, wchar_t *pszReferUrl, wchar_t *pszCharSet, wchar_t *pszCookie)
    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  object XL_SetUploadSpeedLimit(Int32 nTcpKBps, Int32 nOtherKBps);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  object XL_SetProxy(DOWN_PROXY_INFO stProxyInfo);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  object XL_DelTempFile(DownTaskParam stParam);
 
    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  bool XL_DeleteTask(IntPtr hTask);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  bool XL_GetBtDataFileList(string szFilePath, string szSeedFileFullPath);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  bool XL_SetUserAgent(string pszUserAgent);

    [DllImport("xldl.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern  bool XL_GetFileSizeWithUrl(string lpURL, Int64 iFileSize);

    [DllImportAttribute("xldl.dll", EntryPoint = "XL_QueryTaskInfoEx", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAsAttribute(UnmanagedType.Bool)]
    public static extern  bool XL_QueryTaskInfoEx(IntPtr hTask, [Out()]DownTaskInfo stTaskInfo);

    [DllImportAttribute("xldl.dll", EntryPoint = "XL_QueryTaskInfoEx", CallingConvention = CallingConvention.Cdecl)]
    public static extern  IntPtr XL_CreateBTTask(DownBTTaskParam stParam);

    [DllImportAttribute("xldl.dll", EntryPoint = "XL_QueryTaskInfoEx", CallingConvention = CallingConvention.Cdecl)]
    public static extern  long XL_QueryBTFileInfo(IntPtr hTask, UIntPtr dwFileIndex, ulong ullFileSize, ulong ullCompleteSize, UIntPtr dwStatus);

    [DllImportAttribute("xldl.dll", EntryPoint = "XL_QueryTaskInfoEx", CallingConvention = CallingConvention.Cdecl)]
    public static extern  long XL_QueryBTFileInfo(IntPtr hTask, BTTaskInfo pTaskInfo);


    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class DownTaskParam
    {
        public int nReserved;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2084)]
        public string szTaskUrl;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2084)]
        public string szRefUrl;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4096)]
        public string szCookies;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szFilename;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szReserved0;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szSavePath;
        public IntPtr hReserved;
        public int bReserved = 0;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szReserved1;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szReserved2;
        public int IsOnlyOriginal = 0;
        public uint nReserved1 = 5;
        public int DisableAutoRename = 0;
        public int IsResume = 1;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2048, ArraySubType = UnmanagedType.U4)]
        public uint[] reserved;
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct BTTaskInfo
    {

        ///LONG->int

        public int lTaskStatus;
        ///DWORD->unsigned int

        public uint dwUsingResCount;
        ///DWORD->unsigned int

        public uint dwSumResCount;
        ///ULONGLONG->unsigned __int64

        public ulong ullRecvBytes;
        ///ULONGLONG->unsigned __int64

        public ulong ullSendBytes;
        ///BOOL->int
        [MarshalAsAttribute(UnmanagedType.Bool)]

        public bool bFileCreated;
        ///DWORD->unsigned int

        public uint dwSeedCount;
        ///DWORD->unsigned int

        public uint dwConnectedBTPeerCount;
        ///DWORD->unsigned int

        public uint dwAllBTPeerCount;
        ///DWORD->unsigned int
        public uint dwHealthyGrade;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class DownTaskInfo
    {
        public DOWN_TASK_STATUS stat;
        public TASK_ERROR_TYPE fail_code;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szFilename;
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szReserved0;
        public long nTotalSize;
        public long nTotalDownload;
        public float fPercent;
        public int nReserved0;
        public int nSrcTotal;
        public int nSrcUsing;
        public int nReserved1;
        public int nReserved2;

        public int nReserved3;
        ///int

        public int nReserved4;
        ///__int64

        public long nReserved5;
        ///__int64

        public long nDonationP2P;
        ///__int64

        public long nReserved6;
        ///__int64

        public long nDonationOrgin;
        ///__int64

        public long nDonationP2S;
        ///__int64

        public long nReserved7;
        ///__int64

        public long nReserved8;
        ///int

        public int nSpeed;
        ///int

        public int nSpeedP2S;
        ///int

        public int nSpeedP2P;
        ///boolean

        public bool bIsOriginUsable;
        ///float

        public float fHashPercent;
        ///int

        public int IsCreatingFile;
        ///DWORD[64]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U4)]
        public uint[] reserved;
    }

    public enum DOWN_TASK_STATUS
    {

        ///NOITEM -> 0
        NOITEM = 0,

        TSC_ERROR,

        TSC_PAUSE,

        TSC_DOWNLOAD,

        TSC_COMPLETE,

        TSC_STARTPENDING,

        TSC_STOPPENDING
    }

    public enum TASK_ERROR_TYPE
    {

        ///TASK_ERROR_UNKNOWN -> 0x00
        TASK_ERROR_UNKNOWN = 0,

        ///TASK_ERROR_DISK_CREATE -> 0x01
        TASK_ERROR_DISK_CREATE = 1,

        ///TASK_ERROR_DISK_WRITE -> 0x02
        TASK_ERROR_DISK_WRITE = 2,

        ///TASK_ERROR_DISK_READ -> 0x03
        TASK_ERROR_DISK_READ = 3,

        ///TASK_ERROR_DISK_RENAME -> 0x04
        TASK_ERROR_DISK_RENAME = 4,

        ///TASK_ERROR_DISK_PIECEHASH -> 0x05
        TASK_ERROR_DISK_PIECEHASH = 5,

        ///TASK_ERROR_DISK_FILEHASH -> 0x06
        TASK_ERROR_DISK_FILEHASH = 6,

        ///TASK_ERROR_DISK_DELETE -> 0x07
        TASK_ERROR_DISK_DELETE = 7,

        ///TASK_ERROR_DOWN_INVALID -> 0x10
        TASK_ERROR_DOWN_INVALID = 16,

        ///TASK_ERROR_PROXY_AUTH_TYPE_UNKOWN -> 0x20
        TASK_ERROR_PROXY_AUTH_TYPE_UNKOWN = 32,

        ///TASK_ERROR_PROXY_AUTH_TYPE_FAILED -> 0x21
        TASK_ERROR_PROXY_AUTH_TYPE_FAILED = 33,

        ///TASK_ERROR_HTTPMGR_NOT_IP -> 0x30
        TASK_ERROR_HTTPMGR_NOT_IP = 48,

        ///TASK_ERROR_TIMEOUT -> 0x40
        TASK_ERROR_TIMEOUT = 64,

        ///TASK_ERROR_CANCEL -> 0x41
        TASK_ERROR_CANCEL = 65,

        ///TASK_ERROR_TP_CRASHED -> 0x42
        TASK_ERROR_TP_CRASHED = 66,

        ///TASK_ERROR_ID_INVALID -> 0x43
        TASK_ERROR_ID_INVALID = 67
    }
    public enum DOWN_PROXY_TYPE
    {

        ///PROXY_TYPE_IE -> 0
        PROXY_TYPE_IE = 0,

        ///PROXY_TYPE_HTTP -> 1
        PROXY_TYPE_HTTP = 1,

        ///PROXY_TYPE_SOCK4 -> 2
        PROXY_TYPE_SOCK4 = 2,

        ///PROXY_TYPE_SOCK5 -> 3
        PROXY_TYPE_SOCK5 = 3,

        ///PROXY_TYPE_FTP -> 4
        PROXY_TYPE_FTP = 4,

        ///PROXY_TYPE_UNKOWN -> 255
        PROXY_TYPE_UNKOWN = 255
    }

    public enum DOWN_PROXY_AUTH_TYPE
    {

        ///PROXY_AUTH_NONE -> 0
        PROXY_AUTH_NONE = 0,

        PROXY_AUTH_AUTO,

        PROXY_AUTH_BASE64,

        PROXY_AUTH_NTLM,

        PROXY_AUTH_DEGEST,

        PROXY_AUTH_UNKOWN
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class DOWN_PROXY_INFO
    {

        ///BOOL->int
        [MarshalAsAttribute(UnmanagedType.Bool)]

        public bool bIEProxy;
        ///BOOL->int
        [MarshalAsAttribute(UnmanagedType.Bool)]

        public bool bProxy;
        ///DOWN_PROXY_TYPE

        public DOWN_PROXY_TYPE stPType;
        ///DOWN_PROXY_AUTH_TYPE

        public DOWN_PROXY_AUTH_TYPE stAType;
        ///wchar_t[2048]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2048)]

        public string szHost;
        ///INT32->int

        public int nPort;
        ///wchar_t[50]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]

        public string szUser;
        ///wchar_t[50]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]

        public string szPwd;
        ///wchar_t[2048]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2048)]
        public string szDomain;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class TrackerInfo
    {

        ///TCHAR[1024]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string szTrackerUrl;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class DownBTTaskParam
    {

        ///TCHAR[260]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]

        public string szSeedFullPath;
        ///TCHAR[260]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 260)]

        public string szFilePath;
        ///DWORD->unsigned int

        public uint dwNeedDownloadFileCount;
        ///DWORD*

        public IntPtr dwNeedDownloadFileIndexArray;
        ///DWORD->unsigned int

        public uint dwTrackerInfoCount;
        ///TrackerInfo*

        public IntPtr pTrackerInfoArray;
        ///BOOL->int
        public int IsResume;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class tracker_info
    {

        ///DWORD->unsigned int

        public uint tracker_url_len;
        ///CHAR[1024]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string tracker_url;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class bt_file_info
    {

        ///ULONGLONG->unsigned __int64

        public ulong file_size;
        ///DWORD->unsigned int

        public uint path_len;
        ///CHAR[256]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 256)]

        public string file_path;
        ///DWORD->unsigned int

        public uint name_len;
        ///CHAR[1024]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string file_name;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class bt_seed_file_info
    {

        ///CHAR[20]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]

        public string info_id;
        ///DWORD->unsigned int

        public uint title_len;
        ///CHAR[1024]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 1024)]

        public string title;
        ///DWORD->unsigned int

        public uint file_info_count;
        ///bt_file_info*

        public IntPtr file_info_array;
        ///DWORD->unsigned int

        public uint tracker_count;
        ///tracker_info*

        public IntPtr tracker_info_array;
        ///DWORD->unsigned int

        public uint publisher_len;
        ///CHAR[8192]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 8192)]

        public string publisher;
        ///DWORD->unsigned int

        public uint publisher_url_len;
        ///CHAR[1024]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string publisher_url;
    }

    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class bt_data_file_item
    {

        ///DWORD->unsigned int

        public uint path_len;
        ///CHAR[256]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 256)]

        public string file_path;
        ///DWORD->unsigned int

        public uint name_len;
        ///CHAR[1024]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string file_name;
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    public class bt_data_file_list
    {
        public uint item_count;
        public IntPtr item_array;
    }
}


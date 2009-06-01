using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_TermService_TerminalServicesSession : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_HandleCount;
        
        private uint m_InputAsyncFrameError;
        
        private uint m_InputAsyncOverflow;
        
        private uint m_InputAsyncOverrun;
        
        private uint m_InputAsyncParityError;
        
        private uint m_InputBytes;
        
        private uint m_InputCompressedBytes;
        
        private uint m_InputCompressFlushes;
        
        private uint m_InputCompressionRatio;
        
        private uint m_InputErrors;
        
        private uint m_InputFrames;
        
        private uint m_InputTimeouts;
        
        private uint m_InputTransportErrors;
        
        private uint m_InputWaitForOutBuf;
        
        private uint m_InputWdBytes;
        
        private uint m_InputWdFrames;
        
        private string m_Name;
        
        private uint m_OutputAsyncFrameError;
        
        private uint m_OutputAsyncOverflow;
        
        private uint m_OutputAsyncOverrun;
        
        private uint m_OutputAsyncParityError;
        
        private uint m_OutputBytes;
        
        private uint m_OutputCompressedBytes;
        
        private uint m_OutputCompressFlushes;
        
        private uint m_OutputCompressionRatio;
        
        private uint m_OutputErrors;
        
        private uint m_OutputFrames;
        
        private uint m_OutputTimeouts;
        
        private uint m_OutputTransportErrors;
        
        private uint m_OutputWaitForOutBuf;
        
        private uint m_OutputWdBytes;
        
        private uint m_OutputWdFrames;
        
        private uint m_PageFaultsPersec;
        
        private ulong m_PageFileBytes;
        
        private ulong m_PageFileBytesPeak;
        
        private ulong m_PercentPrivilegedTime;
        
        private ulong m_PercentProcessorTime;
        
        private ulong m_PercentUserTime;
        
        private uint m_PoolNonpagedBytes;
        
        private uint m_PoolPagedBytes;
        
        private ulong m_PrivateBytes;
        
        private uint m_ProtocolBitmapCacheHitRatio;
        
        private uint m_ProtocolBitmapCacheHits;
        
        private uint m_ProtocolBitmapCacheReads;
        
        private uint m_ProtocolBrushCacheHitRatio;
        
        private uint m_ProtocolBrushCacheHits;
        
        private uint m_ProtocolBrushCacheReads;
        
        private uint m_ProtocolGlyphCacheHitRatio;
        
        private uint m_ProtocolGlyphCacheHits;
        
        private uint m_ProtocolGlyphCacheReads;
        
        private uint m_ProtocolSaveScreenBitmapCacheHitRatio;
        
        private uint m_ProtocolSaveScreenBitmapCacheHits;
        
        private uint m_ProtocolSaveScreenBitmapCacheReads;
        
        private uint m_ThreadCount;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalAsyncFrameError;
        
        private uint m_TotalAsyncOverflow;
        
        private uint m_TotalAsyncOverrun;
        
        private uint m_TotalAsyncParityError;
        
        private uint m_TotalBytes;
        
        private uint m_TotalCompressedBytes;
        
        private uint m_TotalCompressFlushes;
        
        private uint m_TotalCompressionRatio;
        
        private uint m_TotalErrors;
        
        private uint m_TotalFrames;
        
        private uint m_TotalProtocolCacheHitRatio;
        
        private uint m_TotalProtocolCacheHits;
        
        private uint m_TotalProtocolCacheReads;
        
        private uint m_TotalTimeouts;
        
        private uint m_TotalTransportErrors;
        
        private uint m_TotalWaitForOutBuf;
        
        private uint m_TotalWdBytes;
        
        private uint m_TotalWdFrames;
        
        private ulong m_VirtualBytes;
        
        private ulong m_VirtualBytesPeak;
        
        private ulong m_WorkingSet;
        
        private ulong m_WorkingSetPeak;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_TermService_TerminalServicesSession()
        {
        }
        
        public string Caption
        {
            get
            {
                return this.m_Caption;
            }
            set
            {
                this.m_Caption = value;
            }
        }
        
        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }
        
        public ulong Frequency_Object
        {
            get
            {
                return this.m_Frequency_Object;
            }
            set
            {
                this.m_Frequency_Object = value;
            }
        }
        
        public ulong Frequency_PerfTime
        {
            get
            {
                return this.m_Frequency_PerfTime;
            }
            set
            {
                this.m_Frequency_PerfTime = value;
            }
        }
        
        public ulong Frequency_Sys100NS
        {
            get
            {
                return this.m_Frequency_Sys100NS;
            }
            set
            {
                this.m_Frequency_Sys100NS = value;
            }
        }
        
        public uint HandleCount
        {
            get
            {
                return this.m_HandleCount;
            }
            set
            {
                this.m_HandleCount = value;
            }
        }
        
        public uint InputAsyncFrameError
        {
            get
            {
                return this.m_InputAsyncFrameError;
            }
            set
            {
                this.m_InputAsyncFrameError = value;
            }
        }
        
        public uint InputAsyncOverflow
        {
            get
            {
                return this.m_InputAsyncOverflow;
            }
            set
            {
                this.m_InputAsyncOverflow = value;
            }
        }
        
        public uint InputAsyncOverrun
        {
            get
            {
                return this.m_InputAsyncOverrun;
            }
            set
            {
                this.m_InputAsyncOverrun = value;
            }
        }
        
        public uint InputAsyncParityError
        {
            get
            {
                return this.m_InputAsyncParityError;
            }
            set
            {
                this.m_InputAsyncParityError = value;
            }
        }
        
        public uint InputBytes
        {
            get
            {
                return this.m_InputBytes;
            }
            set
            {
                this.m_InputBytes = value;
            }
        }
        
        public uint InputCompressedBytes
        {
            get
            {
                return this.m_InputCompressedBytes;
            }
            set
            {
                this.m_InputCompressedBytes = value;
            }
        }
        
        public uint InputCompressFlushes
        {
            get
            {
                return this.m_InputCompressFlushes;
            }
            set
            {
                this.m_InputCompressFlushes = value;
            }
        }
        
        public uint InputCompressionRatio
        {
            get
            {
                return this.m_InputCompressionRatio;
            }
            set
            {
                this.m_InputCompressionRatio = value;
            }
        }
        
        public uint InputErrors
        {
            get
            {
                return this.m_InputErrors;
            }
            set
            {
                this.m_InputErrors = value;
            }
        }
        
        public uint InputFrames
        {
            get
            {
                return this.m_InputFrames;
            }
            set
            {
                this.m_InputFrames = value;
            }
        }
        
        public uint InputTimeouts
        {
            get
            {
                return this.m_InputTimeouts;
            }
            set
            {
                this.m_InputTimeouts = value;
            }
        }
        
        public uint InputTransportErrors
        {
            get
            {
                return this.m_InputTransportErrors;
            }
            set
            {
                this.m_InputTransportErrors = value;
            }
        }
        
        public uint InputWaitForOutBuf
        {
            get
            {
                return this.m_InputWaitForOutBuf;
            }
            set
            {
                this.m_InputWaitForOutBuf = value;
            }
        }
        
        public uint InputWdBytes
        {
            get
            {
                return this.m_InputWdBytes;
            }
            set
            {
                this.m_InputWdBytes = value;
            }
        }
        
        public uint InputWdFrames
        {
            get
            {
                return this.m_InputWdFrames;
            }
            set
            {
                this.m_InputWdFrames = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }
        
        public uint OutputAsyncFrameError
        {
            get
            {
                return this.m_OutputAsyncFrameError;
            }
            set
            {
                this.m_OutputAsyncFrameError = value;
            }
        }
        
        public uint OutputAsyncOverflow
        {
            get
            {
                return this.m_OutputAsyncOverflow;
            }
            set
            {
                this.m_OutputAsyncOverflow = value;
            }
        }
        
        public uint OutputAsyncOverrun
        {
            get
            {
                return this.m_OutputAsyncOverrun;
            }
            set
            {
                this.m_OutputAsyncOverrun = value;
            }
        }
        
        public uint OutputAsyncParityError
        {
            get
            {
                return this.m_OutputAsyncParityError;
            }
            set
            {
                this.m_OutputAsyncParityError = value;
            }
        }
        
        public uint OutputBytes
        {
            get
            {
                return this.m_OutputBytes;
            }
            set
            {
                this.m_OutputBytes = value;
            }
        }
        
        public uint OutputCompressedBytes
        {
            get
            {
                return this.m_OutputCompressedBytes;
            }
            set
            {
                this.m_OutputCompressedBytes = value;
            }
        }
        
        public uint OutputCompressFlushes
        {
            get
            {
                return this.m_OutputCompressFlushes;
            }
            set
            {
                this.m_OutputCompressFlushes = value;
            }
        }
        
        public uint OutputCompressionRatio
        {
            get
            {
                return this.m_OutputCompressionRatio;
            }
            set
            {
                this.m_OutputCompressionRatio = value;
            }
        }
        
        public uint OutputErrors
        {
            get
            {
                return this.m_OutputErrors;
            }
            set
            {
                this.m_OutputErrors = value;
            }
        }
        
        public uint OutputFrames
        {
            get
            {
                return this.m_OutputFrames;
            }
            set
            {
                this.m_OutputFrames = value;
            }
        }
        
        public uint OutputTimeouts
        {
            get
            {
                return this.m_OutputTimeouts;
            }
            set
            {
                this.m_OutputTimeouts = value;
            }
        }
        
        public uint OutputTransportErrors
        {
            get
            {
                return this.m_OutputTransportErrors;
            }
            set
            {
                this.m_OutputTransportErrors = value;
            }
        }
        
        public uint OutputWaitForOutBuf
        {
            get
            {
                return this.m_OutputWaitForOutBuf;
            }
            set
            {
                this.m_OutputWaitForOutBuf = value;
            }
        }
        
        public uint OutputWdBytes
        {
            get
            {
                return this.m_OutputWdBytes;
            }
            set
            {
                this.m_OutputWdBytes = value;
            }
        }
        
        public uint OutputWdFrames
        {
            get
            {
                return this.m_OutputWdFrames;
            }
            set
            {
                this.m_OutputWdFrames = value;
            }
        }
        
        public uint PageFaultsPersec
        {
            get
            {
                return this.m_PageFaultsPersec;
            }
            set
            {
                this.m_PageFaultsPersec = value;
            }
        }
        
        public ulong PageFileBytes
        {
            get
            {
                return this.m_PageFileBytes;
            }
            set
            {
                this.m_PageFileBytes = value;
            }
        }
        
        public ulong PageFileBytesPeak
        {
            get
            {
                return this.m_PageFileBytesPeak;
            }
            set
            {
                this.m_PageFileBytesPeak = value;
            }
        }
        
        public ulong PercentPrivilegedTime
        {
            get
            {
                return this.m_PercentPrivilegedTime;
            }
            set
            {
                this.m_PercentPrivilegedTime = value;
            }
        }
        
        public ulong PercentProcessorTime
        {
            get
            {
                return this.m_PercentProcessorTime;
            }
            set
            {
                this.m_PercentProcessorTime = value;
            }
        }
        
        public ulong PercentUserTime
        {
            get
            {
                return this.m_PercentUserTime;
            }
            set
            {
                this.m_PercentUserTime = value;
            }
        }
        
        public uint PoolNonpagedBytes
        {
            get
            {
                return this.m_PoolNonpagedBytes;
            }
            set
            {
                this.m_PoolNonpagedBytes = value;
            }
        }
        
        public uint PoolPagedBytes
        {
            get
            {
                return this.m_PoolPagedBytes;
            }
            set
            {
                this.m_PoolPagedBytes = value;
            }
        }
        
        public ulong PrivateBytes
        {
            get
            {
                return this.m_PrivateBytes;
            }
            set
            {
                this.m_PrivateBytes = value;
            }
        }
        
        public uint ProtocolBitmapCacheHitRatio
        {
            get
            {
                return this.m_ProtocolBitmapCacheHitRatio;
            }
            set
            {
                this.m_ProtocolBitmapCacheHitRatio = value;
            }
        }
        
        public uint ProtocolBitmapCacheHits
        {
            get
            {
                return this.m_ProtocolBitmapCacheHits;
            }
            set
            {
                this.m_ProtocolBitmapCacheHits = value;
            }
        }
        
        public uint ProtocolBitmapCacheReads
        {
            get
            {
                return this.m_ProtocolBitmapCacheReads;
            }
            set
            {
                this.m_ProtocolBitmapCacheReads = value;
            }
        }
        
        public uint ProtocolBrushCacheHitRatio
        {
            get
            {
                return this.m_ProtocolBrushCacheHitRatio;
            }
            set
            {
                this.m_ProtocolBrushCacheHitRatio = value;
            }
        }
        
        public uint ProtocolBrushCacheHits
        {
            get
            {
                return this.m_ProtocolBrushCacheHits;
            }
            set
            {
                this.m_ProtocolBrushCacheHits = value;
            }
        }
        
        public uint ProtocolBrushCacheReads
        {
            get
            {
                return this.m_ProtocolBrushCacheReads;
            }
            set
            {
                this.m_ProtocolBrushCacheReads = value;
            }
        }
        
        public uint ProtocolGlyphCacheHitRatio
        {
            get
            {
                return this.m_ProtocolGlyphCacheHitRatio;
            }
            set
            {
                this.m_ProtocolGlyphCacheHitRatio = value;
            }
        }
        
        public uint ProtocolGlyphCacheHits
        {
            get
            {
                return this.m_ProtocolGlyphCacheHits;
            }
            set
            {
                this.m_ProtocolGlyphCacheHits = value;
            }
        }
        
        public uint ProtocolGlyphCacheReads
        {
            get
            {
                return this.m_ProtocolGlyphCacheReads;
            }
            set
            {
                this.m_ProtocolGlyphCacheReads = value;
            }
        }
        
        public uint ProtocolSaveScreenBitmapCacheHitRatio
        {
            get
            {
                return this.m_ProtocolSaveScreenBitmapCacheHitRatio;
            }
            set
            {
                this.m_ProtocolSaveScreenBitmapCacheHitRatio = value;
            }
        }
        
        public uint ProtocolSaveScreenBitmapCacheHits
        {
            get
            {
                return this.m_ProtocolSaveScreenBitmapCacheHits;
            }
            set
            {
                this.m_ProtocolSaveScreenBitmapCacheHits = value;
            }
        }
        
        public uint ProtocolSaveScreenBitmapCacheReads
        {
            get
            {
                return this.m_ProtocolSaveScreenBitmapCacheReads;
            }
            set
            {
                this.m_ProtocolSaveScreenBitmapCacheReads = value;
            }
        }
        
        public uint ThreadCount
        {
            get
            {
                return this.m_ThreadCount;
            }
            set
            {
                this.m_ThreadCount = value;
            }
        }
        
        public ulong Timestamp_Object
        {
            get
            {
                return this.m_Timestamp_Object;
            }
            set
            {
                this.m_Timestamp_Object = value;
            }
        }
        
        public ulong Timestamp_PerfTime
        {
            get
            {
                return this.m_Timestamp_PerfTime;
            }
            set
            {
                this.m_Timestamp_PerfTime = value;
            }
        }
        
        public ulong Timestamp_Sys100NS
        {
            get
            {
                return this.m_Timestamp_Sys100NS;
            }
            set
            {
                this.m_Timestamp_Sys100NS = value;
            }
        }
        
        public uint TotalAsyncFrameError
        {
            get
            {
                return this.m_TotalAsyncFrameError;
            }
            set
            {
                this.m_TotalAsyncFrameError = value;
            }
        }
        
        public uint TotalAsyncOverflow
        {
            get
            {
                return this.m_TotalAsyncOverflow;
            }
            set
            {
                this.m_TotalAsyncOverflow = value;
            }
        }
        
        public uint TotalAsyncOverrun
        {
            get
            {
                return this.m_TotalAsyncOverrun;
            }
            set
            {
                this.m_TotalAsyncOverrun = value;
            }
        }
        
        public uint TotalAsyncParityError
        {
            get
            {
                return this.m_TotalAsyncParityError;
            }
            set
            {
                this.m_TotalAsyncParityError = value;
            }
        }
        
        public uint TotalBytes
        {
            get
            {
                return this.m_TotalBytes;
            }
            set
            {
                this.m_TotalBytes = value;
            }
        }
        
        public uint TotalCompressedBytes
        {
            get
            {
                return this.m_TotalCompressedBytes;
            }
            set
            {
                this.m_TotalCompressedBytes = value;
            }
        }
        
        public uint TotalCompressFlushes
        {
            get
            {
                return this.m_TotalCompressFlushes;
            }
            set
            {
                this.m_TotalCompressFlushes = value;
            }
        }
        
        public uint TotalCompressionRatio
        {
            get
            {
                return this.m_TotalCompressionRatio;
            }
            set
            {
                this.m_TotalCompressionRatio = value;
            }
        }
        
        public uint TotalErrors
        {
            get
            {
                return this.m_TotalErrors;
            }
            set
            {
                this.m_TotalErrors = value;
            }
        }
        
        public uint TotalFrames
        {
            get
            {
                return this.m_TotalFrames;
            }
            set
            {
                this.m_TotalFrames = value;
            }
        }
        
        public uint TotalProtocolCacheHitRatio
        {
            get
            {
                return this.m_TotalProtocolCacheHitRatio;
            }
            set
            {
                this.m_TotalProtocolCacheHitRatio = value;
            }
        }
        
        public uint TotalProtocolCacheHits
        {
            get
            {
                return this.m_TotalProtocolCacheHits;
            }
            set
            {
                this.m_TotalProtocolCacheHits = value;
            }
        }
        
        public uint TotalProtocolCacheReads
        {
            get
            {
                return this.m_TotalProtocolCacheReads;
            }
            set
            {
                this.m_TotalProtocolCacheReads = value;
            }
        }
        
        public uint TotalTimeouts
        {
            get
            {
                return this.m_TotalTimeouts;
            }
            set
            {
                this.m_TotalTimeouts = value;
            }
        }
        
        public uint TotalTransportErrors
        {
            get
            {
                return this.m_TotalTransportErrors;
            }
            set
            {
                this.m_TotalTransportErrors = value;
            }
        }
        
        public uint TotalWaitForOutBuf
        {
            get
            {
                return this.m_TotalWaitForOutBuf;
            }
            set
            {
                this.m_TotalWaitForOutBuf = value;
            }
        }
        
        public uint TotalWdBytes
        {
            get
            {
                return this.m_TotalWdBytes;
            }
            set
            {
                this.m_TotalWdBytes = value;
            }
        }
        
        public uint TotalWdFrames
        {
            get
            {
                return this.m_TotalWdFrames;
            }
            set
            {
                this.m_TotalWdFrames = value;
            }
        }
        
        public ulong VirtualBytes
        {
            get
            {
                return this.m_VirtualBytes;
            }
            set
            {
                this.m_VirtualBytes = value;
            }
        }
        
        public ulong VirtualBytesPeak
        {
            get
            {
                return this.m_VirtualBytesPeak;
            }
            set
            {
                this.m_VirtualBytesPeak = value;
            }
        }
        
        public ulong WorkingSet
        {
            get
            {
                return this.m_WorkingSet;
            }
            set
            {
                this.m_WorkingSet = value;
            }
        }
        
        public ulong WorkingSetPeak
        {
            get
            {
                return this.m_WorkingSetPeak;
            }
            set
            {
                this.m_WorkingSetPeak = value;
            }
        }
        
        public string MyPath
        {
            get
            {
                return this.m_MyPath;
            }
            set
            {
                this.m_MyPath = value;
            }
        }
    }
}

using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_RemoteAccess_RASTotal : WMIBase
    {
        
        private uint m_AlignmentErrors;
        
        private uint m_BufferOverrunErrors;
        
        private uint m_BytesReceived;
        
        private uint m_BytesReceivedPerSec;
        
        private uint m_BytesTransmitted;
        
        private uint m_BytesTransmittedPerSec;
        
        private string m_Caption;
        
        private uint m_CRCErrors;
        
        private string m_Description;
        
        private uint m_FramesReceived;
        
        private uint m_FramesReceivedPerSec;
        
        private uint m_FramesTransmitted;
        
        private uint m_FramesTransmittedPerSec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_PercentCompressionIn;
        
        private uint m_PercentCompressionOut;
        
        private uint m_SerialOverrunErrors;
        
        private uint m_TimeoutErrors;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalConnections;
        
        private uint m_TotalErrors;
        
        private uint m_TotalErrorsPerSec;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_RemoteAccess_RASTotal()
        {
        }
        
        public uint AlignmentErrors
        {
            get
            {
                return this.m_AlignmentErrors;
            }
            set
            {
                this.m_AlignmentErrors = value;
            }
        }
        
        public uint BufferOverrunErrors
        {
            get
            {
                return this.m_BufferOverrunErrors;
            }
            set
            {
                this.m_BufferOverrunErrors = value;
            }
        }
        
        public uint BytesReceived
        {
            get
            {
                return this.m_BytesReceived;
            }
            set
            {
                this.m_BytesReceived = value;
            }
        }
        
        public uint BytesReceivedPerSec
        {
            get
            {
                return this.m_BytesReceivedPerSec;
            }
            set
            {
                this.m_BytesReceivedPerSec = value;
            }
        }
        
        public uint BytesTransmitted
        {
            get
            {
                return this.m_BytesTransmitted;
            }
            set
            {
                this.m_BytesTransmitted = value;
            }
        }
        
        public uint BytesTransmittedPerSec
        {
            get
            {
                return this.m_BytesTransmittedPerSec;
            }
            set
            {
                this.m_BytesTransmittedPerSec = value;
            }
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
        
        public uint CRCErrors
        {
            get
            {
                return this.m_CRCErrors;
            }
            set
            {
                this.m_CRCErrors = value;
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
        
        public uint FramesReceived
        {
            get
            {
                return this.m_FramesReceived;
            }
            set
            {
                this.m_FramesReceived = value;
            }
        }
        
        public uint FramesReceivedPerSec
        {
            get
            {
                return this.m_FramesReceivedPerSec;
            }
            set
            {
                this.m_FramesReceivedPerSec = value;
            }
        }
        
        public uint FramesTransmitted
        {
            get
            {
                return this.m_FramesTransmitted;
            }
            set
            {
                this.m_FramesTransmitted = value;
            }
        }
        
        public uint FramesTransmittedPerSec
        {
            get
            {
                return this.m_FramesTransmittedPerSec;
            }
            set
            {
                this.m_FramesTransmittedPerSec = value;
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
        
        public uint PercentCompressionIn
        {
            get
            {
                return this.m_PercentCompressionIn;
            }
            set
            {
                this.m_PercentCompressionIn = value;
            }
        }
        
        public uint PercentCompressionOut
        {
            get
            {
                return this.m_PercentCompressionOut;
            }
            set
            {
                this.m_PercentCompressionOut = value;
            }
        }
        
        public uint SerialOverrunErrors
        {
            get
            {
                return this.m_SerialOverrunErrors;
            }
            set
            {
                this.m_SerialOverrunErrors = value;
            }
        }
        
        public uint TimeoutErrors
        {
            get
            {
                return this.m_TimeoutErrors;
            }
            set
            {
                this.m_TimeoutErrors = value;
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
        
        public uint TotalConnections
        {
            get
            {
                return this.m_TotalConnections;
            }
            set
            {
                this.m_TotalConnections = value;
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
        
        public uint TotalErrorsPerSec
        {
            get
            {
                return this.m_TotalErrorsPerSec;
            }
            set
            {
                this.m_TotalErrorsPerSec = value;
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

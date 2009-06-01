using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Counters_GenericIKEandAuthIP : WMIBase
    {
        
        private uint m_AuthIPMainModeNegotiationTime;
        
        private uint m_AuthIPQuickModeNegotiationTime;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_ExtendedModeNegotiationTime;
        
        private uint m_FailedNegotiations;
        
        private uint m_FailedNegotiationsPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_IKEMainModeNegotiationTime;
        
        private uint m_IKEQuickModeNegotiationTime;
        
        private uint m_InvalidPacketsReceivedPersec;
        
        private string m_Name;
        
        private uint m_PacketsReceivedPersec;
        
        private uint m_SuccessfulNegotiations;
        
        private uint m_SuccessfulNegotiationsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Counters_GenericIKEandAuthIP()
        {
        }
        
        public uint AuthIPMainModeNegotiationTime
        {
            get
            {
                return this.m_AuthIPMainModeNegotiationTime;
            }
            set
            {
                this.m_AuthIPMainModeNegotiationTime = value;
            }
        }
        
        public uint AuthIPQuickModeNegotiationTime
        {
            get
            {
                return this.m_AuthIPQuickModeNegotiationTime;
            }
            set
            {
                this.m_AuthIPQuickModeNegotiationTime = value;
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
        
        public uint ExtendedModeNegotiationTime
        {
            get
            {
                return this.m_ExtendedModeNegotiationTime;
            }
            set
            {
                this.m_ExtendedModeNegotiationTime = value;
            }
        }
        
        public uint FailedNegotiations
        {
            get
            {
                return this.m_FailedNegotiations;
            }
            set
            {
                this.m_FailedNegotiations = value;
            }
        }
        
        public uint FailedNegotiationsPersec
        {
            get
            {
                return this.m_FailedNegotiationsPersec;
            }
            set
            {
                this.m_FailedNegotiationsPersec = value;
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
        
        public uint IKEMainModeNegotiationTime
        {
            get
            {
                return this.m_IKEMainModeNegotiationTime;
            }
            set
            {
                this.m_IKEMainModeNegotiationTime = value;
            }
        }
        
        public uint IKEQuickModeNegotiationTime
        {
            get
            {
                return this.m_IKEQuickModeNegotiationTime;
            }
            set
            {
                this.m_IKEQuickModeNegotiationTime = value;
            }
        }
        
        public uint InvalidPacketsReceivedPersec
        {
            get
            {
                return this.m_InvalidPacketsReceivedPersec;
            }
            set
            {
                this.m_InvalidPacketsReceivedPersec = value;
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
        
        public uint PacketsReceivedPersec
        {
            get
            {
                return this.m_PacketsReceivedPersec;
            }
            set
            {
                this.m_PacketsReceivedPersec = value;
            }
        }
        
        public uint SuccessfulNegotiations
        {
            get
            {
                return this.m_SuccessfulNegotiations;
            }
            set
            {
                this.m_SuccessfulNegotiations = value;
            }
        }
        
        public uint SuccessfulNegotiationsPersec
        {
            get
            {
                return this.m_SuccessfulNegotiationsPersec;
            }
            set
            {
                this.m_SuccessfulNegotiationsPersec = value;
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

using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_Counters_IPsecIKEv6 : WMIBase
    {
        
        private uint m_ActiveMainModeSAs;
        
        private uint m_ActiveQuickModeSAs;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_FailedMainModeNegotiations;
        
        private uint m_FailedMainModeNegotiationsPersec;
        
        private uint m_FailedQuickModeNegotiations;
        
        private uint m_FailedQuickModeNegotiationsPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_MainModeNegotiationRequestsReceived;
        
        private uint m_MainModeNegotiationRequestsReceivedPersec;
        
        private uint m_MainModeNegotiations;
        
        private uint m_MainModeNegotiationsPersec;
        
        private string m_Name;
        
        private uint m_PendingMainModeNegotiations;
        
        private uint m_PendingQuickModeNegotiations;
        
        private uint m_QuickModeNegotiations;
        
        private uint m_QuickModeNegotiationsPersec;
        
        private uint m_SuccessfulMainModeNegotiations;
        
        private uint m_SuccessfulMainModeNegotiationsPersec;
        
        private uint m_SuccessfulQuickModeNegotiations;
        
        private uint m_SuccessfulQuickModeNegotiationsPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_Counters_IPsecIKEv6()
        {
        }
        
        public uint ActiveMainModeSAs
        {
            get
            {
                return this.m_ActiveMainModeSAs;
            }
            set
            {
                this.m_ActiveMainModeSAs = value;
            }
        }
        
        public uint ActiveQuickModeSAs
        {
            get
            {
                return this.m_ActiveQuickModeSAs;
            }
            set
            {
                this.m_ActiveQuickModeSAs = value;
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
        
        public uint FailedMainModeNegotiations
        {
            get
            {
                return this.m_FailedMainModeNegotiations;
            }
            set
            {
                this.m_FailedMainModeNegotiations = value;
            }
        }
        
        public uint FailedMainModeNegotiationsPersec
        {
            get
            {
                return this.m_FailedMainModeNegotiationsPersec;
            }
            set
            {
                this.m_FailedMainModeNegotiationsPersec = value;
            }
        }
        
        public uint FailedQuickModeNegotiations
        {
            get
            {
                return this.m_FailedQuickModeNegotiations;
            }
            set
            {
                this.m_FailedQuickModeNegotiations = value;
            }
        }
        
        public uint FailedQuickModeNegotiationsPersec
        {
            get
            {
                return this.m_FailedQuickModeNegotiationsPersec;
            }
            set
            {
                this.m_FailedQuickModeNegotiationsPersec = value;
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
        
        public uint MainModeNegotiationRequestsReceived
        {
            get
            {
                return this.m_MainModeNegotiationRequestsReceived;
            }
            set
            {
                this.m_MainModeNegotiationRequestsReceived = value;
            }
        }
        
        public uint MainModeNegotiationRequestsReceivedPersec
        {
            get
            {
                return this.m_MainModeNegotiationRequestsReceivedPersec;
            }
            set
            {
                this.m_MainModeNegotiationRequestsReceivedPersec = value;
            }
        }
        
        public uint MainModeNegotiations
        {
            get
            {
                return this.m_MainModeNegotiations;
            }
            set
            {
                this.m_MainModeNegotiations = value;
            }
        }
        
        public uint MainModeNegotiationsPersec
        {
            get
            {
                return this.m_MainModeNegotiationsPersec;
            }
            set
            {
                this.m_MainModeNegotiationsPersec = value;
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
        
        public uint PendingMainModeNegotiations
        {
            get
            {
                return this.m_PendingMainModeNegotiations;
            }
            set
            {
                this.m_PendingMainModeNegotiations = value;
            }
        }
        
        public uint PendingQuickModeNegotiations
        {
            get
            {
                return this.m_PendingQuickModeNegotiations;
            }
            set
            {
                this.m_PendingQuickModeNegotiations = value;
            }
        }
        
        public uint QuickModeNegotiations
        {
            get
            {
                return this.m_QuickModeNegotiations;
            }
            set
            {
                this.m_QuickModeNegotiations = value;
            }
        }
        
        public uint QuickModeNegotiationsPersec
        {
            get
            {
                return this.m_QuickModeNegotiationsPersec;
            }
            set
            {
                this.m_QuickModeNegotiationsPersec = value;
            }
        }
        
        public uint SuccessfulMainModeNegotiations
        {
            get
            {
                return this.m_SuccessfulMainModeNegotiations;
            }
            set
            {
                this.m_SuccessfulMainModeNegotiations = value;
            }
        }
        
        public uint SuccessfulMainModeNegotiationsPersec
        {
            get
            {
                return this.m_SuccessfulMainModeNegotiationsPersec;
            }
            set
            {
                this.m_SuccessfulMainModeNegotiationsPersec = value;
            }
        }
        
        public uint SuccessfulQuickModeNegotiations
        {
            get
            {
                return this.m_SuccessfulQuickModeNegotiations;
            }
            set
            {
                this.m_SuccessfulQuickModeNegotiations = value;
            }
        }
        
        public uint SuccessfulQuickModeNegotiationsPersec
        {
            get
            {
                return this.m_SuccessfulQuickModeNegotiationsPersec;
            }
            set
            {
                this.m_SuccessfulQuickModeNegotiationsPersec = value;
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

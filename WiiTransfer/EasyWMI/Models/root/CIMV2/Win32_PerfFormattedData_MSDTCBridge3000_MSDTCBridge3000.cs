using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_MSDTCBridge3000_MSDTCBridge3000 : WMIBase
    {
        
        private uint m_Averageparticipantcommitresponsetime;
        
        private uint m_Averageparticipantprepareresponsetime;
        
        private string m_Caption;
        
        private uint m_CommitretrycountPersec;
        
        private string m_Description;
        
        private uint m_FaultsreceivedcountPersec;
        
        private uint m_FaultssentcountPersec;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_MessagesendfailuresPersec;
        
        private string m_Name;
        
        private uint m_PreparedretrycountPersec;
        
        private uint m_PrepareretrycountPersec;
        
        private uint m_ReplayretrycountPersec;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_MSDTCBridge3000_MSDTCBridge3000()
        {
        }
        
        public uint Averageparticipantcommitresponsetime
        {
            get
            {
                return this.m_Averageparticipantcommitresponsetime;
            }
            set
            {
                this.m_Averageparticipantcommitresponsetime = value;
            }
        }
        
        public uint Averageparticipantprepareresponsetime
        {
            get
            {
                return this.m_Averageparticipantprepareresponsetime;
            }
            set
            {
                this.m_Averageparticipantprepareresponsetime = value;
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
        
        public uint CommitretrycountPersec
        {
            get
            {
                return this.m_CommitretrycountPersec;
            }
            set
            {
                this.m_CommitretrycountPersec = value;
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
        
        public uint FaultsreceivedcountPersec
        {
            get
            {
                return this.m_FaultsreceivedcountPersec;
            }
            set
            {
                this.m_FaultsreceivedcountPersec = value;
            }
        }
        
        public uint FaultssentcountPersec
        {
            get
            {
                return this.m_FaultssentcountPersec;
            }
            set
            {
                this.m_FaultssentcountPersec = value;
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
        
        public uint MessagesendfailuresPersec
        {
            get
            {
                return this.m_MessagesendfailuresPersec;
            }
            set
            {
                this.m_MessagesendfailuresPersec = value;
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
        
        public uint PreparedretrycountPersec
        {
            get
            {
                return this.m_PreparedretrycountPersec;
            }
            set
            {
                this.m_PreparedretrycountPersec = value;
            }
        }
        
        public uint PrepareretrycountPersec
        {
            get
            {
                return this.m_PrepareretrycountPersec;
            }
            set
            {
                this.m_PrepareretrycountPersec = value;
            }
        }
        
        public uint ReplayretrycountPersec
        {
            get
            {
                return this.m_ReplayretrycountPersec;
            }
            set
            {
                this.m_ReplayretrycountPersec = value;
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

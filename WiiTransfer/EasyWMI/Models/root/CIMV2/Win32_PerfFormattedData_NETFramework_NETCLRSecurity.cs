using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_NETFramework_NETCLRSecurity : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_NumberLinkTimeChecks;
        
        private uint m_PercentTimeinRTchecks;
        
        private ulong m_PercentTimeSigAuthenticating;
        
        private uint m_StackWalkDepth;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalRuntimeChecks;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_NETFramework_NETCLRSecurity()
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
        
        public uint NumberLinkTimeChecks
        {
            get
            {
                return this.m_NumberLinkTimeChecks;
            }
            set
            {
                this.m_NumberLinkTimeChecks = value;
            }
        }
        
        public uint PercentTimeinRTchecks
        {
            get
            {
                return this.m_PercentTimeinRTchecks;
            }
            set
            {
                this.m_PercentTimeinRTchecks = value;
            }
        }
        
        public ulong PercentTimeSigAuthenticating
        {
            get
            {
                return this.m_PercentTimeSigAuthenticating;
            }
            set
            {
                this.m_PercentTimeSigAuthenticating = value;
            }
        }
        
        public uint StackWalkDepth
        {
            get
            {
                return this.m_StackWalkDepth;
            }
            set
            {
                this.m_StackWalkDepth = value;
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
        
        public uint TotalRuntimeChecks
        {
            get
            {
                return this.m_TotalRuntimeChecks;
            }
            set
            {
                this.m_TotalRuntimeChecks = value;
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

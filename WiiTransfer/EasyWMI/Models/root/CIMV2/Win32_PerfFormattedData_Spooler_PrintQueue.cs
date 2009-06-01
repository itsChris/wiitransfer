using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_Spooler_PrintQueue : WMIBase
    {
        
        private uint m_AddNetworkPrinterCalls;
        
        private ulong m_BytesPrintedPersec;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_EnumerateNetworkPrinterCalls;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_JobErrors;
        
        private uint m_Jobs;
        
        private uint m_JobsSpooling;
        
        private uint m_MaxJobsSpooling;
        
        private uint m_MaxReferences;
        
        private string m_Name;
        
        private uint m_NotReadyErrors;
        
        private uint m_OutofPaperErrors;
        
        private uint m_References;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalJobsPrinted;
        
        private uint m_TotalPagesPrinted;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_Spooler_PrintQueue()
        {
        }
        
        public uint AddNetworkPrinterCalls
        {
            get
            {
                return this.m_AddNetworkPrinterCalls;
            }
            set
            {
                this.m_AddNetworkPrinterCalls = value;
            }
        }
        
        public ulong BytesPrintedPersec
        {
            get
            {
                return this.m_BytesPrintedPersec;
            }
            set
            {
                this.m_BytesPrintedPersec = value;
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
        
        public uint EnumerateNetworkPrinterCalls
        {
            get
            {
                return this.m_EnumerateNetworkPrinterCalls;
            }
            set
            {
                this.m_EnumerateNetworkPrinterCalls = value;
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
        
        public uint JobErrors
        {
            get
            {
                return this.m_JobErrors;
            }
            set
            {
                this.m_JobErrors = value;
            }
        }
        
        public uint Jobs
        {
            get
            {
                return this.m_Jobs;
            }
            set
            {
                this.m_Jobs = value;
            }
        }
        
        public uint JobsSpooling
        {
            get
            {
                return this.m_JobsSpooling;
            }
            set
            {
                this.m_JobsSpooling = value;
            }
        }
        
        public uint MaxJobsSpooling
        {
            get
            {
                return this.m_MaxJobsSpooling;
            }
            set
            {
                this.m_MaxJobsSpooling = value;
            }
        }
        
        public uint MaxReferences
        {
            get
            {
                return this.m_MaxReferences;
            }
            set
            {
                this.m_MaxReferences = value;
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
        
        public uint NotReadyErrors
        {
            get
            {
                return this.m_NotReadyErrors;
            }
            set
            {
                this.m_NotReadyErrors = value;
            }
        }
        
        public uint OutofPaperErrors
        {
            get
            {
                return this.m_OutofPaperErrors;
            }
            set
            {
                this.m_OutofPaperErrors = value;
            }
        }
        
        public uint References
        {
            get
            {
                return this.m_References;
            }
            set
            {
                this.m_References = value;
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
        
        public uint TotalJobsPrinted
        {
            get
            {
                return this.m_TotalJobsPrinted;
            }
            set
            {
                this.m_TotalJobsPrinted = value;
            }
        }
        
        public uint TotalPagesPrinted
        {
            get
            {
                return this.m_TotalPagesPrinted;
            }
            set
            {
                this.m_TotalPagesPrinted = value;
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

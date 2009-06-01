using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_NETFramework_NETCLRLoading : WMIBase
    {
        
        private uint m_AssemblySearchLength;
        
        private ulong m_BytesinLoaderHeap;
        
        private string m_Caption;
        
        private uint m_Currentappdomains;
        
        private uint m_CurrentAssemblies;
        
        private uint m_CurrentClassesLoaded;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private ulong m_PercentTimeLoading;
        
        private uint m_Rateofappdomains;
        
        private uint m_Rateofappdomainsunloaded;
        
        private uint m_RateofAssemblies;
        
        private uint m_RateofClassesLoaded;
        
        private uint m_RateofLoadFailures;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_TotalAppdomains;
        
        private uint m_Totalappdomainsunloaded;
        
        private uint m_TotalAssemblies;
        
        private uint m_TotalClassesLoaded;
        
        private uint m_TotalNumberofLoadFailures;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_NETFramework_NETCLRLoading()
        {
        }
        
        public uint AssemblySearchLength
        {
            get
            {
                return this.m_AssemblySearchLength;
            }
            set
            {
                this.m_AssemblySearchLength = value;
            }
        }
        
        public ulong BytesinLoaderHeap
        {
            get
            {
                return this.m_BytesinLoaderHeap;
            }
            set
            {
                this.m_BytesinLoaderHeap = value;
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
        
        public uint Currentappdomains
        {
            get
            {
                return this.m_Currentappdomains;
            }
            set
            {
                this.m_Currentappdomains = value;
            }
        }
        
        public uint CurrentAssemblies
        {
            get
            {
                return this.m_CurrentAssemblies;
            }
            set
            {
                this.m_CurrentAssemblies = value;
            }
        }
        
        public uint CurrentClassesLoaded
        {
            get
            {
                return this.m_CurrentClassesLoaded;
            }
            set
            {
                this.m_CurrentClassesLoaded = value;
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
        
        public ulong PercentTimeLoading
        {
            get
            {
                return this.m_PercentTimeLoading;
            }
            set
            {
                this.m_PercentTimeLoading = value;
            }
        }
        
        public uint Rateofappdomains
        {
            get
            {
                return this.m_Rateofappdomains;
            }
            set
            {
                this.m_Rateofappdomains = value;
            }
        }
        
        public uint Rateofappdomainsunloaded
        {
            get
            {
                return this.m_Rateofappdomainsunloaded;
            }
            set
            {
                this.m_Rateofappdomainsunloaded = value;
            }
        }
        
        public uint RateofAssemblies
        {
            get
            {
                return this.m_RateofAssemblies;
            }
            set
            {
                this.m_RateofAssemblies = value;
            }
        }
        
        public uint RateofClassesLoaded
        {
            get
            {
                return this.m_RateofClassesLoaded;
            }
            set
            {
                this.m_RateofClassesLoaded = value;
            }
        }
        
        public uint RateofLoadFailures
        {
            get
            {
                return this.m_RateofLoadFailures;
            }
            set
            {
                this.m_RateofLoadFailures = value;
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
        
        public uint TotalAppdomains
        {
            get
            {
                return this.m_TotalAppdomains;
            }
            set
            {
                this.m_TotalAppdomains = value;
            }
        }
        
        public uint Totalappdomainsunloaded
        {
            get
            {
                return this.m_Totalappdomainsunloaded;
            }
            set
            {
                this.m_Totalappdomainsunloaded = value;
            }
        }
        
        public uint TotalAssemblies
        {
            get
            {
                return this.m_TotalAssemblies;
            }
            set
            {
                this.m_TotalAssemblies = value;
            }
        }
        
        public uint TotalClassesLoaded
        {
            get
            {
                return this.m_TotalClassesLoaded;
            }
            set
            {
                this.m_TotalClassesLoaded = value;
            }
        }
        
        public uint TotalNumberofLoadFailures
        {
            get
            {
                return this.m_TotalNumberofLoadFailures;
            }
            set
            {
                this.m_TotalNumberofLoadFailures = value;
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

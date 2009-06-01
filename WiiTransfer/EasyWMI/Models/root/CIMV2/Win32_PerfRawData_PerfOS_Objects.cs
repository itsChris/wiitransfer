using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfRawData_PerfOS_Objects : WMIBase
    {
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_Events;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_Mutexes;
        
        private string m_Name;
        
        private uint m_Processes;
        
        private uint m_Sections;
        
        private uint m_Semaphores;
        
        private uint m_Threads;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfRawData_PerfOS_Objects()
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
        
        public uint Events
        {
            get
            {
                return this.m_Events;
            }
            set
            {
                this.m_Events = value;
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
        
        public uint Mutexes
        {
            get
            {
                return this.m_Mutexes;
            }
            set
            {
                this.m_Mutexes = value;
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
        
        public uint Processes
        {
            get
            {
                return this.m_Processes;
            }
            set
            {
                this.m_Processes = value;
            }
        }
        
        public uint Sections
        {
            get
            {
                return this.m_Sections;
            }
            set
            {
                this.m_Sections = value;
            }
        }
        
        public uint Semaphores
        {
            get
            {
                return this.m_Semaphores;
            }
            set
            {
                this.m_Semaphores = value;
            }
        }
        
        public uint Threads
        {
            get
            {
                return this.m_Threads;
            }
            set
            {
                this.m_Threads = value;
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

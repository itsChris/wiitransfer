using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObjectLimitSetting : WMIBase
    {
        
        private uint m_ActiveProcessLimit;
        
        private uint m_Affinity;
        
        private string m_Caption;
        
        private string m_Description;
        
        private uint m_JobMemoryLimit;
        
        private uint m_LimitFlags;
        
        private uint m_MaximumWorkingSetSize;
        
        private uint m_MinimumWorkingSetSize;
        
        private ulong m_PerJobUserTimeLimit;
        
        private ulong m_PerProcessUserTimeLimit;
        
        private uint m_PriorityClass;
        
        private uint m_ProcessMemoryLimit;
        
        private uint m_SchedulingClass;
        
        private string m_SettingID;
        
        private string m_MyPath;
        
        public Win32_NamedJobObjectLimitSetting()
        {
        }
        
        public uint ActiveProcessLimit
        {
            get
            {
                return this.m_ActiveProcessLimit;
            }
            set
            {
                this.m_ActiveProcessLimit = value;
            }
        }
        
        public uint Affinity
        {
            get
            {
                return this.m_Affinity;
            }
            set
            {
                this.m_Affinity = value;
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
        
        public uint JobMemoryLimit
        {
            get
            {
                return this.m_JobMemoryLimit;
            }
            set
            {
                this.m_JobMemoryLimit = value;
            }
        }
        
        public uint LimitFlags
        {
            get
            {
                return this.m_LimitFlags;
            }
            set
            {
                this.m_LimitFlags = value;
            }
        }
        
        public uint MaximumWorkingSetSize
        {
            get
            {
                return this.m_MaximumWorkingSetSize;
            }
            set
            {
                this.m_MaximumWorkingSetSize = value;
            }
        }
        
        public uint MinimumWorkingSetSize
        {
            get
            {
                return this.m_MinimumWorkingSetSize;
            }
            set
            {
                this.m_MinimumWorkingSetSize = value;
            }
        }
        
        public ulong PerJobUserTimeLimit
        {
            get
            {
                return this.m_PerJobUserTimeLimit;
            }
            set
            {
                this.m_PerJobUserTimeLimit = value;
            }
        }
        
        public ulong PerProcessUserTimeLimit
        {
            get
            {
                return this.m_PerProcessUserTimeLimit;
            }
            set
            {
                this.m_PerProcessUserTimeLimit = value;
            }
        }
        
        public uint PriorityClass
        {
            get
            {
                return this.m_PriorityClass;
            }
            set
            {
                this.m_PriorityClass = value;
            }
        }
        
        public uint ProcessMemoryLimit
        {
            get
            {
                return this.m_ProcessMemoryLimit;
            }
            set
            {
                this.m_ProcessMemoryLimit = value;
            }
        }
        
        public uint SchedulingClass
        {
            get
            {
                return this.m_SchedulingClass;
            }
            set
            {
                this.m_SchedulingClass = value;
            }
        }
        
        public string SettingID
        {
            get
            {
                return this.m_SettingID;
            }
            set
            {
                this.m_SettingID = value;
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

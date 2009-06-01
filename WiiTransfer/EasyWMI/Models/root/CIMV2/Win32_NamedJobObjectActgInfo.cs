using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObjectActgInfo : WMIBase
    {
        
        private uint m_ActiveProcesses;
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_Name;
        
        private ulong m_OtherOperationCount;
        
        private ulong m_OtherTransferCount;
        
        private uint m_PeakJobMemoryUsed;
        
        private uint m_PeakProcessMemoryUsed;
        
        private ulong m_ReadOperationCount;
        
        private ulong m_ReadTransferCount;
        
        private ulong m_ThisPeriodTotalKernelTime;
        
        private ulong m_ThisPeriodTotalUserTime;
        
        private ulong m_TotalKernelTime;
        
        private uint m_TotalPageFaultCount;
        
        private uint m_TotalProcesses;
        
        private uint m_TotalTerminatedProcesses;
        
        private ulong m_TotalUserTime;
        
        private ulong m_WriteOperationCount;
        
        private ulong m_WriteTransferCount;
        
        private string m_MyPath;
        
        public Win32_NamedJobObjectActgInfo()
        {
        }
        
        public uint ActiveProcesses
        {
            get
            {
                return this.m_ActiveProcesses;
            }
            set
            {
                this.m_ActiveProcesses = value;
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
        
        public ulong OtherOperationCount
        {
            get
            {
                return this.m_OtherOperationCount;
            }
            set
            {
                this.m_OtherOperationCount = value;
            }
        }
        
        public ulong OtherTransferCount
        {
            get
            {
                return this.m_OtherTransferCount;
            }
            set
            {
                this.m_OtherTransferCount = value;
            }
        }
        
        public uint PeakJobMemoryUsed
        {
            get
            {
                return this.m_PeakJobMemoryUsed;
            }
            set
            {
                this.m_PeakJobMemoryUsed = value;
            }
        }
        
        public uint PeakProcessMemoryUsed
        {
            get
            {
                return this.m_PeakProcessMemoryUsed;
            }
            set
            {
                this.m_PeakProcessMemoryUsed = value;
            }
        }
        
        public ulong ReadOperationCount
        {
            get
            {
                return this.m_ReadOperationCount;
            }
            set
            {
                this.m_ReadOperationCount = value;
            }
        }
        
        public ulong ReadTransferCount
        {
            get
            {
                return this.m_ReadTransferCount;
            }
            set
            {
                this.m_ReadTransferCount = value;
            }
        }
        
        public ulong ThisPeriodTotalKernelTime
        {
            get
            {
                return this.m_ThisPeriodTotalKernelTime;
            }
            set
            {
                this.m_ThisPeriodTotalKernelTime = value;
            }
        }
        
        public ulong ThisPeriodTotalUserTime
        {
            get
            {
                return this.m_ThisPeriodTotalUserTime;
            }
            set
            {
                this.m_ThisPeriodTotalUserTime = value;
            }
        }
        
        public ulong TotalKernelTime
        {
            get
            {
                return this.m_TotalKernelTime;
            }
            set
            {
                this.m_TotalKernelTime = value;
            }
        }
        
        public uint TotalPageFaultCount
        {
            get
            {
                return this.m_TotalPageFaultCount;
            }
            set
            {
                this.m_TotalPageFaultCount = value;
            }
        }
        
        public uint TotalProcesses
        {
            get
            {
                return this.m_TotalProcesses;
            }
            set
            {
                this.m_TotalProcesses = value;
            }
        }
        
        public uint TotalTerminatedProcesses
        {
            get
            {
                return this.m_TotalTerminatedProcesses;
            }
            set
            {
                this.m_TotalTerminatedProcesses = value;
            }
        }
        
        public ulong TotalUserTime
        {
            get
            {
                return this.m_TotalUserTime;
            }
            set
            {
                this.m_TotalUserTime = value;
            }
        }
        
        public ulong WriteOperationCount
        {
            get
            {
                return this.m_WriteOperationCount;
            }
            set
            {
                this.m_WriteOperationCount = value;
            }
        }
        
        public ulong WriteTransferCount
        {
            get
            {
                return this.m_WriteTransferCount;
            }
            set
            {
                this.m_WriteTransferCount = value;
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

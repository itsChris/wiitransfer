using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PageFileUsage : WMIBase
    {
        
        private uint m_AllocatedBaseSize;
        
        private string m_Caption;
        
        private uint m_CurrentUsage;
        
        private string m_Description;
        
        private string m_InstallDate;
        
        private string m_Name;
        
        private uint m_PeakUsage;
        
        private string m_Status;
        
        private bool m_TempPageFile;
        
        private string m_MyPath;
        
        public Win32_PageFileUsage()
        {
        }
        
        public uint AllocatedBaseSize
        {
            get
            {
                return this.m_AllocatedBaseSize;
            }
            set
            {
                this.m_AllocatedBaseSize = value;
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
        
        public uint CurrentUsage
        {
            get
            {
                return this.m_CurrentUsage;
            }
            set
            {
                this.m_CurrentUsage = value;
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
        
        public string InstallDate
        {
            get
            {
                return this.m_InstallDate;
            }
            set
            {
                this.m_InstallDate = value;
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
        
        public uint PeakUsage
        {
            get
            {
                return this.m_PeakUsage;
            }
            set
            {
                this.m_PeakUsage = value;
            }
        }
        
        public string Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }
        
        public bool TempPageFile
        {
            get
            {
                return this.m_TempPageFile;
            }
            set
            {
                this.m_TempPageFile = value;
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

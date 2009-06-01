using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_IRQResource : WMIBase
    {
        
        private ushort m_Availability;
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private string m_CSCreationClassName;
        
        private string m_CSName;
        
        private string m_Description;
        
        private bool m_Hardware;
        
        private string m_InstallDate;
        
        private uint m_IRQNumber;
        
        private string m_Name;
        
        private bool m_Shareable;
        
        private string m_Status;
        
        private ushort m_TriggerLevel;
        
        private ushort m_TriggerType;
        
        private uint m_Vector;
        
        private string m_MyPath;
        
        public Win32_IRQResource()
        {
        }
        
        public ushort Availability
        {
            get
            {
                return this.m_Availability;
            }
            set
            {
                this.m_Availability = value;
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
        
        public string CreationClassName
        {
            get
            {
                return this.m_CreationClassName;
            }
            set
            {
                this.m_CreationClassName = value;
            }
        }
        
        public string CSCreationClassName
        {
            get
            {
                return this.m_CSCreationClassName;
            }
            set
            {
                this.m_CSCreationClassName = value;
            }
        }
        
        public string CSName
        {
            get
            {
                return this.m_CSName;
            }
            set
            {
                this.m_CSName = value;
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
        
        public bool Hardware
        {
            get
            {
                return this.m_Hardware;
            }
            set
            {
                this.m_Hardware = value;
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
        
        public uint IRQNumber
        {
            get
            {
                return this.m_IRQNumber;
            }
            set
            {
                this.m_IRQNumber = value;
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
        
        public bool Shareable
        {
            get
            {
                return this.m_Shareable;
            }
            set
            {
                this.m_Shareable = value;
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
        
        public ushort TriggerLevel
        {
            get
            {
                return this.m_TriggerLevel;
            }
            set
            {
                this.m_TriggerLevel = value;
            }
        }
        
        public ushort TriggerType
        {
            get
            {
                return this.m_TriggerType;
            }
            set
            {
                this.m_TriggerType = value;
            }
        }
        
        public uint Vector
        {
            get
            {
                return this.m_Vector;
            }
            set
            {
                this.m_Vector = value;
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

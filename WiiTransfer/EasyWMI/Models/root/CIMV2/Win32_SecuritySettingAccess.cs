using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SecuritySettingAccess : WMIBase
    {
        
        private uint m_AccessMask;
        
        private string m_GuidInheritedObjectType;
        
        private string m_GuidObjectType;
        
        private uint m_Inheritance;
        
        private string m_SecuritySetting;
        
        private string m_Trustee;
        
        private uint m_Type;
        
        private string m_MyPath;
        
        public Win32_SecuritySettingAccess()
        {
        }
        
        public uint AccessMask
        {
            get
            {
                return this.m_AccessMask;
            }
            set
            {
                this.m_AccessMask = value;
            }
        }
        
        public string GuidInheritedObjectType
        {
            get
            {
                return this.m_GuidInheritedObjectType;
            }
            set
            {
                this.m_GuidInheritedObjectType = value;
            }
        }
        
        public string GuidObjectType
        {
            get
            {
                return this.m_GuidObjectType;
            }
            set
            {
                this.m_GuidObjectType = value;
            }
        }
        
        public uint Inheritance
        {
            get
            {
                return this.m_Inheritance;
            }
            set
            {
                this.m_Inheritance = value;
            }
        }
        
        public string SecuritySetting
        {
            get
            {
                return this.m_SecuritySetting;
            }
            set
            {
                this.m_SecuritySetting = value;
            }
        }
        
        public string Trustee
        {
            get
            {
                return this.m_Trustee;
            }
            set
            {
                this.m_Trustee = value;
            }
        }
        
        public uint Type
        {
            get
            {
                return this.m_Type;
            }
            set
            {
                this.m_Type = value;
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

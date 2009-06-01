using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NamedJobObject : WMIBase
    {
        
        private uint m_BasicUIRestrictions;
        
        private string m_Caption;
        
        private string m_CollectionID;
        
        private string m_Description;
        
        private string m_MyPath;
        
        public Win32_NamedJobObject()
        {
        }
        
        public uint BasicUIRestrictions
        {
            get
            {
                return this.m_BasicUIRestrictions;
            }
            set
            {
                this.m_BasicUIRestrictions = value;
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
        
        public string CollectionID
        {
            get
            {
                return this.m_CollectionID;
            }
            set
            {
                this.m_CollectionID = value;
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

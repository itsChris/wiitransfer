using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_LogicalShareSecuritySetting : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_ControlFlags;
        
        private string m_Description;
        
        private string m_Name;
        
        private string m_SettingID;
        
        private string m_MyPath;
        
        public Win32_LogicalShareSecuritySetting()
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
        
        public uint ControlFlags
        {
            get
            {
                return this.m_ControlFlags;
            }
            set
            {
                this.m_ControlFlags = value;
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
        
        public Int32 GetSecurityDescriptor(out object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetSecurityDescriptor", InParams, Options);
Descriptor = (Object)OutParams["Descriptor"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetSecurityDescriptor(object Descriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_LogicalShareSecuritySetting");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetSecurityDescriptor");
InParams["Descriptor"] = Descriptor;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetSecurityDescriptor", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}

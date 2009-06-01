using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Share : WMIBase
    {
        
        private uint m_AccessMask;
        
        private bool m_AllowMaximum;
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_InstallDate;
        
        private uint m_MaximumAllowed;
        
        private string m_Name;
        
        private string m_Path;
        
        private string m_Status;
        
        private uint m_Type;
        
        private string m_MyPath;
        
        public Win32_Share()
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
        
        public bool AllowMaximum
        {
            get
            {
                return this.m_AllowMaximum;
            }
            set
            {
                this.m_AllowMaximum = value;
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
        
        public uint MaximumAllowed
        {
            get
            {
                return this.m_MaximumAllowed;
            }
            set
            {
                this.m_MaximumAllowed = value;
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
        
        public string Path
        {
            get
            {
                return this.m_Path;
            }
            set
            {
                this.m_Path = value;
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
        
        public Int32 Create(object Access, string Description, uint MaximumAllowed, string Name, string Password, string Path, uint Type)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Share");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Create");
InParams["Access"] = Access;
InParams["Description"] = Description;
InParams["MaximumAllowed"] = MaximumAllowed;
InParams["Name"] = Name;
InParams["Password"] = Password;
InParams["Path"] = Path;
InParams["Type"] = Type;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Create", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetShareInfo(object Access, string Description, uint MaximumAllowed)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Share");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetShareInfo");
InParams["Access"] = Access;
InParams["Description"] = Description;
InParams["MaximumAllowed"] = MaximumAllowed;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetShareInfo", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetAccessMask()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetAccessMask", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Delete()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Delete", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}

using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ClassicCOMClassSetting : WMIBase
    {
        
        private string m_AppID;
        
        private string m_AutoConvertToClsid;
        
        private string m_AutoTreatAsClsid;
        
        private string m_Caption;
        
        private string m_ComponentId;
        
        private bool m_Control;
        
        private string m_DefaultIcon;
        
        private string m_Description;
        
        private string m_InprocHandler;
        
        private string m_InprocHandler32;
        
        private string m_InprocServer;
        
        private string m_InprocServer32;
        
        private bool m_Insertable;
        
        private bool m_JavaClass;
        
        private string m_LocalServer;
        
        private string m_LocalServer32;
        
        private string m_LongDisplayName;
        
        private string m_ProgId;
        
        private string m_SettingID;
        
        private string m_ShortDisplayName;
        
        private string m_ThreadingModel;
        
        private string m_ToolBoxBitmap32;
        
        private string m_TreatAsClsid;
        
        private string m_TypeLibraryId;
        
        private string m_Version;
        
        private string m_VersionIndependentProgId;
        
        private string m_MyPath;
        
        public Win32_ClassicCOMClassSetting()
        {
        }
        
        public string AppID
        {
            get
            {
                return this.m_AppID;
            }
            set
            {
                this.m_AppID = value;
            }
        }
        
        public string AutoConvertToClsid
        {
            get
            {
                return this.m_AutoConvertToClsid;
            }
            set
            {
                this.m_AutoConvertToClsid = value;
            }
        }
        
        public string AutoTreatAsClsid
        {
            get
            {
                return this.m_AutoTreatAsClsid;
            }
            set
            {
                this.m_AutoTreatAsClsid = value;
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
        
        public string ComponentId
        {
            get
            {
                return this.m_ComponentId;
            }
            set
            {
                this.m_ComponentId = value;
            }
        }
        
        public bool Control
        {
            get
            {
                return this.m_Control;
            }
            set
            {
                this.m_Control = value;
            }
        }
        
        public string DefaultIcon
        {
            get
            {
                return this.m_DefaultIcon;
            }
            set
            {
                this.m_DefaultIcon = value;
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
        
        public string InprocHandler
        {
            get
            {
                return this.m_InprocHandler;
            }
            set
            {
                this.m_InprocHandler = value;
            }
        }
        
        public string InprocHandler32
        {
            get
            {
                return this.m_InprocHandler32;
            }
            set
            {
                this.m_InprocHandler32 = value;
            }
        }
        
        public string InprocServer
        {
            get
            {
                return this.m_InprocServer;
            }
            set
            {
                this.m_InprocServer = value;
            }
        }
        
        public string InprocServer32
        {
            get
            {
                return this.m_InprocServer32;
            }
            set
            {
                this.m_InprocServer32 = value;
            }
        }
        
        public bool Insertable
        {
            get
            {
                return this.m_Insertable;
            }
            set
            {
                this.m_Insertable = value;
            }
        }
        
        public bool JavaClass
        {
            get
            {
                return this.m_JavaClass;
            }
            set
            {
                this.m_JavaClass = value;
            }
        }
        
        public string LocalServer
        {
            get
            {
                return this.m_LocalServer;
            }
            set
            {
                this.m_LocalServer = value;
            }
        }
        
        public string LocalServer32
        {
            get
            {
                return this.m_LocalServer32;
            }
            set
            {
                this.m_LocalServer32 = value;
            }
        }
        
        public string LongDisplayName
        {
            get
            {
                return this.m_LongDisplayName;
            }
            set
            {
                this.m_LongDisplayName = value;
            }
        }
        
        public string ProgId
        {
            get
            {
                return this.m_ProgId;
            }
            set
            {
                this.m_ProgId = value;
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
        
        public string ShortDisplayName
        {
            get
            {
                return this.m_ShortDisplayName;
            }
            set
            {
                this.m_ShortDisplayName = value;
            }
        }
        
        public string ThreadingModel
        {
            get
            {
                return this.m_ThreadingModel;
            }
            set
            {
                this.m_ThreadingModel = value;
            }
        }
        
        public string ToolBoxBitmap32
        {
            get
            {
                return this.m_ToolBoxBitmap32;
            }
            set
            {
                this.m_ToolBoxBitmap32 = value;
            }
        }
        
        public string TreatAsClsid
        {
            get
            {
                return this.m_TreatAsClsid;
            }
            set
            {
                this.m_TreatAsClsid = value;
            }
        }
        
        public string TypeLibraryId
        {
            get
            {
                return this.m_TypeLibraryId;
            }
            set
            {
                this.m_TypeLibraryId = value;
            }
        }
        
        public string Version
        {
            get
            {
                return this.m_Version;
            }
            set
            {
                this.m_Version = value;
            }
        }
        
        public string VersionIndependentProgId
        {
            get
            {
                return this.m_VersionIndependentProgId;
            }
            set
            {
                this.m_VersionIndependentProgId = value;
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

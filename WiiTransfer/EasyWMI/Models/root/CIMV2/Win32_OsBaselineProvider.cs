using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_OsBaselineProvider : WMIBase
    {
        
        private string m_ClientLoadableCLSID;
        
        private string m_CLSID;
        
        private int m_Concurrency;
        
        private string m_DefaultMachineName;
        
        private bool m_Enabled;
        
        private string m_HostingModel;
        
        private int m_ImpersonationLevel;
        
        private int m_InitializationReentrancy;
        
        private string m_InitializationTimeoutInterval;
        
        private bool m_InitializeAsAdminFirst;
        
        private string m_Name;
        
        private string m_OperationTimeoutInterval;
        
        private bool m_PerLocaleInitialization;
        
        private bool m_PerUserInitialization;
        
        private bool m_Pure;
        
        private string m_SecurityDescriptor;
        
        private bool m_SupportsExplicitShutdown;
        
        private bool m_SupportsExtendedStatus;
        
        private bool m_SupportsQuotas;
        
        private bool m_SupportsSendStatus;
        
        private bool m_SupportsShutdown;
        
        private bool m_SupportsThrottling;
        
        private string m_UnloadTimeout;
        
        private uint m_Version;
        
        private string m_MyPath;
        
        public Win32_OsBaselineProvider()
        {
        }
        
        public string ClientLoadableCLSID
        {
            get
            {
                return this.m_ClientLoadableCLSID;
            }
            set
            {
                this.m_ClientLoadableCLSID = value;
            }
        }
        
        public string CLSID
        {
            get
            {
                return this.m_CLSID;
            }
            set
            {
                this.m_CLSID = value;
            }
        }
        
        public int Concurrency
        {
            get
            {
                return this.m_Concurrency;
            }
            set
            {
                this.m_Concurrency = value;
            }
        }
        
        public string DefaultMachineName
        {
            get
            {
                return this.m_DefaultMachineName;
            }
            set
            {
                this.m_DefaultMachineName = value;
            }
        }
        
        public bool Enabled
        {
            get
            {
                return this.m_Enabled;
            }
            set
            {
                this.m_Enabled = value;
            }
        }
        
        public string HostingModel
        {
            get
            {
                return this.m_HostingModel;
            }
            set
            {
                this.m_HostingModel = value;
            }
        }
        
        public int ImpersonationLevel
        {
            get
            {
                return this.m_ImpersonationLevel;
            }
            set
            {
                this.m_ImpersonationLevel = value;
            }
        }
        
        public int InitializationReentrancy
        {
            get
            {
                return this.m_InitializationReentrancy;
            }
            set
            {
                this.m_InitializationReentrancy = value;
            }
        }
        
        public string InitializationTimeoutInterval
        {
            get
            {
                return this.m_InitializationTimeoutInterval;
            }
            set
            {
                this.m_InitializationTimeoutInterval = value;
            }
        }
        
        public bool InitializeAsAdminFirst
        {
            get
            {
                return this.m_InitializeAsAdminFirst;
            }
            set
            {
                this.m_InitializeAsAdminFirst = value;
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
        
        public string OperationTimeoutInterval
        {
            get
            {
                return this.m_OperationTimeoutInterval;
            }
            set
            {
                this.m_OperationTimeoutInterval = value;
            }
        }
        
        public bool PerLocaleInitialization
        {
            get
            {
                return this.m_PerLocaleInitialization;
            }
            set
            {
                this.m_PerLocaleInitialization = value;
            }
        }
        
        public bool PerUserInitialization
        {
            get
            {
                return this.m_PerUserInitialization;
            }
            set
            {
                this.m_PerUserInitialization = value;
            }
        }
        
        public bool Pure
        {
            get
            {
                return this.m_Pure;
            }
            set
            {
                this.m_Pure = value;
            }
        }
        
        public string SecurityDescriptor
        {
            get
            {
                return this.m_SecurityDescriptor;
            }
            set
            {
                this.m_SecurityDescriptor = value;
            }
        }
        
        public bool SupportsExplicitShutdown
        {
            get
            {
                return this.m_SupportsExplicitShutdown;
            }
            set
            {
                this.m_SupportsExplicitShutdown = value;
            }
        }
        
        public bool SupportsExtendedStatus
        {
            get
            {
                return this.m_SupportsExtendedStatus;
            }
            set
            {
                this.m_SupportsExtendedStatus = value;
            }
        }
        
        public bool SupportsQuotas
        {
            get
            {
                return this.m_SupportsQuotas;
            }
            set
            {
                this.m_SupportsQuotas = value;
            }
        }
        
        public bool SupportsSendStatus
        {
            get
            {
                return this.m_SupportsSendStatus;
            }
            set
            {
                this.m_SupportsSendStatus = value;
            }
        }
        
        public bool SupportsShutdown
        {
            get
            {
                return this.m_SupportsShutdown;
            }
            set
            {
                this.m_SupportsShutdown = value;
            }
        }
        
        public bool SupportsThrottling
        {
            get
            {
                return this.m_SupportsThrottling;
            }
            set
            {
                this.m_SupportsThrottling = value;
            }
        }
        
        public string UnloadTimeout
        {
            get
            {
                return this.m_UnloadTimeout;
            }
            set
            {
                this.m_UnloadTimeout = value;
            }
        }
        
        public uint Version
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

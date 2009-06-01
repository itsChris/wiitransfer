using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000 : WMIBase
    {
        
        private string m_Caption;
        
        private uint m_ConnectionsAcceptedovernetpipe;
        
        private uint m_ConnectionsAcceptedovernettcp;
        
        private uint m_ConnectionsDispatchedovernetpipe;
        
        private uint m_ConnectionsDispatchedovernettcp;
        
        private string m_Description;
        
        private uint m_DispatchFailuresovernetpipe;
        
        private uint m_DispatchFailuresovernettcp;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private string m_Name;
        
        private uint m_ProtocolFailuresovernetpipe;
        
        private uint m_ProtocolFailuresovernettcp;
        
        private uint m_RegistrationsActivefornetpipe;
        
        private uint m_RegistrationsActivefornettcp;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private uint m_UrisRegisteredfornetpipe;
        
        private uint m_UrisRegisteredfornettcp;
        
        private uint m_UrisUnregisteredfornetpipe;
        
        private uint m_UrisUnregisteredfornettcp;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000()
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
        
        public uint ConnectionsAcceptedovernetpipe
        {
            get
            {
                return this.m_ConnectionsAcceptedovernetpipe;
            }
            set
            {
                this.m_ConnectionsAcceptedovernetpipe = value;
            }
        }
        
        public uint ConnectionsAcceptedovernettcp
        {
            get
            {
                return this.m_ConnectionsAcceptedovernettcp;
            }
            set
            {
                this.m_ConnectionsAcceptedovernettcp = value;
            }
        }
        
        public uint ConnectionsDispatchedovernetpipe
        {
            get
            {
                return this.m_ConnectionsDispatchedovernetpipe;
            }
            set
            {
                this.m_ConnectionsDispatchedovernetpipe = value;
            }
        }
        
        public uint ConnectionsDispatchedovernettcp
        {
            get
            {
                return this.m_ConnectionsDispatchedovernettcp;
            }
            set
            {
                this.m_ConnectionsDispatchedovernettcp = value;
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
        
        public uint DispatchFailuresovernetpipe
        {
            get
            {
                return this.m_DispatchFailuresovernetpipe;
            }
            set
            {
                this.m_DispatchFailuresovernetpipe = value;
            }
        }
        
        public uint DispatchFailuresovernettcp
        {
            get
            {
                return this.m_DispatchFailuresovernettcp;
            }
            set
            {
                this.m_DispatchFailuresovernettcp = value;
            }
        }
        
        public ulong Frequency_Object
        {
            get
            {
                return this.m_Frequency_Object;
            }
            set
            {
                this.m_Frequency_Object = value;
            }
        }
        
        public ulong Frequency_PerfTime
        {
            get
            {
                return this.m_Frequency_PerfTime;
            }
            set
            {
                this.m_Frequency_PerfTime = value;
            }
        }
        
        public ulong Frequency_Sys100NS
        {
            get
            {
                return this.m_Frequency_Sys100NS;
            }
            set
            {
                this.m_Frequency_Sys100NS = value;
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
        
        public uint ProtocolFailuresovernetpipe
        {
            get
            {
                return this.m_ProtocolFailuresovernetpipe;
            }
            set
            {
                this.m_ProtocolFailuresovernetpipe = value;
            }
        }
        
        public uint ProtocolFailuresovernettcp
        {
            get
            {
                return this.m_ProtocolFailuresovernettcp;
            }
            set
            {
                this.m_ProtocolFailuresovernettcp = value;
            }
        }
        
        public uint RegistrationsActivefornetpipe
        {
            get
            {
                return this.m_RegistrationsActivefornetpipe;
            }
            set
            {
                this.m_RegistrationsActivefornetpipe = value;
            }
        }
        
        public uint RegistrationsActivefornettcp
        {
            get
            {
                return this.m_RegistrationsActivefornettcp;
            }
            set
            {
                this.m_RegistrationsActivefornettcp = value;
            }
        }
        
        public ulong Timestamp_Object
        {
            get
            {
                return this.m_Timestamp_Object;
            }
            set
            {
                this.m_Timestamp_Object = value;
            }
        }
        
        public ulong Timestamp_PerfTime
        {
            get
            {
                return this.m_Timestamp_PerfTime;
            }
            set
            {
                this.m_Timestamp_PerfTime = value;
            }
        }
        
        public ulong Timestamp_Sys100NS
        {
            get
            {
                return this.m_Timestamp_Sys100NS;
            }
            set
            {
                this.m_Timestamp_Sys100NS = value;
            }
        }
        
        public uint UrisRegisteredfornetpipe
        {
            get
            {
                return this.m_UrisRegisteredfornetpipe;
            }
            set
            {
                this.m_UrisRegisteredfornetpipe = value;
            }
        }
        
        public uint UrisRegisteredfornettcp
        {
            get
            {
                return this.m_UrisRegisteredfornettcp;
            }
            set
            {
                this.m_UrisRegisteredfornettcp = value;
            }
        }
        
        public uint UrisUnregisteredfornetpipe
        {
            get
            {
                return this.m_UrisUnregisteredfornetpipe;
            }
            set
            {
                this.m_UrisUnregisteredfornetpipe = value;
            }
        }
        
        public uint UrisUnregisteredfornettcp
        {
            get
            {
                return this.m_UrisUnregisteredfornettcp;
            }
            set
            {
                this.m_UrisUnregisteredfornettcp = value;
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

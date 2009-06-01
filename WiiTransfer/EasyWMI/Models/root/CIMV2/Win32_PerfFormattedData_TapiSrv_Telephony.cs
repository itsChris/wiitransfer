using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_TapiSrv_Telephony : WMIBase
    {
        
        private uint m_ActiveLines;
        
        private uint m_ActiveTelephones;
        
        private string m_Caption;
        
        private uint m_ClientApps;
        
        private uint m_CurrentIncomingCalls;
        
        private uint m_CurrentOutgoingCalls;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private uint m_IncomingCallsPersec;
        
        private uint m_Lines;
        
        private string m_Name;
        
        private uint m_OutgoingCallsPersec;
        
        private uint m_TelephoneDevices;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_TapiSrv_Telephony()
        {
        }
        
        public uint ActiveLines
        {
            get
            {
                return this.m_ActiveLines;
            }
            set
            {
                this.m_ActiveLines = value;
            }
        }
        
        public uint ActiveTelephones
        {
            get
            {
                return this.m_ActiveTelephones;
            }
            set
            {
                this.m_ActiveTelephones = value;
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
        
        public uint ClientApps
        {
            get
            {
                return this.m_ClientApps;
            }
            set
            {
                this.m_ClientApps = value;
            }
        }
        
        public uint CurrentIncomingCalls
        {
            get
            {
                return this.m_CurrentIncomingCalls;
            }
            set
            {
                this.m_CurrentIncomingCalls = value;
            }
        }
        
        public uint CurrentOutgoingCalls
        {
            get
            {
                return this.m_CurrentOutgoingCalls;
            }
            set
            {
                this.m_CurrentOutgoingCalls = value;
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
        
        public uint IncomingCallsPersec
        {
            get
            {
                return this.m_IncomingCallsPersec;
            }
            set
            {
                this.m_IncomingCallsPersec = value;
            }
        }
        
        public uint Lines
        {
            get
            {
                return this.m_Lines;
            }
            set
            {
                this.m_Lines = value;
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
        
        public uint OutgoingCallsPersec
        {
            get
            {
                return this.m_OutgoingCallsPersec;
            }
            set
            {
                this.m_OutgoingCallsPersec = value;
            }
        }
        
        public uint TelephoneDevices
        {
            get
            {
                return this.m_TelephoneDevices;
            }
            set
            {
                this.m_TelephoneDevices = value;
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

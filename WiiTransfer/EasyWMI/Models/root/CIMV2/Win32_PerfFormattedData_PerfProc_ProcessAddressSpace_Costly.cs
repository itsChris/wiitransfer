using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly : WMIBase
    {
        
        private ulong m_BytesFree;
        
        private ulong m_BytesImageFree;
        
        private ulong m_BytesImageReserved;
        
        private ulong m_BytesReserved;
        
        private string m_Caption;
        
        private string m_Description;
        
        private ulong m_Frequency_Object;
        
        private ulong m_Frequency_PerfTime;
        
        private ulong m_Frequency_Sys100NS;
        
        private ulong m_IDProcess;
        
        private ulong m_ImageSpaceExecReadOnly;
        
        private ulong m_ImageSpaceExecReadPerWrite;
        
        private ulong m_ImageSpaceExecutable;
        
        private ulong m_ImageSpaceExecWriteCopy;
        
        private ulong m_ImageSpaceNoAccess;
        
        private ulong m_ImageSpaceReadOnly;
        
        private ulong m_ImageSpaceReadPerWrite;
        
        private ulong m_ImageSpaceWriteCopy;
        
        private ulong m_MappedSpaceExecReadOnly;
        
        private ulong m_MappedSpaceExecReadPerWrite;
        
        private ulong m_MappedSpaceExecutable;
        
        private ulong m_MappedSpaceExecWriteCopy;
        
        private ulong m_MappedSpaceNoAccess;
        
        private ulong m_MappedSpaceReadOnly;
        
        private ulong m_MappedSpaceReadPerWrite;
        
        private ulong m_MappedSpaceWriteCopy;
        
        private string m_Name;
        
        private ulong m_ReservedSpaceExecReadOnly;
        
        private ulong m_ReservedSpaceExecReadPerWrite;
        
        private ulong m_ReservedSpaceExecutable;
        
        private ulong m_ReservedSpaceExecWriteCopy;
        
        private ulong m_ReservedSpaceNoAccess;
        
        private ulong m_ReservedSpaceReadOnly;
        
        private ulong m_ReservedSpaceReadPerWrite;
        
        private ulong m_ReservedSpaceWriteCopy;
        
        private ulong m_Timestamp_Object;
        
        private ulong m_Timestamp_PerfTime;
        
        private ulong m_Timestamp_Sys100NS;
        
        private ulong m_UnassignedSpaceExecReadOnly;
        
        private ulong m_UnassignedSpaceExecReadPerWrite;
        
        private ulong m_UnassignedSpaceExecutable;
        
        private ulong m_UnassignedSpaceExecWriteCopy;
        
        private ulong m_UnassignedSpaceNoAccess;
        
        private ulong m_UnassignedSpaceReadOnly;
        
        private ulong m_UnassignedSpaceReadPerWrite;
        
        private ulong m_UnassignedSpaceWriteCopy;
        
        private string m_MyPath;
        
        public Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly()
        {
        }
        
        public ulong BytesFree
        {
            get
            {
                return this.m_BytesFree;
            }
            set
            {
                this.m_BytesFree = value;
            }
        }
        
        public ulong BytesImageFree
        {
            get
            {
                return this.m_BytesImageFree;
            }
            set
            {
                this.m_BytesImageFree = value;
            }
        }
        
        public ulong BytesImageReserved
        {
            get
            {
                return this.m_BytesImageReserved;
            }
            set
            {
                this.m_BytesImageReserved = value;
            }
        }
        
        public ulong BytesReserved
        {
            get
            {
                return this.m_BytesReserved;
            }
            set
            {
                this.m_BytesReserved = value;
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
        
        public ulong IDProcess
        {
            get
            {
                return this.m_IDProcess;
            }
            set
            {
                this.m_IDProcess = value;
            }
        }
        
        public ulong ImageSpaceExecReadOnly
        {
            get
            {
                return this.m_ImageSpaceExecReadOnly;
            }
            set
            {
                this.m_ImageSpaceExecReadOnly = value;
            }
        }
        
        public ulong ImageSpaceExecReadPerWrite
        {
            get
            {
                return this.m_ImageSpaceExecReadPerWrite;
            }
            set
            {
                this.m_ImageSpaceExecReadPerWrite = value;
            }
        }
        
        public ulong ImageSpaceExecutable
        {
            get
            {
                return this.m_ImageSpaceExecutable;
            }
            set
            {
                this.m_ImageSpaceExecutable = value;
            }
        }
        
        public ulong ImageSpaceExecWriteCopy
        {
            get
            {
                return this.m_ImageSpaceExecWriteCopy;
            }
            set
            {
                this.m_ImageSpaceExecWriteCopy = value;
            }
        }
        
        public ulong ImageSpaceNoAccess
        {
            get
            {
                return this.m_ImageSpaceNoAccess;
            }
            set
            {
                this.m_ImageSpaceNoAccess = value;
            }
        }
        
        public ulong ImageSpaceReadOnly
        {
            get
            {
                return this.m_ImageSpaceReadOnly;
            }
            set
            {
                this.m_ImageSpaceReadOnly = value;
            }
        }
        
        public ulong ImageSpaceReadPerWrite
        {
            get
            {
                return this.m_ImageSpaceReadPerWrite;
            }
            set
            {
                this.m_ImageSpaceReadPerWrite = value;
            }
        }
        
        public ulong ImageSpaceWriteCopy
        {
            get
            {
                return this.m_ImageSpaceWriteCopy;
            }
            set
            {
                this.m_ImageSpaceWriteCopy = value;
            }
        }
        
        public ulong MappedSpaceExecReadOnly
        {
            get
            {
                return this.m_MappedSpaceExecReadOnly;
            }
            set
            {
                this.m_MappedSpaceExecReadOnly = value;
            }
        }
        
        public ulong MappedSpaceExecReadPerWrite
        {
            get
            {
                return this.m_MappedSpaceExecReadPerWrite;
            }
            set
            {
                this.m_MappedSpaceExecReadPerWrite = value;
            }
        }
        
        public ulong MappedSpaceExecutable
        {
            get
            {
                return this.m_MappedSpaceExecutable;
            }
            set
            {
                this.m_MappedSpaceExecutable = value;
            }
        }
        
        public ulong MappedSpaceExecWriteCopy
        {
            get
            {
                return this.m_MappedSpaceExecWriteCopy;
            }
            set
            {
                this.m_MappedSpaceExecWriteCopy = value;
            }
        }
        
        public ulong MappedSpaceNoAccess
        {
            get
            {
                return this.m_MappedSpaceNoAccess;
            }
            set
            {
                this.m_MappedSpaceNoAccess = value;
            }
        }
        
        public ulong MappedSpaceReadOnly
        {
            get
            {
                return this.m_MappedSpaceReadOnly;
            }
            set
            {
                this.m_MappedSpaceReadOnly = value;
            }
        }
        
        public ulong MappedSpaceReadPerWrite
        {
            get
            {
                return this.m_MappedSpaceReadPerWrite;
            }
            set
            {
                this.m_MappedSpaceReadPerWrite = value;
            }
        }
        
        public ulong MappedSpaceWriteCopy
        {
            get
            {
                return this.m_MappedSpaceWriteCopy;
            }
            set
            {
                this.m_MappedSpaceWriteCopy = value;
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
        
        public ulong ReservedSpaceExecReadOnly
        {
            get
            {
                return this.m_ReservedSpaceExecReadOnly;
            }
            set
            {
                this.m_ReservedSpaceExecReadOnly = value;
            }
        }
        
        public ulong ReservedSpaceExecReadPerWrite
        {
            get
            {
                return this.m_ReservedSpaceExecReadPerWrite;
            }
            set
            {
                this.m_ReservedSpaceExecReadPerWrite = value;
            }
        }
        
        public ulong ReservedSpaceExecutable
        {
            get
            {
                return this.m_ReservedSpaceExecutable;
            }
            set
            {
                this.m_ReservedSpaceExecutable = value;
            }
        }
        
        public ulong ReservedSpaceExecWriteCopy
        {
            get
            {
                return this.m_ReservedSpaceExecWriteCopy;
            }
            set
            {
                this.m_ReservedSpaceExecWriteCopy = value;
            }
        }
        
        public ulong ReservedSpaceNoAccess
        {
            get
            {
                return this.m_ReservedSpaceNoAccess;
            }
            set
            {
                this.m_ReservedSpaceNoAccess = value;
            }
        }
        
        public ulong ReservedSpaceReadOnly
        {
            get
            {
                return this.m_ReservedSpaceReadOnly;
            }
            set
            {
                this.m_ReservedSpaceReadOnly = value;
            }
        }
        
        public ulong ReservedSpaceReadPerWrite
        {
            get
            {
                return this.m_ReservedSpaceReadPerWrite;
            }
            set
            {
                this.m_ReservedSpaceReadPerWrite = value;
            }
        }
        
        public ulong ReservedSpaceWriteCopy
        {
            get
            {
                return this.m_ReservedSpaceWriteCopy;
            }
            set
            {
                this.m_ReservedSpaceWriteCopy = value;
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
        
        public ulong UnassignedSpaceExecReadOnly
        {
            get
            {
                return this.m_UnassignedSpaceExecReadOnly;
            }
            set
            {
                this.m_UnassignedSpaceExecReadOnly = value;
            }
        }
        
        public ulong UnassignedSpaceExecReadPerWrite
        {
            get
            {
                return this.m_UnassignedSpaceExecReadPerWrite;
            }
            set
            {
                this.m_UnassignedSpaceExecReadPerWrite = value;
            }
        }
        
        public ulong UnassignedSpaceExecutable
        {
            get
            {
                return this.m_UnassignedSpaceExecutable;
            }
            set
            {
                this.m_UnassignedSpaceExecutable = value;
            }
        }
        
        public ulong UnassignedSpaceExecWriteCopy
        {
            get
            {
                return this.m_UnassignedSpaceExecWriteCopy;
            }
            set
            {
                this.m_UnassignedSpaceExecWriteCopy = value;
            }
        }
        
        public ulong UnassignedSpaceNoAccess
        {
            get
            {
                return this.m_UnassignedSpaceNoAccess;
            }
            set
            {
                this.m_UnassignedSpaceNoAccess = value;
            }
        }
        
        public ulong UnassignedSpaceReadOnly
        {
            get
            {
                return this.m_UnassignedSpaceReadOnly;
            }
            set
            {
                this.m_UnassignedSpaceReadOnly = value;
            }
        }
        
        public ulong UnassignedSpaceReadPerWrite
        {
            get
            {
                return this.m_UnassignedSpaceReadPerWrite;
            }
            set
            {
                this.m_UnassignedSpaceReadPerWrite = value;
            }
        }
        
        public ulong UnassignedSpaceWriteCopy
        {
            get
            {
                return this.m_UnassignedSpaceWriteCopy;
            }
            set
            {
                this.m_UnassignedSpaceWriteCopy = value;
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

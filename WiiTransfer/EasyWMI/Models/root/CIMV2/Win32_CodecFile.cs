using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_CodecFile : WMIBase
    {
        
        private uint m_AccessMask;
        
        private bool m_Archive;
        
        private string m_Caption;
        
        private bool m_Compressed;
        
        private string m_CompressionMethod;
        
        private string m_CreationClassName;
        
        private string m_CreationDate;
        
        private string m_CSCreationClassName;
        
        private string m_CSName;
        
        private string m_Description;
        
        private string m_Drive;
        
        private string m_EightDotThreeFileName;
        
        private bool m_Encrypted;
        
        private string m_EncryptionMethod;
        
        private string m_Extension;
        
        private string m_FileName;
        
        private ulong m_FileSize;
        
        private string m_FileType;
        
        private string m_FSCreationClassName;
        
        private string m_FSName;
        
        private string m_Group;
        
        private bool m_Hidden;
        
        private string m_InstallDate;
        
        private ulong m_InUseCount;
        
        private string m_LastAccessed;
        
        private string m_LastModified;
        
        private string m_Manufacturer;
        
        private string m_Name;
        
        private string m_Path;
        
        private bool m_Readable;
        
        private string m_Status;
        
        private bool m_System;
        
        private string m_Version;
        
        private bool m_Writeable;
        
        private string m_MyPath;
        
        public Win32_CodecFile()
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
        
        public bool Archive
        {
            get
            {
                return this.m_Archive;
            }
            set
            {
                this.m_Archive = value;
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
        
        public bool Compressed
        {
            get
            {
                return this.m_Compressed;
            }
            set
            {
                this.m_Compressed = value;
            }
        }
        
        public string CompressionMethod
        {
            get
            {
                return this.m_CompressionMethod;
            }
            set
            {
                this.m_CompressionMethod = value;
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
        
        public string CreationDate
        {
            get
            {
                return this.m_CreationDate;
            }
            set
            {
                this.m_CreationDate = value;
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
        
        public string Drive
        {
            get
            {
                return this.m_Drive;
            }
            set
            {
                this.m_Drive = value;
            }
        }
        
        public string EightDotThreeFileName
        {
            get
            {
                return this.m_EightDotThreeFileName;
            }
            set
            {
                this.m_EightDotThreeFileName = value;
            }
        }
        
        public bool Encrypted
        {
            get
            {
                return this.m_Encrypted;
            }
            set
            {
                this.m_Encrypted = value;
            }
        }
        
        public string EncryptionMethod
        {
            get
            {
                return this.m_EncryptionMethod;
            }
            set
            {
                this.m_EncryptionMethod = value;
            }
        }
        
        public string Extension
        {
            get
            {
                return this.m_Extension;
            }
            set
            {
                this.m_Extension = value;
            }
        }
        
        public string FileName
        {
            get
            {
                return this.m_FileName;
            }
            set
            {
                this.m_FileName = value;
            }
        }
        
        public ulong FileSize
        {
            get
            {
                return this.m_FileSize;
            }
            set
            {
                this.m_FileSize = value;
            }
        }
        
        public string FileType
        {
            get
            {
                return this.m_FileType;
            }
            set
            {
                this.m_FileType = value;
            }
        }
        
        public string FSCreationClassName
        {
            get
            {
                return this.m_FSCreationClassName;
            }
            set
            {
                this.m_FSCreationClassName = value;
            }
        }
        
        public string FSName
        {
            get
            {
                return this.m_FSName;
            }
            set
            {
                this.m_FSName = value;
            }
        }
        
        public string Group
        {
            get
            {
                return this.m_Group;
            }
            set
            {
                this.m_Group = value;
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this.m_Hidden;
            }
            set
            {
                this.m_Hidden = value;
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
        
        public ulong InUseCount
        {
            get
            {
                return this.m_InUseCount;
            }
            set
            {
                this.m_InUseCount = value;
            }
        }
        
        public string LastAccessed
        {
            get
            {
                return this.m_LastAccessed;
            }
            set
            {
                this.m_LastAccessed = value;
            }
        }
        
        public string LastModified
        {
            get
            {
                return this.m_LastModified;
            }
            set
            {
                this.m_LastModified = value;
            }
        }
        
        public string Manufacturer
        {
            get
            {
                return this.m_Manufacturer;
            }
            set
            {
                this.m_Manufacturer = value;
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
        
        public bool Readable
        {
            get
            {
                return this.m_Readable;
            }
            set
            {
                this.m_Readable = value;
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
        
        public bool System
        {
            get
            {
                return this.m_System;
            }
            set
            {
                this.m_System = value;
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
        
        public bool Writeable
        {
            get
            {
                return this.m_Writeable;
            }
            set
            {
                this.m_Writeable = value;
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
        
        public Int32 TakeOwnerShip()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "TakeOwnerShip", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ChangeSecurityPermissions(uint Option, object SecurityDescriptor)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("ChangeSecurityPermissions");
InParams["Option"] = Option;
InParams["SecurityDescriptor"] = SecurityDescriptor;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ChangeSecurityPermissions", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Copy(string FileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Copy");
InParams["FileName"] = FileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Copy", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Rename(string FileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("Rename");
InParams["FileName"] = FileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Rename", InParams, Options);

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
        
        public Int32 Compress()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Compress", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Uncompress()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Uncompress", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 TakeOwnerShipEx(bool Recursive, string StartFileName, out string StopFileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("TakeOwnerShipEx");
InParams["Recursive"] = Recursive;
InParams["StartFileName"] = StartFileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "TakeOwnerShipEx", InParams, Options);
StopFileName = (String)OutParams["StopFileName"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ChangeSecurityPermissionsEx(uint Option, bool Recursive, object SecurityDescriptor, string StartFileName, out string StopFileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("ChangeSecurityPermissionsEx");
InParams["Option"] = Option;
InParams["Recursive"] = Recursive;
InParams["SecurityDescriptor"] = SecurityDescriptor;
InParams["StartFileName"] = StartFileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ChangeSecurityPermissionsEx", InParams, Options);
StopFileName = (String)OutParams["StopFileName"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 CopyEx(string FileName, bool Recursive, string StartFileName, out string StopFileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("CopyEx");
InParams["FileName"] = FileName;
InParams["Recursive"] = Recursive;
InParams["StartFileName"] = StartFileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "CopyEx", InParams, Options);
StopFileName = (String)OutParams["StopFileName"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 DeleteEx(string StartFileName, out string StopFileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("DeleteEx");
InParams["StartFileName"] = StartFileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "DeleteEx", InParams, Options);
StopFileName = (String)OutParams["StopFileName"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 CompressEx(bool Recursive, string StartFileName, out string StopFileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("CompressEx");
InParams["Recursive"] = Recursive;
InParams["StartFileName"] = StartFileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "CompressEx", InParams, Options);
StopFileName = (String)OutParams["StopFileName"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 UncompressEx(bool Recursive, string StartFileName, out string StopFileName)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("UncompressEx");
InParams["Recursive"] = Recursive;
InParams["StartFileName"] = StartFileName;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "UncompressEx", InParams, Options);
StopFileName = (String)OutParams["StopFileName"];

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 GetEffectivePermission(uint Permissions)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_CodecFile");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("GetEffectivePermission");
InParams["Permissions"] = Permissions;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "GetEffectivePermission", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}

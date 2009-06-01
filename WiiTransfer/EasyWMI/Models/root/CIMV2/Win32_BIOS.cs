using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_BIOS : WMIBase
    {
        
        private ushort [] m_BiosCharacteristics;
        
        private string [] m_BIOSVersion;
        
        private string m_BuildNumber;
        
        private string m_Caption;
        
        private string m_CodeSet;
        
        private string m_CurrentLanguage;
        
        private string m_Description;
        
        private string m_IdentificationCode;
        
        private ushort m_InstallableLanguages;
        
        private string m_InstallDate;
        
        private string m_LanguageEdition;
        
        private string [] m_ListOfLanguages;
        
        private string m_Manufacturer;
        
        private string m_Name;
        
        private string m_OtherTargetOS;
        
        private bool m_PrimaryBIOS;
        
        private string m_ReleaseDate;
        
        private string m_SerialNumber;
        
        private string m_SMBIOSBIOSVersion;
        
        private ushort m_SMBIOSMajorVersion;
        
        private ushort m_SMBIOSMinorVersion;
        
        private bool m_SMBIOSPresent;
        
        private string m_SoftwareElementID;
        
        private ushort m_SoftwareElementState;
        
        private string m_Status;
        
        private ushort m_TargetOperatingSystem;
        
        private string m_Version;
        
        private string m_MyPath;
        
        public Win32_BIOS()
        {
        }
        
        public ushort [] BiosCharacteristics
        {
            get
            {
                return this.m_BiosCharacteristics;
            }
            set
            {
                this.m_BiosCharacteristics = value;
            }
        }
        
        public string [] BIOSVersion
        {
            get
            {
                return this.m_BIOSVersion;
            }
            set
            {
                this.m_BIOSVersion = value;
            }
        }
        
        public string BuildNumber
        {
            get
            {
                return this.m_BuildNumber;
            }
            set
            {
                this.m_BuildNumber = value;
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
        
        public string CodeSet
        {
            get
            {
                return this.m_CodeSet;
            }
            set
            {
                this.m_CodeSet = value;
            }
        }
        
        public string CurrentLanguage
        {
            get
            {
                return this.m_CurrentLanguage;
            }
            set
            {
                this.m_CurrentLanguage = value;
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
        
        public string IdentificationCode
        {
            get
            {
                return this.m_IdentificationCode;
            }
            set
            {
                this.m_IdentificationCode = value;
            }
        }
        
        public ushort InstallableLanguages
        {
            get
            {
                return this.m_InstallableLanguages;
            }
            set
            {
                this.m_InstallableLanguages = value;
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
        
        public string LanguageEdition
        {
            get
            {
                return this.m_LanguageEdition;
            }
            set
            {
                this.m_LanguageEdition = value;
            }
        }
        
        public string [] ListOfLanguages
        {
            get
            {
                return this.m_ListOfLanguages;
            }
            set
            {
                this.m_ListOfLanguages = value;
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
        
        public string OtherTargetOS
        {
            get
            {
                return this.m_OtherTargetOS;
            }
            set
            {
                this.m_OtherTargetOS = value;
            }
        }
        
        public bool PrimaryBIOS
        {
            get
            {
                return this.m_PrimaryBIOS;
            }
            set
            {
                this.m_PrimaryBIOS = value;
            }
        }
        
        public string ReleaseDate
        {
            get
            {
                return this.m_ReleaseDate;
            }
            set
            {
                this.m_ReleaseDate = value;
            }
        }
        
        public string SerialNumber
        {
            get
            {
                return this.m_SerialNumber;
            }
            set
            {
                this.m_SerialNumber = value;
            }
        }
        
        public string SMBIOSBIOSVersion
        {
            get
            {
                return this.m_SMBIOSBIOSVersion;
            }
            set
            {
                this.m_SMBIOSBIOSVersion = value;
            }
        }
        
        public ushort SMBIOSMajorVersion
        {
            get
            {
                return this.m_SMBIOSMajorVersion;
            }
            set
            {
                this.m_SMBIOSMajorVersion = value;
            }
        }
        
        public ushort SMBIOSMinorVersion
        {
            get
            {
                return this.m_SMBIOSMinorVersion;
            }
            set
            {
                this.m_SMBIOSMinorVersion = value;
            }
        }
        
        public bool SMBIOSPresent
        {
            get
            {
                return this.m_SMBIOSPresent;
            }
            set
            {
                this.m_SMBIOSPresent = value;
            }
        }
        
        public string SoftwareElementID
        {
            get
            {
                return this.m_SoftwareElementID;
            }
            set
            {
                this.m_SoftwareElementID = value;
            }
        }
        
        public ushort SoftwareElementState
        {
            get
            {
                return this.m_SoftwareElementState;
            }
            set
            {
                this.m_SoftwareElementState = value;
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
        
        public ushort TargetOperatingSystem
        {
            get
            {
                return this.m_TargetOperatingSystem;
            }
            set
            {
                this.m_TargetOperatingSystem = value;
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

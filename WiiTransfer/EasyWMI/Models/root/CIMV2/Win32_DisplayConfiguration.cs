using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DisplayConfiguration : WMIBase
    {
        
        private uint m_BitsPerPel;
        
        private string m_Caption;
        
        private string m_Description;
        
        private string m_DeviceName;
        
        private uint m_DisplayFlags;
        
        private uint m_DisplayFrequency;
        
        private uint m_DitherType;
        
        private string m_DriverVersion;
        
        private uint m_ICMIntent;
        
        private uint m_ICMMethod;
        
        private uint m_LogPixels;
        
        private uint m_PelsHeight;
        
        private uint m_PelsWidth;
        
        private string m_SettingID;
        
        private uint m_SpecificationVersion;
        
        private string m_MyPath;
        
        public Win32_DisplayConfiguration()
        {
        }
        
        public uint BitsPerPel
        {
            get
            {
                return this.m_BitsPerPel;
            }
            set
            {
                this.m_BitsPerPel = value;
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
        
        public string DeviceName
        {
            get
            {
                return this.m_DeviceName;
            }
            set
            {
                this.m_DeviceName = value;
            }
        }
        
        public uint DisplayFlags
        {
            get
            {
                return this.m_DisplayFlags;
            }
            set
            {
                this.m_DisplayFlags = value;
            }
        }
        
        public uint DisplayFrequency
        {
            get
            {
                return this.m_DisplayFrequency;
            }
            set
            {
                this.m_DisplayFrequency = value;
            }
        }
        
        public uint DitherType
        {
            get
            {
                return this.m_DitherType;
            }
            set
            {
                this.m_DitherType = value;
            }
        }
        
        public string DriverVersion
        {
            get
            {
                return this.m_DriverVersion;
            }
            set
            {
                this.m_DriverVersion = value;
            }
        }
        
        public uint ICMIntent
        {
            get
            {
                return this.m_ICMIntent;
            }
            set
            {
                this.m_ICMIntent = value;
            }
        }
        
        public uint ICMMethod
        {
            get
            {
                return this.m_ICMMethod;
            }
            set
            {
                this.m_ICMMethod = value;
            }
        }
        
        public uint LogPixels
        {
            get
            {
                return this.m_LogPixels;
            }
            set
            {
                this.m_LogPixels = value;
            }
        }
        
        public uint PelsHeight
        {
            get
            {
                return this.m_PelsHeight;
            }
            set
            {
                this.m_PelsHeight = value;
            }
        }
        
        public uint PelsWidth
        {
            get
            {
                return this.m_PelsWidth;
            }
            set
            {
                this.m_PelsWidth = value;
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
        
        public uint SpecificationVersion
        {
            get
            {
                return this.m_SpecificationVersion;
            }
            set
            {
                this.m_SpecificationVersion = value;
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

using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PrinterConfiguration : WMIBase
    {
        
        private uint m_BitsPerPel;
        
        private string m_Caption;
        
        private bool m_Collate;
        
        private uint m_Color;
        
        private uint m_Copies;
        
        private string m_Description;
        
        private string m_DeviceName;
        
        private uint m_DisplayFlags;
        
        private uint m_DisplayFrequency;
        
        private uint m_DitherType;
        
        private uint m_DriverVersion;
        
        private bool m_Duplex;
        
        private string m_FormName;
        
        private uint m_HorizontalResolution;
        
        private uint m_ICMIntent;
        
        private uint m_ICMMethod;
        
        private uint m_LogPixels;
        
        private uint m_MediaType;
        
        private string m_Name;
        
        private uint m_Orientation;
        
        private uint m_PaperLength;
        
        private string m_PaperSize;
        
        private uint m_PaperWidth;
        
        private uint m_PelsHeight;
        
        private uint m_PelsWidth;
        
        private uint m_PrintQuality;
        
        private uint m_Scale;
        
        private string m_SettingID;
        
        private uint m_SpecificationVersion;
        
        private uint m_TTOption;
        
        private uint m_VerticalResolution;
        
        private uint m_XResolution;
        
        private uint m_YResolution;
        
        private string m_MyPath;
        
        public Win32_PrinterConfiguration()
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
        
        public bool Collate
        {
            get
            {
                return this.m_Collate;
            }
            set
            {
                this.m_Collate = value;
            }
        }
        
        public uint Color
        {
            get
            {
                return this.m_Color;
            }
            set
            {
                this.m_Color = value;
            }
        }
        
        public uint Copies
        {
            get
            {
                return this.m_Copies;
            }
            set
            {
                this.m_Copies = value;
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
        
        public uint DriverVersion
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
        
        public bool Duplex
        {
            get
            {
                return this.m_Duplex;
            }
            set
            {
                this.m_Duplex = value;
            }
        }
        
        public string FormName
        {
            get
            {
                return this.m_FormName;
            }
            set
            {
                this.m_FormName = value;
            }
        }
        
        public uint HorizontalResolution
        {
            get
            {
                return this.m_HorizontalResolution;
            }
            set
            {
                this.m_HorizontalResolution = value;
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
        
        public uint MediaType
        {
            get
            {
                return this.m_MediaType;
            }
            set
            {
                this.m_MediaType = value;
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
        
        public uint Orientation
        {
            get
            {
                return this.m_Orientation;
            }
            set
            {
                this.m_Orientation = value;
            }
        }
        
        public uint PaperLength
        {
            get
            {
                return this.m_PaperLength;
            }
            set
            {
                this.m_PaperLength = value;
            }
        }
        
        public string PaperSize
        {
            get
            {
                return this.m_PaperSize;
            }
            set
            {
                this.m_PaperSize = value;
            }
        }
        
        public uint PaperWidth
        {
            get
            {
                return this.m_PaperWidth;
            }
            set
            {
                this.m_PaperWidth = value;
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
        
        public uint PrintQuality
        {
            get
            {
                return this.m_PrintQuality;
            }
            set
            {
                this.m_PrintQuality = value;
            }
        }
        
        public uint Scale
        {
            get
            {
                return this.m_Scale;
            }
            set
            {
                this.m_Scale = value;
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
        
        public uint TTOption
        {
            get
            {
                return this.m_TTOption;
            }
            set
            {
                this.m_TTOption = value;
            }
        }
        
        public uint VerticalResolution
        {
            get
            {
                return this.m_VerticalResolution;
            }
            set
            {
                this.m_VerticalResolution = value;
            }
        }
        
        public uint XResolution
        {
            get
            {
                return this.m_XResolution;
            }
            set
            {
                this.m_XResolution = value;
            }
        }
        
        public uint YResolution
        {
            get
            {
                return this.m_YResolution;
            }
            set
            {
                this.m_YResolution = value;
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

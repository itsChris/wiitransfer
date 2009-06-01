using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DisplayControllerConfiguration : WMIBase
    {
        
        private uint m_BitsPerPixel;
        
        private string m_Caption;
        
        private uint m_ColorPlanes;
        
        private string m_Description;
        
        private uint m_DeviceEntriesInAColorTable;
        
        private uint m_DeviceSpecificPens;
        
        private uint m_HorizontalResolution;
        
        private string m_Name;
        
        private int m_RefreshRate;
        
        private uint m_ReservedSystemPaletteEntries;
        
        private string m_SettingID;
        
        private uint m_SystemPaletteEntries;
        
        private uint m_VerticalResolution;
        
        private string m_VideoMode;
        
        private string m_MyPath;
        
        public Win32_DisplayControllerConfiguration()
        {
        }
        
        public uint BitsPerPixel
        {
            get
            {
                return this.m_BitsPerPixel;
            }
            set
            {
                this.m_BitsPerPixel = value;
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
        
        public uint ColorPlanes
        {
            get
            {
                return this.m_ColorPlanes;
            }
            set
            {
                this.m_ColorPlanes = value;
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
        
        public uint DeviceEntriesInAColorTable
        {
            get
            {
                return this.m_DeviceEntriesInAColorTable;
            }
            set
            {
                this.m_DeviceEntriesInAColorTable = value;
            }
        }
        
        public uint DeviceSpecificPens
        {
            get
            {
                return this.m_DeviceSpecificPens;
            }
            set
            {
                this.m_DeviceSpecificPens = value;
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
        
        public int RefreshRate
        {
            get
            {
                return this.m_RefreshRate;
            }
            set
            {
                this.m_RefreshRate = value;
            }
        }
        
        public uint ReservedSystemPaletteEntries
        {
            get
            {
                return this.m_ReservedSystemPaletteEntries;
            }
            set
            {
                this.m_ReservedSystemPaletteEntries = value;
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
        
        public uint SystemPaletteEntries
        {
            get
            {
                return this.m_SystemPaletteEntries;
            }
            set
            {
                this.m_SystemPaletteEntries = value;
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
        
        public string VideoMode
        {
            get
            {
                return this.m_VideoMode;
            }
            set
            {
                this.m_VideoMode = value;
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

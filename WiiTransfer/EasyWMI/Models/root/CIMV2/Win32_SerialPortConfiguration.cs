using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SerialPortConfiguration : WMIBase
    {
        
        private bool m_AbortReadWriteOnError;
        
        private uint m_BaudRate;
        
        private bool m_BinaryModeEnabled;
        
        private uint m_BitsPerByte;
        
        private string m_Caption;
        
        private bool m_ContinueXMitOnXOff;
        
        private bool m_CTSOutflowControl;
        
        private string m_Description;
        
        private bool m_DiscardNULLBytes;
        
        private bool m_DSROutflowControl;
        
        private bool m_DSRSensitivity;
        
        private string m_DTRFlowControlType;
        
        private uint m_EOFCharacter;
        
        private uint m_ErrorReplaceCharacter;
        
        private bool m_ErrorReplacementEnabled;
        
        private uint m_EventCharacter;
        
        private bool m_IsBusy;
        
        private string m_Name;
        
        private string m_Parity;
        
        private bool m_ParityCheckEnabled;
        
        private string m_RTSFlowControlType;
        
        private string m_SettingID;
        
        private string m_StopBits;
        
        private uint m_XOffCharacter;
        
        private uint m_XOffXMitThreshold;
        
        private uint m_XOnCharacter;
        
        private uint m_XOnXMitThreshold;
        
        private uint m_XOnXOffInFlowControl;
        
        private uint m_XOnXOffOutFlowControl;
        
        private string m_MyPath;
        
        public Win32_SerialPortConfiguration()
        {
        }
        
        public bool AbortReadWriteOnError
        {
            get
            {
                return this.m_AbortReadWriteOnError;
            }
            set
            {
                this.m_AbortReadWriteOnError = value;
            }
        }
        
        public uint BaudRate
        {
            get
            {
                return this.m_BaudRate;
            }
            set
            {
                this.m_BaudRate = value;
            }
        }
        
        public bool BinaryModeEnabled
        {
            get
            {
                return this.m_BinaryModeEnabled;
            }
            set
            {
                this.m_BinaryModeEnabled = value;
            }
        }
        
        public uint BitsPerByte
        {
            get
            {
                return this.m_BitsPerByte;
            }
            set
            {
                this.m_BitsPerByte = value;
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
        
        public bool ContinueXMitOnXOff
        {
            get
            {
                return this.m_ContinueXMitOnXOff;
            }
            set
            {
                this.m_ContinueXMitOnXOff = value;
            }
        }
        
        public bool CTSOutflowControl
        {
            get
            {
                return this.m_CTSOutflowControl;
            }
            set
            {
                this.m_CTSOutflowControl = value;
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
        
        public bool DiscardNULLBytes
        {
            get
            {
                return this.m_DiscardNULLBytes;
            }
            set
            {
                this.m_DiscardNULLBytes = value;
            }
        }
        
        public bool DSROutflowControl
        {
            get
            {
                return this.m_DSROutflowControl;
            }
            set
            {
                this.m_DSROutflowControl = value;
            }
        }
        
        public bool DSRSensitivity
        {
            get
            {
                return this.m_DSRSensitivity;
            }
            set
            {
                this.m_DSRSensitivity = value;
            }
        }
        
        public string DTRFlowControlType
        {
            get
            {
                return this.m_DTRFlowControlType;
            }
            set
            {
                this.m_DTRFlowControlType = value;
            }
        }
        
        public uint EOFCharacter
        {
            get
            {
                return this.m_EOFCharacter;
            }
            set
            {
                this.m_EOFCharacter = value;
            }
        }
        
        public uint ErrorReplaceCharacter
        {
            get
            {
                return this.m_ErrorReplaceCharacter;
            }
            set
            {
                this.m_ErrorReplaceCharacter = value;
            }
        }
        
        public bool ErrorReplacementEnabled
        {
            get
            {
                return this.m_ErrorReplacementEnabled;
            }
            set
            {
                this.m_ErrorReplacementEnabled = value;
            }
        }
        
        public uint EventCharacter
        {
            get
            {
                return this.m_EventCharacter;
            }
            set
            {
                this.m_EventCharacter = value;
            }
        }
        
        public bool IsBusy
        {
            get
            {
                return this.m_IsBusy;
            }
            set
            {
                this.m_IsBusy = value;
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
        
        public string Parity
        {
            get
            {
                return this.m_Parity;
            }
            set
            {
                this.m_Parity = value;
            }
        }
        
        public bool ParityCheckEnabled
        {
            get
            {
                return this.m_ParityCheckEnabled;
            }
            set
            {
                this.m_ParityCheckEnabled = value;
            }
        }
        
        public string RTSFlowControlType
        {
            get
            {
                return this.m_RTSFlowControlType;
            }
            set
            {
                this.m_RTSFlowControlType = value;
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
        
        public string StopBits
        {
            get
            {
                return this.m_StopBits;
            }
            set
            {
                this.m_StopBits = value;
            }
        }
        
        public uint XOffCharacter
        {
            get
            {
                return this.m_XOffCharacter;
            }
            set
            {
                this.m_XOffCharacter = value;
            }
        }
        
        public uint XOffXMitThreshold
        {
            get
            {
                return this.m_XOffXMitThreshold;
            }
            set
            {
                this.m_XOffXMitThreshold = value;
            }
        }
        
        public uint XOnCharacter
        {
            get
            {
                return this.m_XOnCharacter;
            }
            set
            {
                this.m_XOnCharacter = value;
            }
        }
        
        public uint XOnXMitThreshold
        {
            get
            {
                return this.m_XOnXMitThreshold;
            }
            set
            {
                this.m_XOnXMitThreshold = value;
            }
        }
        
        public uint XOnXOffInFlowControl
        {
            get
            {
                return this.m_XOnXOffInFlowControl;
            }
            set
            {
                this.m_XOnXOffInFlowControl = value;
            }
        }
        
        public uint XOnXOffOutFlowControl
        {
            get
            {
                return this.m_XOnXOffOutFlowControl;
            }
            set
            {
                this.m_XOnXOffOutFlowControl = value;
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

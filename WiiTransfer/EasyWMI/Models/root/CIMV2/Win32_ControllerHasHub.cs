using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_ControllerHasHub : WMIBase
    {
        
        private ushort m_AccessState;
        
        private string m_Antecedent;
        
        private string m_Dependent;
        
        private uint m_NegotiatedDataWidth;
        
        private ulong m_NegotiatedSpeed;
        
        private uint m_NumberOfHardResets;
        
        private uint m_NumberOfSoftResets;
        
        private string m_MyPath;
        
        public Win32_ControllerHasHub()
        {
        }
        
        public ushort AccessState
        {
            get
            {
                return this.m_AccessState;
            }
            set
            {
                this.m_AccessState = value;
            }
        }
        
        public string Antecedent
        {
            get
            {
                return this.m_Antecedent;
            }
            set
            {
                this.m_Antecedent = value;
            }
        }
        
        public string Dependent
        {
            get
            {
                return this.m_Dependent;
            }
            set
            {
                this.m_Dependent = value;
            }
        }
        
        public uint NegotiatedDataWidth
        {
            get
            {
                return this.m_NegotiatedDataWidth;
            }
            set
            {
                this.m_NegotiatedDataWidth = value;
            }
        }
        
        public ulong NegotiatedSpeed
        {
            get
            {
                return this.m_NegotiatedSpeed;
            }
            set
            {
                this.m_NegotiatedSpeed = value;
            }
        }
        
        public uint NumberOfHardResets
        {
            get
            {
                return this.m_NumberOfHardResets;
            }
            set
            {
                this.m_NumberOfHardResets = value;
            }
        }
        
        public uint NumberOfSoftResets
        {
            get
            {
                return this.m_NumberOfSoftResets;
            }
            set
            {
                this.m_NumberOfSoftResets = value;
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

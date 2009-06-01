using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Management;

namespace EasyWMI.Controllers
{
    public class WMIBase
    {
        private static string m_ComputerName;
        private static string m_Username;
        private static string m_Password;
        private string m_Namespace = @"\root\CIMV2";
        private string m_Query = "select * from";
        private System.Net.IPAddress m_IPAddress;
        private ConnectionOptions m_Connection;
        private ManagementScope m_ManagementScope;
        

        #region "Constructors"

        /// <summary>
        /// Creates a new instance of WinComputer for 'localhost' using \root\CIMV2 namespace.
        /// </summary>
        public WMIBase()
        {
            m_ComputerName = "localhost";
            m_IPAddress = System.Net.IPAddress.Parse("127.0.0.1");

            SetScope();
        }

        /// <summary>
        /// Creates a new instance of WinComputer for the given computer name using \root\CIMV2 namespace.
        /// Use this if the account logged into the computer has rights to perform WMI queries.
        /// </summary>
        /// <param name="ComputerName">The name of the computer to connect to.</param>
        public WMIBase(string ComputerName)
        {
            m_ComputerName = ComputerName;

            SetScope();
        }

        /// <summary>
        /// Creates a new instance of WinComputer for the given IPAddress using \root\CIMV2 namespace.
        /// Use this if the account logged into the computer has rights to perform WMI queries.
        /// </summary>
        /// <param name="IPAddress">The IP address of the computer to connect to.</param>
        public WMIBase(System.Net.IPAddress IPAddress)
        {
            m_IPAddress = IPAddress;

            SetScope();
        }

        /// <summary>
        /// Creates a new instance of WinComputer using \root\CIMV2 namespace.
        /// </summary>
        /// <param name="Username">The username to use when connecting to remote computers.</param>
        /// <param name="Password">The password to use when connecting to remote computers.</param>
        /// <param name="ComputerName">The name of the computer to connect to.</param>
        public WMIBase(string Username, string Password, string ComputerName)
        {
            m_Username = Username;
            m_Password = Password;
            m_ComputerName = ComputerName;

            SetScope();
        }

        /// <summary>
        /// Creates a new instance of WinComputer using \root\CIMV2 namespace.
        /// </summary>
        /// <param name="Username">The username to use when connecting to remote computers.</param>
        /// <param name="Password">The password to use when connecting to remote computers.</param>
        /// <param name="IPAddress">The IP address of the computer to connect to.</param>
        public WMIBase(string Username, string Password, System.Net.IPAddress IPAddress)
        {
            m_Username = Username;
            m_Password = Password;
            m_IPAddress = IPAddress;

            SetScope();
        }
        #endregion

        #region "Properties"

        /// <summary>
        /// Gets or sets the name of the computer.
        /// </summary>
        public string EasyWMICfgComputerName
        {
            get { return m_ComputerName; }
            set { m_ComputerName = value; }
        }

        /// <summary>
        /// Gets or sets the name of the user credentials to use.
        /// </summary>
        public string EasyWMICfgUsername
        {
            get { return m_Username; }
            set { m_Username = value; }
        }

        /// <summary>
        /// Sets the password of the user credentials to use.
        /// </summary>
        public string EasyWMICfgPassword
        {
            set { m_Password = value; }
        }

        /// <summary>
        /// Gets or sets the IP address of the remote computer.
        /// </summary>
        public System.Net.IPAddress EasyWMICfgIPAddress
        {
            get { return m_IPAddress;  }
            set 
            {
                m_ComputerName = null;
                m_IPAddress = value; 
            }
        }

        /// <summary>
        /// Gets or sets the namespace in which the class resides. Default: \root\CIMV2
        /// </summary>
        public string EasyWMICfgNamespace
        {
            get { return m_Namespace; }
            set { m_Namespace = value; }
        }

        /// <summary>
        /// Gets or sets the query to run against the current WMI class.
        /// </summary>
        public string EasyWMICfgQuery
        {
            get { return m_Query; }
            set { m_Query = value; }
        }

        #endregion

        #region "Methods"

        /// <summary>
        /// Sets the management scope for the WMI query.
        /// </summary>
        public void SetScope()
        {
            SetConnect();

            if (m_Password != null)
            {
                if (this.EasyWMICfgComputerName != null)
                {
                    m_ManagementScope = new ManagementScope("\\\\" + m_ComputerName + m_Namespace, m_Connection);
                }
                else if (this.EasyWMICfgIPAddress != null)
                {
                    m_ManagementScope = new ManagementScope("\\\\" + m_IPAddress.ToString() + m_Namespace, m_Connection);
                }
            }
            else
            {
                if (this.EasyWMICfgComputerName != null)
                {
                    m_ManagementScope = new ManagementScope("\\\\" + m_ComputerName + m_Namespace);
                }
                else
                {
                    m_ManagementScope = new ManagementScope("\\\\" + m_IPAddress.ToString() + m_Namespace);
                }
            }
            
        }

        /// <summary>
        /// Set the ConnectionOptions options.
        /// </summary>
        private void SetConnect()
        {
            m_Connection = new ConnectionOptions();
            m_Connection.Username = m_Username;
            m_Connection.Password = m_Password;
            m_Connection.Impersonation = ImpersonationLevel.Impersonate;
            m_Connection.Authentication = AuthenticationLevel.Packet;
        }
        

        /// <summary>
        /// Returns an object collection from the specified WMI class.
        /// </summary>
        /// <param name="WMIClass">Name of WMI class to query. (Win32_OperatingSystem)</param>
        /// <returns>ManagementObjectCollection</returns>
        public ManagementObjectCollection GetObjectCollection(string WMIClass)
        {
            ManagementObjectCollection oReturnCollection = null;

            EnumerationOptions Options = new EnumerationOptions();
            Options.Timeout = new TimeSpan(0, 0, 5);
            Options.ReturnImmediately = true;

            try
            {
                m_Query += " ";
                ObjectQuery oQuery = new ObjectQuery(m_Query + WMIClass);
                ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(m_ManagementScope, oQuery, Options);
                oReturnCollection = oSearcher.Get();
            }
            catch (Exception)
            {
                
            }
            return oReturnCollection;
        }

        /// <summary>
        /// Invokes a WMI object's method.
        /// </summary>
        /// <param name="ObjectPath">Exact path to the object in which you want to invoke the method.</param>
        /// <param name="MethodName">Name of the method to invoke.</param>
        /// <param name="InParams">Input parameters for the method.</param>
        /// <param name="Options">Options to use when invoking the method.</param>
        /// <returns>ManagementBaseObject</returns>
        public ManagementBaseObject InvokeMethod(string ObjectPath, string MethodName, ManagementBaseObject InParams, InvokeMethodOptions Options)
        {
            ManagementObject WMIObject = new ManagementObject(ObjectPath);
            ManagementBaseObject OutParams = WMIObject.InvokeMethod(MethodName, InParams, Options);                  
                                
            if (InParams != null)
            {
                InParams.Dispose();
            }

            return OutParams;
        }        

        #endregion
    }
}

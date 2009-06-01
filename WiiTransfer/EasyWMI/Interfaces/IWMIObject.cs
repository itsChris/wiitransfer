using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWMI.Interfaces
{
    public interface IWMIObject<T>
    {
        System.Collections.Generic.IList<T> SelectAll();
    }
}

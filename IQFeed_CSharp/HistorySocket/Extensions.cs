using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/*// you need this once (only), and it must be in this namespace
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
         | AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute { }
}*/

namespace HistorySocket
{
    public static class Extensions
    {

        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

    } // end of class
} // end of namespace

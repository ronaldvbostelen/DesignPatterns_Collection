using System;
using ProxyPattern.ProtectionProxy;

namespace ProtectionProxy
{
    public interface IInvocationHandler
    {
        void InvokeSet(object proxy, Action<IPersonBean> action);
        object InvokeGet(object proxy, Func<IPersonBean,object> func);
    }
}
using System;
using ProxyPattern.ProtectionProxy;

namespace ProtectionProxy
{
    public class OwnerInvocationHandler : IInvocationHandler
    {
        private IPersonBean person;

        public OwnerInvocationHandler(IPersonBean person)
        {
            this.person = person;
        }
        
        public void InvokeSet(object proxy, Action<IPersonBean> action)
        {
            if (action.Method.Name.Contains("HotOrNotRating"))
            {
                throw new AccessViolationException("You are not allowed to change your own Hot Or Not Rating");
            }

            action(person);
        }

        public object InvokeGet(object proxy, Func<IPersonBean, object> action)
        {
            return action(person);
        }
    }
}
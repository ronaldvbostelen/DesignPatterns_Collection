using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ProxyPattern.ProtectionProxy;

namespace ProtectionProxy
{
    public class NonOwnerInvocationHandler : IInvocationHandler
    {
        private IPersonBean person;

        public NonOwnerInvocationHandler(IPersonBean person)
        {
            this.person = person;
        }

        public void InvokeSet(object proxy, Action<IPersonBean> action)
        {
            if (!action.Method.Name.Contains("HotOrNot"))
            {
                throw new AccessViolationException("You are not allowed to modify this person");
            }

            action(person);
        }

        public object InvokeGet(object proxy, Func<IPersonBean, object> action)
        {
            if (action.Method.Name.Contains("Interests"))
            {
                return action(new PersonBean {Interests = person.Interests.ToList()}); // new ref so nonOwner cant mess with collection
            }

            return action(person);
        }
    }
}
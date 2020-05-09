using System;
using System.Collections.Generic;
using ProxyPattern.ProtectionProxy;

namespace ProtectionProxy
{
    public class PersonBeanProxy : IPersonBean
    {
        private IInvocationHandler invocationHandler;

        public string Name
        {
            get
            {
                try
                {
                    return (string) invocationHandler.InvokeGet(this, x => x.Name);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            set
            {
                try
                {
                    invocationHandler.InvokeSet(this, x => x.Name = value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public string Gender
        {
            get
            {
                try
                {
                    return (string)invocationHandler.InvokeGet(this, x => x.Gender);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            set
            {
                try
                {
                    invocationHandler.InvokeSet(this, x => x.Gender = value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        public IList<string> Interests
        {
            get
            {
                try
                {
                    return (IList<string>) invocationHandler.InvokeGet(this, x => x.Interests);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            set
            {
                try
                {
                    invocationHandler.InvokeSet(this, x => x.Interests = value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        public int HotOrNotRating
        {
            get
            {
                try
                {
                    return (int) invocationHandler.InvokeGet(this, x => x.HotOrNotRating);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            set
            {
                try
                {
                    invocationHandler.InvokeSet(this, x => x.HotOrNotRating = value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public PersonBeanProxy(IPersonBean person, bool owner)
        {
            if (owner)
            {
                invocationHandler = new OwnerInvocationHandler(person);
            }
            else
            {
                invocationHandler = new NonOwnerInvocationHandler(person);
            }
        }
    }
}
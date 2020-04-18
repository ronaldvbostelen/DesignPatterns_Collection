using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;

namespace SingletonPattern
{
    class UserPreference
    {
        private static object lockObject = new object();
        private static UserPreference instance;
        public string SayWhat { get; }
        private UserPreference()
        {
            SayWhat = "HonkiDory";
        }

        public static UserPreference GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance = new UserPreference();
                }
            }

            return instance;
        }
    }
}

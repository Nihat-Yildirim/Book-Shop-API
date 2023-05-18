using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Claims
{
    public static class Claims
    {
        public static int Customer
        {
            get
            {
                return 1;
            }
            private set 
            { 
            }
        }

        public static int Dealer
        {
            get
            {
                return 2;
            }
            private set
            {
            }
        }

        public static int Admin
        {
            get
            {
                return 3;
            }
            private set
            {
            }
        }
    }
}
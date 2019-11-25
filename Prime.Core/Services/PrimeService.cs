using System;
using System.Collections.Generic;
using System.Text;

namespace Prime.Core.Services
{
    public class PrimeService : IPrimeService
    {
        public string GetPrime(int N)
        {
            int conPri = 0, i = 1;
            string primo = "";
            
            while (conPri < N)
            {
                if(IsPrime(i))
                {
                    primo += String.Format("{0:N0}\t",i);
                    conPri++;
                }
                i++;
            }
            return primo;               
        }
        private bool IsPrime(long M)
        {
            if (M <= 1) return false;
            for (int j = 2; j <= M / 2; j++)
            {
                if (M % j == 0) return false;

            }
            return true;
        }
    }
}


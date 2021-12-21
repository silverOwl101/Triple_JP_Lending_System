using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPLibraryCore
{
    public class TripleJPUtility
    {        
        public string NewId()
        {
            Random rd = new Random();
            uint id;
            string getYear;
            id = (uint)rd.Next(100000000, 200000000);
            getYear = DateTime.Now.Year.ToString();
            StringBuilder sb = new StringBuilder(id.ToString() + "-" + getYear, 14);
            return sb.ToString();
        }
    }
    public class Computation
    {
        public decimal MaturityInterest(decimal loan)
        {
            decimal principalLoan = loan;
            const decimal interest = 0.20M;
            decimal MaturityInterest = principalLoan * interest;
            return MaturityInterest;
        }
        public decimal MaturityValue(decimal maturityInterest, decimal loan)
        {
            decimal interest = maturityInterest;
            decimal principalLoan = loan;
            decimal maturityValue = principalLoan + interest;
            return maturityValue;
        }
        public int PerRemittance(decimal maturityValue, int _duration)
        {
            decimal _value = maturityValue;
            int duration = _duration;
            int perRemittance = (int)_value / duration;
            return perRemittance;
        }
    }
}

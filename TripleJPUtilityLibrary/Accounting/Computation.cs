using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPUtilityLibrary.Accounting
{
    public class Computation
    {
        //private const decimal Interest = 0.20M;
        private decimal _principalLoan;
        private decimal _maturityInterest;
        private decimal _maturityValue;
        private decimal _interest;
        private int _duration;
        private int _perRemittance;

        public decimal MaturityInterest(decimal principalLoan,decimal interest)
        {
            _principalLoan = principalLoan;
            _maturityInterest = _principalLoan * (interest/100);
            return _maturityInterest;
        }
        public decimal MaturityValue(decimal maturityInterest, decimal principalLoan)
        {
            _interest = maturityInterest;
            _principalLoan = principalLoan;
            _maturityValue = _principalLoan + _interest;
            return _maturityValue;
        }
        public int PerRemittance(decimal maturityValue, int duration)
        {
            _maturityValue = maturityValue;
            _duration = duration;
            _perRemittance = (int)_maturityValue / _duration;
            return _perRemittance;
        }
        public DateTime MaturityDate(DateTime effectiveDate, double duration)
        {
            return effectiveDate.AddDays(duration);
        }
    }
}

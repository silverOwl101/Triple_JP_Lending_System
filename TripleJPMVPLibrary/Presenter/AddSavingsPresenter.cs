using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;
using TripleJPMVPLibrary.View;

namespace TripleJPMVPLibrary.Presenter
{
    public class AddSavingsPresenter
    {
        private IAddAmountAndDate _amountAndDate;
        private SalaryServices _salaryServices;
        private SavingsServices _savingsServices;
        private CollectionService _collectionService;
        private Savings savings;

        public AddSavingsPresenter()
        {

        }
        public AddSavingsPresenter(IAddAmountAndDate addAmountAndDate)
        {
            _amountAndDate = addAmountAndDate;
        }
        public bool OnLoadRemit()
        {
            savings = new Savings();
            savings.SavingsAmount = _amountAndDate.Amount;
            savings.CollectionDate = _amountAndDate.Date;
            savings.DateRemmited = DateTime.Now.Date;

            if (IsDateValid(savings.CollectionDate))
            {
                _savingsServices = new SavingsServices();
                _savingsServices.OnSetAddSavings(savings);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsDateValid(DateTime date)
        {
            _collectionService = new CollectionService();
            return _collectionService.OnSetCheckDateValidity(date);
        }
        public decimal OnLoadGetDailyTotalCollectionByDate(DateTime date)
        {
            _collectionService = new CollectionService();
            return _collectionService.OnSetGetDailyTotalCollectionByDate(date);
        }
        public decimal OnLoadGetTotalSalary(DateTime date)
        {
            _salaryServices = new SalaryServices();
            return _salaryServices.OnSetGetTotalSalary(date);
        }
        public decimal OnLoadGetTotalSavings(DateTime date)
        {
            _savingsServices = new SavingsServices();
            return _savingsServices.OnSetGetTotalSavings(date);
        }
    }
}

using Mysqlx.Datatypes;
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
    public class AddSalaryPresenter
    {
        private IAddAmountAndDate _amountAndDate;
        private SalaryServices _salaryServices;
        private SavingsServices _savingsServices;
        private CollectionService _collectionService;
        private Salary salary;

        public AddSalaryPresenter()
        {

        }
        public AddSalaryPresenter(IAddAmountAndDate addAmountAndDate)
        {
            _amountAndDate = addAmountAndDate;
        }        
        public bool Remit()
        {            
            salary = new Salary();
            salary.SalaryAmount = _amountAndDate.Amount;
            salary.CollectionDate = _amountAndDate.Date;
            salary.DateRemmited = DateTime.Now.Date;

            if (IsDateValid(salary.CollectionDate))
            {
                _salaryServices = new SalaryServices();
                _salaryServices.OnCallAddSalary(salary);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsDateValid(DateTime date)
        {
            _salaryServices = new SalaryServices();
            return _salaryServices.OnCallCheckDateValidity(date);
        }
        public decimal DailyTotalCollection(DateTime date)
        {
            _collectionService = new CollectionService();
            return _collectionService.OnCallGetDailyTotalCollectionByDate(date);
        }
        public decimal TotalSalaryRemitted(DateTime date)
        {
            _salaryServices = new SalaryServices();
            return _salaryServices.OnCallGetTotalSalary(date);
        }
        public decimal TotalSavingsRemitted(DateTime date)
        {
            _savingsServices = new SavingsServices();
            return _savingsServices.OnCallGetTotalSavings(date);
        }
    }
}

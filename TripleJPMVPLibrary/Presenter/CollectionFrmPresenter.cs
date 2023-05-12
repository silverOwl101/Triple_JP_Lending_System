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
    public class CollectionFrmPresenter
    {
        private IAddCollection _addCollection;
        private IAddPenalty _addPenalty;
        private ICompareCollectionAndLoan _compareCollectionAndLoan;
        private CollectionService _collectionService;        
        private Collection _collection;
        private Penalty _penalty;
        private Customer _customer = new Customer();
        private Loan _loan;

        public CollectionFrmPresenter(  IAddCollection addCollection, 
                                        ICompareCollectionAndLoan compareCollectionAndLoan,
                                        IAddPenalty addPenalty)
        {
            _addCollection = addCollection;
            _addPenalty = addPenalty;
            _compareCollectionAndLoan = compareCollectionAndLoan;
        }
        
        private void InitLoanInstance()
        {
            _loan = new Loan
            {
                Id = _addCollection.LoanId
            };            
        }
        public void AddPenalty()
        {
            InitLoanInstance();
            _penalty = new Penalty
            {
                Date = _addPenalty.DateOfPenalty,
                Amount = _addPenalty.PenaltyAmount
            };

            _collectionService = new CollectionService();
            _collectionService.AddPenalty(_penalty, _customer, _loan);
        }
        public bool AddCollection() 
        {
            InitLoanInstance();

            _collection = new Collection
            {
                Date = _addCollection.Date,
                Amount = _addCollection.Amount
            };

            decimal totalAmountFinal = _compareCollectionAndLoan.CollectionTotalAmount + _addCollection.Amount;
            if (totalAmountFinal < _compareCollectionAndLoan.LoanTotalAmount)
            {
                _collectionService = new CollectionService();
                _collectionService.AddCollection(_collection, _customer, _loan);
                if (_compareCollectionAndLoan.LoanTotalAmount ==
                                              totalAmountFinal) //check if amount is fully paid
                {
                    isFullyPaid(_loan);
                }
                return true;
            }                                      
            return false;
        }
        private void isFullyPaid(Loan _loan)
        {
            _collectionService = new CollectionService();
            _collectionService.LoanStatusUpdate(_loan);
        }
    }
}

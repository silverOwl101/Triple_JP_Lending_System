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
        private ICompareCollectionAndLoan _compareCollection;
        private CollectionService _collectionService;        
        private Collection _collection;
        private Penalty _penalty;
        private Customer _customer = new Customer();
        private Loan _loan;

        public CollectionFrmPresenter(  IAddCollection addCollection, ICompareCollectionAndLoan collection,
                                        IAddPenalty addPenalty)
        {
            _addCollection = addCollection;
            _addPenalty = addPenalty;
            _compareCollection = collection;
        }
        public CollectionFrmPresenter(IAddCollection addCollection)
        {
            _addCollection = addCollection;            
        }
        public decimal OnLoadGetTotalPenalty()
        {            
            _collectionService = new CollectionService();
            InitLoanInstance();
            decimal totalPenaltyAmount = _collectionService.OnSetGetTotalPenalty(_loan);
            return totalPenaltyAmount;
        }
        private void InitLoanInstance()
        {
            _loan = new Loan
            {
                Id = _addCollection.LoanId
            };            
        }
        public void OnLoadInsertPenalty()
        {
            InitLoanInstance();
            _penalty = new Penalty
            {
                Date = _addPenalty.DateOfPenalty,
                Amount = _addPenalty.PenaltyAmount
            };

            _collectionService = new CollectionService();
            _collectionService.OnSetInsertPenalty(_penalty, _customer, _loan);
        }
        public bool OnLoadInsertCollection() 
        {
            InitLoanInstance();
            _collectionService = new CollectionService();            

            _collection = new Collection
            {
                Date = _addCollection.Date,
                Amount = _addCollection.Amount
            };
            
            decimal collectedAmount = _collectionService.OnSetGetTotalCollection(_loan);
            decimal totalPenaltyAmount = _collectionService.OnSetGetTotalPenalty(_loan);

            decimal totalAmountFinal = collectedAmount + _addCollection.Amount;
            decimal totalLoanFinal = _compareCollection.loanAmount + totalPenaltyAmount;
            if (totalAmountFinal <= totalLoanFinal)
            {
                
                _collectionService.OnSetInsertCollection(_collection, _customer, _loan);
                if (totalLoanFinal == totalAmountFinal) //check if amount is fully paid
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
            _collectionService.OnSetLoanStatusUpdate(_loan);
        }
    }
}

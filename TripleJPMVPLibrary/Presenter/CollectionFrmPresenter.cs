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
        private ICompareCollectionAndLoan _compareCollectionAndLoan;
        private CollectionService _collectionService;
        private PostingService _postingService;
        private Collection _collection;
        private Customer _customer = new Customer();
        private Loan _loan;

        public CollectionFrmPresenter(IAddCollection addCollection, ICompareCollectionAndLoan compareCollectionAndLoan)
        {
            _addCollection = addCollection;
            _compareCollectionAndLoan = compareCollectionAndLoan;
        }

        public void AddCollection() 
        {
            _loan = new Loan
            {
                Id = _addCollection.LoanId
            };
            
            _collection = new Collection
            {
                Date = _addCollection.Date,
                Amount = _addCollection.Amount
            };

            _collectionService = new CollectionService();
            _collectionService.AddCollection(_collection,_customer,_loan);
            decimal totalAmountFinal = _compareCollectionAndLoan.CollectionTotalAmount + _addCollection.Amount;
            if (_compareCollectionAndLoan.LoanTotalAmount == totalAmountFinal)
            {
                isFullyPaid(_loan);
            }
        }
        private void isFullyPaid(Loan _loan)
        {
            _collectionService = new CollectionService();
            _collectionService.LoanStatusUpdate(_loan);
        }
    }
}

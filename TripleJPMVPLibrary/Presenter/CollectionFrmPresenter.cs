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
        private CollectionService _collectionService;
        private Collection _collection;
        private Customer _customer = new Customer();
        private Loan _loan;

        public CollectionFrmPresenter(IAddCollection addCollection)
        {
            _addCollection = addCollection;
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
        }

    }
}

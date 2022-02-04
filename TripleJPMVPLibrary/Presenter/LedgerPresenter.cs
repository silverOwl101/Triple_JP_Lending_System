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
    public class LedgerPresenter
    {
        IGetCollectionAndPenalty _getCollectionAndPenalty;
        public LedgerPresenter(IGetCollectionAndPenalty getCollectionAndPenalty)
        {
            _getCollectionAndPenalty = getCollectionAndPenalty;
        }
        private LoanService _loanService = new LoanService();        
        public List<GetCollectionAndPenalty> GetCollectionAndPenalty()
        {
            return _loanService.OnCallGetCollectionAndPenalty(_getCollectionAndPenalty.LoanID);
        }
    }
}

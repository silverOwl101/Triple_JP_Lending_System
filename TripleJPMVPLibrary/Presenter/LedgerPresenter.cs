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

        #region Fields

        IGetCollectionAndPenalty _getCollectionAndPenalty;
        private LoanService _loanService;

        #endregion

        public LedgerPresenter(IGetCollectionAndPenalty getCollectionAndPenalty)
        {
            _getCollectionAndPenalty = getCollectionAndPenalty;
        }


        
        public List<GetCollectionAndPenalty> GetCollectionAndPenalty()
        {

            _loanService = new LoanService();

            return _loanService.OnCallGetCollectionAndPenalty(_getCollectionAndPenalty.LoanID);

        }
    }
}

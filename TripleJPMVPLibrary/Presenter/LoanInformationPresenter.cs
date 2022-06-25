using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;

namespace TripleJPMVPLibrary.Presenter
{    
    public class LoanInformationPresenter
    {

        #region Fields

        private ISearch _search;
        private Customer _customer;
        private LoanService _loanService;
        private List<GetCustomerLoanInformation> _getLoanInformation;

        #endregion

        public LoanInformationPresenter(ISearch search)
        {
            _search = search;            
            OnLoadLoanInformationData();
        }

        private void OnLoadLoanInformationData()
        {
            _customer = new Customer();
            _loanService = new LoanService();
            _getLoanInformation = new List<GetCustomerLoanInformation>();

            if (String.IsNullOrEmpty(_search.UserSearch))
            {
                const string MessageContent = "Enter your credentials";
                const string MessageCaption = "Record not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Regex rgx = new Regex(@"^\d{9}-\d{4}$"); // match the format of customer Id
                if (rgx.IsMatch(_search.UserSearch))
                {
                    _customer.Id = _search.UserSearch;
                }
                else
                {
                    _customer.Name = _search.UserSearch;
                }
                _getLoanInformation = _loanService.OnCallGetLoanInformation(_customer);                
            }
        }

        public List<GetCustomerLoanInformation> GetLoanInformationList()
        {
            return _getLoanInformation;
        }        
    }
}

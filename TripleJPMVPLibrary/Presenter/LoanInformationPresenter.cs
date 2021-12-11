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
        ISearch search;
        Customer customer = new Customer();
        LoanService loanService = new LoanService();
        List<GetCustomerLoanInformation> getLoanInformation = 
            new List<GetCustomerLoanInformation>();
        public LoanInformationPresenter(ISearch search)
        {
            this.search = search;
            onLoadLoanInformationData();
        }
        private void onLoadLoanInformationData()
        {
            if (String.IsNullOrEmpty(search.userSearch))
            {
                const string MessageContent = "Enter your credentials";
                const string MessageCaption = "Record not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Regex rgx = new Regex(@"^\d{9}-\d{4}$"); // match the format of customer id
                if (rgx.IsMatch(search.userSearch))
                {
                    customer.id = search.userSearch;
                }
                else
                {
                    customer.name = search.userSearch;
                }
                getLoanInformation = loanService.onCallGetLoanInformation(customer);
                if (getLoanInformation.Count == 0)
                {
                    const string MessageContent = "Double check the entry or contact your I.T personnel for futher details";
                    string MessageCaption = "Record not found";
                    MessageBox.Show(MessageContent, MessageCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public List<GetCustomerLoanInformation> GetLoanInformationList()
        {
            return getLoanInformation;
        }
    }
}

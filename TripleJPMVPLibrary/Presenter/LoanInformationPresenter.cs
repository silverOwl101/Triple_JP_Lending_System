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
using System.Data;

namespace TripleJPMVPLibrary.Presenter
{    
    public class LoanInformationPresenter
    {
        #region Fields

        private ISearch _search;
        private Customer _customer;
        private LoanService _loanService;
        private CollectionService _collectionService;
        private Loan loan;
        private List<GetCustomerLoanInformation> _getLoanInformation;
        private GetCustomerLoanInformation getCustomerLoanInformation;
        private DataTable tbl1 = new DataTable();

        #endregion
        public LoanInformationPresenter(ISearch search)
        {
            _search = search;            
            LoanInformationData();
        }
        private void LoanInformationData()
        {
            _customer = new Customer();
            _loanService = new LoanService();
            _collectionService = new CollectionService();
            _getLoanInformation = new List<GetCustomerLoanInformation>();
            
            if (String.IsNullOrEmpty(_search.UserSearch))
            {
                throw new ArgumentNullException(nameof(_search.UserSearch), "UserSearch is Null");
            }
            else
            {
                Regex rgx = new Regex(@"^\d{9}-\d{4}$"); // match the format of customer Id
                if (rgx.IsMatch(_search.UserSearch))
                {
                    _customer.Id = _search.UserSearch;
                    tbl1 = _loanService.OnSetGetLoanInformationUsingCustomerID(_customer).
                           Tables["CustomerLoanInformation"];
                    Init_DataTableToListConvertion(tbl1);
                }
                else
                {
                    _customer.Name = _search.UserSearch;
                    tbl1 = _loanService.OnSetGetLoanInformationUsingCustomerName(_customer).
                           Tables["CustomerLoanInformation"];
                    Init_DataTableToListConvertion(tbl1);
                }                
            }
        }
        private void Init_DataTableToListConvertion(DataTable tbl)
        {            
            foreach (DataRow row in tbl1.Rows)
            {
                loan = new Loan();
                loan.Id = row["Loan ID"].ToString();

                getCustomerLoanInformation = new GetCustomerLoanInformation
                {
                    Id = loan.Id,
                    CustomerID = row["Customer ID"].ToString(),
                    Name = row["Customer Name"].ToString(),
                    PaymentTerm = row["Payment Term"].ToString(),
                    Duration = Convert.ToInt32(row["Duration"]),
                    EffectiveDate = Convert.ToDateTime(row["Effective Date"]).ToString("MM-dd-yyyy"),
                    Interest = Convert.ToDecimal(row["Interest Rate"]),
                    PrincipalLoan = Convert.ToInt32(row["Principal Loan"]),
                    Status = row["Status"].ToString(),
                    CollectedAmount = _collectionService.
                                      OnSetGetTotalCollectionForLoanInformationForm(loan),
                    PenaltyAmount = _collectionService.
                                    OnSetGetTotalPenaltyForLoanInformationForm(loan)
                };
                _getLoanInformation.Add(getCustomerLoanInformation);
            }
        }
        public List<GetCustomerLoanInformation> OnLoadLoanInformation()
        {
            return _getLoanInformation;
        }        
    }
}

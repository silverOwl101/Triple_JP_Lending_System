using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Service;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.View;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TripleJPMVPLibrary.Presenter
{
    public class GetCustomerListPresenter
    {
        #region Fields

        private ISearch _search;        
        private CustomerService _customerService;
        private Customer _customer;
        private List<GetCustomerInfo> _getCustomer;

        #endregion

        public GetCustomerListPresenter(ISearch search)
        {
            _search = search;            
        }

        public void CallSearch()
        {
            _customer = new Customer();
            _customerService = new CustomerService();
            _getCustomer = new List<GetCustomerInfo>();

            if (String.IsNullOrEmpty(_search.UserSearch))
            {
                const string MessageContent = "Enter your credentials";
                const string MessageCaption = "Record not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw new ArgumentNullException(_search.UserSearch, " UserSearch is Null ");
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
                _getCustomer = _customerService.GetCustomerListData(_customer);
                if (_getCustomer.Count == 0)
                {
                    const string MessageContent = "Double check the entry or contact your I.T personnel for futher details";
                    string MessageCaption = "Record not found";
                    MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //throw new ArgumentException(" Input is Invalid ", _search.UserSearch);
                }
            }            
        }

        public List<GetCustomerInfo> GetList()
        {
            return _getCustomer;
        }      
    }
}

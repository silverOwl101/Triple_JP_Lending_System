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
                throw new ArgumentNullException(nameof(_search.UserSearch), " UserSearch is Null ");
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

                _getCustomer = _customerService.GetCustomerList(_customer);

                if (_getCustomer.Count == 0)
                {
                    throw new ArgumentException(" Input is Invalid ", nameof(_search.UserSearch));
                }
            }            
        }

        public List<GetCustomerInfo> GetCustomerListData()
        {
            return _getCustomer;
        }      
    }
}

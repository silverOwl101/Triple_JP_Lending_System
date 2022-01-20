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
        ISearch search;        
        CustomerService customerService = new CustomerService();
        Customer customer = new Customer();        
        List<GetCustomerInfo> getcustomer = new List<GetCustomerInfo>();
        public GetCustomerListPresenter(ISearch search)
        {
            this.search = search;            
        }
        public void CallSearch()
        {            
            if (String.IsNullOrEmpty(search.UserSearch))
            {
                const string MessageContent = "Enter your credentials";
                const string MessageCaption = "Record not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
            else
            {
                Regex rgx = new Regex(@"^\d{9}-\d{4}$"); // match the format of customer Id
                if (rgx.IsMatch(search.UserSearch))
                {
                    customer.Id = search.UserSearch;
                }
                else
                {
                    customer.Name = search.UserSearch;
                }
                    getcustomer = customerService.GetCustomerListData(customer);
                    if (getcustomer.Count == 0)
                    {
                        const string MessageContent = "Double check the entry or contact your I.T personnel for futher details";
                        string MessageCaption = "Record not found";
                        MessageBox.Show(MessageContent, MessageCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            }            
        }
        public List<GetCustomerInfo> GetList()
        {
            return getcustomer;
        }      
    }
}

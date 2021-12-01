using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJp.Service;
using TripleJp.Model;
using TripleJP_Lending_System.View;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Presenter
{
    class GetListCustomerAccountPresenter
    {
        ISearch search;
        CustomerService customerService = new CustomerService();
        Customer customer = new Customer();
        List<GetCustomerList> getcustomer = new List<GetCustomerList>();
        public GetListCustomerAccountPresenter(ISearch search)
        {
            this.search = search;
        }
        internal void CallSearch()
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
                    getcustomer = customerService.GetCustomerData(customer);
                    if (getcustomer.Count == 0)
                    {
                        const string MessageContent = "Double check the entry or contact your I.T personnel for futher details";
                        string MessageCaption = "Record not found";
                        MessageBox.Show(MessageContent, MessageCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            }            
        }
        internal List<GetCustomerList> GetList()
        {
            return getcustomer;
        }

    }
}

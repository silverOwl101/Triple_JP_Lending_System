using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;
using TripleJP_Lending_System.Helper.View;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;

namespace TripleJP_Lending_System.Forms
{
    public partial class EditCustomerFrm : Form, IEditCustomer
    {
        private string[] _loadData;
        private EditCustomerFrmData _editCustomerFrmData;
        private IFormsMediator _concreteMediator;
        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();        
        public EditCustomerFrm()
        {
            InitializeComponent();
            _concreteMediator = new ClassComponentConcreteMediator();
            _editCustomerFrmData = new EditCustomerFrmData(_concreteMediator);
            _loadData = _concreteMediator.GetData(_editCustomerFrmData);            
            LoadCustomerInformation();
        }
        public string ID // To be pass to the presenter
        {
            get { return _loadData[0]; }
            set { _loadData[0] = value; }
        }
        private void LoadCustomerInformation()
        {
            CustomerNametxt.Text = _loadData[1];
            CustomerAddresstxt.Text = _loadData[2];
            ContactNumbertxt.Text = _loadData[3];
            BusinessNametxt.Text = _loadData[4];
            BusinessNaturetxt.Text = _loadData[5];
            BusinessAddresstxt.Text = _loadData[6];
            GrossBusinessCapitaltxt.Text = _loadData[7];
            AverageDailyGrossSalestxt.Text = _loadData[8];
        }
        #region User Inputs        
        public string CustomerName
        {
            get { return CustomerNametxt.Text; }
            set { CustomerNametxt.Text = value; }
        }
        public string CustomerAddress
        {
            get { return CustomerAddresstxt.Text; }
            set { CustomerAddresstxt.Text = value; }
        }
        public string ContactNumber
        {
            get { return ContactNumbertxt.Text; }
            set { ContactNumbertxt.Text = value; }
        }
        public string BusinessName
        {
            get { return BusinessAddresstxt.Text; }
            set { BusinessAddresstxt.Text = value; }
        }
        public string BusinessNature
        {
            get { return BusinessNaturetxt.Text; }
            set { BusinessNaturetxt.Text = value; }
        }
        public string BusinessAddress
        {
            get { return BusinessAddresstxt.Text; }
            set { BusinessAddresstxt.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(GrossBusinessCapitaltxt.Text); }
            set { GrossBusinessCapitaltxt.Text = value.ToString(); }
        }
        public decimal AveDailyGrossSales
        {
            get { return Convert.ToDecimal(AverageDailyGrossSalestxt.Text); }
            set { AverageDailyGrossSalestxt.Text = value.ToString(); }
        }
        #endregion                
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            CustomerEditPresenter editPresenter = new CustomerEditPresenter(this);
            editPresenter.PrepareUpdate();
            Close();
        }
        private void ContactNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersOnly(e);
        }
        private void GrossBusinessCapitaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e);
        }
        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e);
        }
    }
}

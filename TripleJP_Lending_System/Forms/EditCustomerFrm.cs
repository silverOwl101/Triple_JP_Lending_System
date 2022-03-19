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
        #region Fields

        private string[] _loadData;
        private EditCustomerFrmData _editCustomerFrmData;
        private IFormsMediator _concreteMediator;
        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();
        private FrmConvertionRequirements _frmConvertionRequirements = new FrmConvertionRequirements();

        #endregion

        public EditCustomerFrm()
        {
            InitializeComponent();
            _concreteMediator = new ClassComponentConcreteMediator();
            _editCustomerFrmData = new EditCustomerFrmData(_concreteMediator);
            _loadData = _concreteMediator.GetData(_editCustomerFrmData);            
            LoadCustomerInformation();
        }

        #region Custom Methods
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
        private void SubmitButtonDisable()
        {
            Submitbutton.Enabled = false;
        }
        private void IsAllTextBoxNotEmpty()
        {
            int count = 0;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (!string.IsNullOrEmpty(item.Text))
                    {
                        count++;
                    }
                }
            }
            if (count == 8)
            {
                Submitbutton.Enabled = true;
            }
            else
            {
                Submitbutton.Enabled = false;
            }
        }
        #endregion

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

        #region Form Events

        #region Buttons

        #region Submitbutton Events
        private void Submitbutton_Click(object sender, EventArgs e)
        {
            CustomerEditPresenter editPresenter = new CustomerEditPresenter(this);
            editPresenter.PrepareUpdate();
            Close();
        }
        #endregion

        #endregion

        #region TextBox

        #region ContactNumberTxt Events
        private void ContactNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersOnly(e);
            ContactNumbertxt.MaxLength = 14;
        }
        private void ContactNumbertxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }
        private void ContactNumbertxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }
        #endregion

        #region GrossBusinessCapitalTxt Events
        private void GrossBusinessCapitaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, GrossBusinessCapitaltxt);
            GrossBusinessCapitaltxt.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void GrossBusinessCapitaltxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(GrossBusinessCapitaltxt);
            IsAllTextBoxNotEmpty();
        }
        private void GrossBusinessCapitaltxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(GrossBusinessCapitaltxt);
        }
        #endregion

        #region AverageDailyGrossSalesTxt Events
        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, AverageDailyGrossSalestxt);
            AverageDailyGrossSalestxt.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void AverageDailyGrossSalestxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(AverageDailyGrossSalestxt);
            IsAllTextBoxNotEmpty();
        }
        private void AverageDailyGrossSalestxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(AverageDailyGrossSalestxt);
        }
        #endregion

        #region CustomerNameTxt Events
        private void CustomerNametxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }

        private void CustomerNametxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }
        #endregion

        #region CustomerAddressTxt Events
        private void CustomerAddresstxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }

        private void CustomerAddresstxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }
        #endregion

        #region BusinessNameTxt Events
        private void BusinessNametxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }

        private void BusinessNametxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }
        #endregion

        #region BusinessNatureTxt Events
        private void BusinessNaturetxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }

        private void BusinessNaturetxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }
        #endregion

        #region BusinessAddressTxt Events
        private void BusinessAddresstxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }

        private void BusinessAddresstxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }
        #endregion

        #endregion

        #endregion

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class LedgerForm : Form, IGetCollectionAndPenalty
    {

        #region Fields

        private LedgerFormData _ledgerFormData;
        private IFormsMediator _concreteMediator;
        private LedgerPresenter _ledgerPresenter;
        private string _loanID;

        #endregion

        public LedgerForm()
        {

            InitializeComponent();

            _concreteMediator = new ClassComponentConcreteMediator();
            _ledgerFormData = new LedgerFormData(_concreteMediator);

            _loanID = _concreteMediator.GetData(_ledgerFormData)[0]; // get loan ID

        }

        #region User Inputs

        public string LoanID
        {
            get { return _loanID; }
            set { _loanID = value; }
        }

        #endregion

        internal void LoadCollectionandPenalty()
        {

            _ledgerPresenter = new LedgerPresenter(this);

            try
            {

                dataGridView1.DataSource = _ledgerPresenter.GetCollectionAndPenalty();

                if (dataGridView1.DataSource != null)
                {
                    ShowDialog();
                }

            }
            catch (InvalidOperationException ex) when (ex.InnerException is FormatException)
            {
                const string MessageContent = "No records of collection yet";
                const string MessageCaption = "Collection not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                const string MessageCaption = "System Access Denied";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

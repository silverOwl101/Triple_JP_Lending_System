using MySql.Data.MySqlClient;
using System;
using System.IO;
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
            //LoadCollectionandPenalty();
        }

        #region User Inputs

        public string LoanID
        {
            get { return _loanID; }
            set { _loanID = value; }
        }

        #endregion

        #region CustomeMethods

        #region Error Messeges

        private void NoRecordsErrorMessage()
        {
            const string MessageContent = "No records of collection yet";
            const string MessageCaption = "Collection not found";
            MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void ExceptionErrorMessage()
        {
            const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
            const string MessageCaption = "System Access Denied";
            MessageBox.Show(MessageContent, MessageCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        internal bool IsDataSourceEmpty()
        {
            _ledgerPresenter = new LedgerPresenter(this);
            if (_ledgerPresenter.OnLoadGetCollectionAndPenalty().Count != 0)
            {
                return false;
            }
            return true;
        }
        internal void LoadCollectionandPenalty()
        {
            try
            {
                ledgerDataGridView.DataSource = _ledgerPresenter.OnLoadGetCollectionAndPenalty();

                if (IsDataSourceEmpty())
                {
                    NoRecordsErrorMessage();
                }
            }
            catch (InvalidOperationException ex) when (ex.InnerException is FormatException)
            {
                NoRecordsErrorMessage();
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                ExceptionErrorMessage();
            }
            catch (TypeInitializationException ex) when (ex.InnerException is FileNotFoundException)
            {
                const string MessageContent = "Configuration file is missing, please create a config file first.";
                const string MessageCaption = "Configuration lost";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}

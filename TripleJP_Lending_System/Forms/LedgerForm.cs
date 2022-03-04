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
    public partial class LedgerForm : Form,IGetCollectionAndPenalty
    {
        //private DataMediator getMediatedID;
        private LedgerFormData _ledgerFormData;
        private IFormsMediator _concreteMediator;
        private string _loanID;
        public LedgerForm()
        {
            InitializeComponent();

            //getMediatedID = new DataMediator();

            _concreteMediator = new ClassComponentConcreteMediator();
            _ledgerFormData = new LedgerFormData(_concreteMediator);

            _loanID = _concreteMediator.GetData(_ledgerFormData)[0];
        }
        public string LoanID
        {
            get { return _loanID; }
            set { _loanID = value; }
        }
        private void LedgerForm_Load(object sender, EventArgs e)
        {
            LoadCollectionandPenalty();
        }
        private void LoadCollectionandPenalty()
        {
            LedgerPresenter ledgerPresenter = new LedgerPresenter(this);
            dataGridView1.DataSource = ledgerPresenter.GetCollectionAndPenalty();
        }
    }
}

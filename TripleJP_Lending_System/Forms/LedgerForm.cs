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
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class LedgerForm : Form,IGetCollectionAndPenalty
    {
        private DataMediator getMediatedID;
        private string mediatedID;
        public LedgerForm()
        {
            InitializeComponent();
            getMediatedID = new DataMediator();
            mediatedID = getMediatedID.GetMediatedID();
        }
        public string LoanID
        {
            get { return mediatedID; }
            set { mediatedID = value; }
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

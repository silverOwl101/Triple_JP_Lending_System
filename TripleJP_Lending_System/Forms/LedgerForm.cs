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

namespace TripleJP_Lending_System.Forms
{
    public partial class LedgerForm : Form,IGetCollectionAndPenalty
    {        
        public LedgerForm()
        {
            InitializeComponent();            
        }
        public string LoanID
        {
            get { return LoanInformationFrm.getLoanID; }
            set { LoanInformationFrm.getLoanID = value; }
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

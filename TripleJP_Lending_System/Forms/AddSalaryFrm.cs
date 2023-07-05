using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddSalaryFrm : Form
    {
        public AddSalaryFrm()
        {
            InitializeComponent();
            DefaultProperties();
        }
        private void DefaultProperties()
        {
            totalCollectionLabel.Text = "0";
            salaryCalculationLabel.Text = "0";
            savingsCalculationLabel.Text = "0";
        }
    }
}

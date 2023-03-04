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
using TripleJP_Lending_System.Helper.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class CollectionFrm : Form
    {
        private FrmConvertionRequirements _frmConvertionRequirements
                                                    = new FrmConvertionRequirements();
        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();
        private CollectionFrmData _collectionFrmData;
        private ClassComponentConcreteMediator _concreteMediator;
        public CollectionFrm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _collectionFrmData = new CollectionFrmData(_concreteMediator);

            label1.Text = _concreteMediator.GetData(_collectionFrmData)[0];// get id
            label2.Text = _concreteMediator.GetData(_collectionFrmData)[1];// get name
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, textBox1);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(textBox1);            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(textBox1);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class AddCustomerFrmComponent : IComponent
    {
        private AddCustomerFrm _addCustomerFrm;

        public AddCustomerFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public void Open()
        {
            _addCustomerFrm = new AddCustomerFrm();
            _addCustomerFrm.ShowDialog();
        }
    }
}

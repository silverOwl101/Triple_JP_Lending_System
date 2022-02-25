﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class MainApplicationFrmComponent : IInclude
    {
        MainApplicationFrm mainApplicationFrm;

        public MainApplicationFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open(bool sender)
        {
            mainApplicationFrm = new MainApplicationFrm();
            mainApplicationFrm.ShowDialog();
        }
    }
}

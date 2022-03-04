﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LogInFrmComponent : IOpenComponent
    {
        private LogInFrm _logInform;
        public LogInFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _logInform = new LogInFrm();
            _logInform.ShowDialog();
        }
    }
}

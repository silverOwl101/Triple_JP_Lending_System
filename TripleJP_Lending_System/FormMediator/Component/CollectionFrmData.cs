﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class CollectionFrmData : IDataComponent
    {
        public CollectionFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {
            return PostingFrmPassData.customerLoanInformation;
        }
    }
}
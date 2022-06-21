using System;
using TripleJP_Lending_System.FormMediator.Mediator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class PostingFrmComponent : IOpenComponent
    {
        private PostingFrm _postingFrm;
        public PostingFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _postingFrm = new PostingFrm();
            _postingFrm.ShowDialog();
        }
    }
}

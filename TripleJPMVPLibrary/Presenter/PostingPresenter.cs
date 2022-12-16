using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;
using TripleJPMVPLibrary.View;

namespace TripleJPMVPLibrary.Presenter
{    
    public class PostingPresenter
    {
        private IPosting _posting;
        private PostingService postingService;
        private Customer customer = new Customer();

        public PostingPresenter(IPosting posting)
        {
            _posting = posting;
        }

        public List<GetPostingInfo> GetPostingList()
        {            
            customer.Id = _posting.CustomerId;
            postingService = new PostingService();
            return postingService.GetPostingList(customer);
        }
    }
}

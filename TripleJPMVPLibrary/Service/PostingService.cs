using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Repository;

namespace TripleJPMVPLibrary.Service
{
    public class PostingService
    {
        private PostingRepo _postingRepo;
        private List<GetPostingInfo> storeList = new List<GetPostingInfo>();
        public List<GetPostingInfo> GetPostingList(Customer customerId)
        {
            _postingRepo = new PostingRepo();
            storeList = _postingRepo.GetPostingList(customerId);
            return storeList;
        }        
    }
}

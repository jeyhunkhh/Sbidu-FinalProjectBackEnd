using ReflectionIT.Mvc.Paging;
using Sbidu.Models;
using System.Collections.Generic;

namespace Sbidu.ViewModels
{
    public class AuctionViewModel
    {
        public PagingList<AuctionProduct> PagingList { get; internal set; }
        public List<AuctionProduct> AuctionProductsPopular { get; set; }
        public List<Category> Categories { get; set; }
    }
}

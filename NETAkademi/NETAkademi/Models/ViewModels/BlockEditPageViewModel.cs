//using EPiServer.Core;
//using NETAkademi.Models.Pages;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace NETAkademi.Models.ViewModels
//{
//    public class BlockEditPageViewModel :IPageViewModel<SitePageData>
//    {
//        public BlockEditPageViewModel(PageData page, IContent content)
//        {
//            previewBlock = new PreviewBlock(page, content);
//            CurrentPage = page as SitePageData;
//        }
//        public PreviewBlock previewBlock { get; set; }
//        public SitePageData CurrentPage { get; set; }

//        public LayoutModel Layout { get; set; }

//        public IContent Section { get; set; }


//        //Have to implement Search property here also because IPageViewModel and BlockEditPageViewModel 
//        //need to implement the same
//        public string SearchPageActionUrl { get; set; }
//    }
//}
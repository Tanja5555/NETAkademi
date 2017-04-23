using NETAkademi.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Cms.Shell.UI.Rest.ContentQuery;
using EPiServer.Find.UnifiedSearch;

namespace NETAkademi.Models.ViewModels
{
    public class SearchPageViewModel : DefaultPageViewModel<SearchPage>
    {
        public SearchPageViewModel(SearchPage currentPage, string searchQuery) : base(currentPage)
        {
            SearchQuery = searchQuery;
        }

        public string SearchQuery { get; private set; }
        public UnifiedSearchResults Results { get; set; }
    }
}
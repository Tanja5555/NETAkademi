﻿using EPiServer.Core;
using NETAkademi.Business;
using NETAkademi.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETAkademi.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {

        public DefaultPageViewModel(T currentPage)
        {

            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(CurrentPage.ContentLink);
        }

        public T CurrentPage { get; private set; }
        public IContent Section { get; set; }

        public LayoutModel Layout { get; set; }

        public string SearchPageActionUrl { get; set; }
    }

    public static class PageViewModel
    {
        /// <summary>
        /// Returns a DefaultPageViewModel of type <typeparam name="T"/>.
        /// </summary>
        /// <remarks>
        /// Convenience method for creating DefaultPageViewModels without having to 
        /// specify the type as methods can use type inference while constructors cannot.
        /// </remarks>
        public static DefaultPageViewModel<T> Create<T>(T page) where T : SitePageData
        {
            return new DefaultPageViewModel<T>(page);
        }
    }
}
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Microsoft.AspNetCore.Mvc.RazorPages.Internal
{
    public class PageActionInvokerCacheEntry
    {
        public PageActionInvokerCacheEntry(
            CompiledPageActionDescriptor actionDescriptor,
            Func<PageContext, object> pageFactory,
            Action<PageContext, object> pageDisposer,
            Func<PageContext, object> modelFactory,
            Action<PageContext, object> modelDisposer,
            Func<PageContext, IFilterMetadata[]> filterProvider)
        {
            ActionDescriptor = actionDescriptor;
            PageFactory = pageFactory;
            PageDisposer = pageDisposer;
            FilterProvider = filterProvider;
        }

        public CompiledPageActionDescriptor ActionDescriptor { get; }

        public Func<PageContext, object> PageFactory { get; }

        public Action<PageContext, object> PageDisposer { get; }

        public Func<PageContext, object> ModelFactory { get; }

        public Action<PageContext, object> ModelDisposer { get; }

        public Func<PageContext, IFilterMetadata[]> FilterProvider { get; }
    }
}

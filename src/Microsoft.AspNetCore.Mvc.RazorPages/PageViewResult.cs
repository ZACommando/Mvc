// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    public class PageViewResult : IActionResult
    {
        public PageViewResult(Page page)
        {
            Page = page;
        }

        public PageViewResult(Page page, object model)
        {
            Page = page;
            Model = model;
        }

        public string ContentType { get; set; }

        public object Model { get; }

        public Page Page { get; }

        public int? StatusCode { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            if (!object.ReferenceEquals(context, Page.PageContext))
            {
                throw new InvalidOperationException();
            }

            throw new NotImplementedException();
        }
    }
}
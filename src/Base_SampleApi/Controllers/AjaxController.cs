// Copyright © 2017-2019 SOFTINUX. All rights reserved.
// Licensed under the MIT License, Version 2.0. See LICENSE file in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    /// <summary>
    /// Simple MVC controller that returns views.
    /// </summary>
    [Route("[controller]")]
    public class AjaxController : Controller
    {
        /// <summary>
        /// Return a view that performs ajax calls.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}

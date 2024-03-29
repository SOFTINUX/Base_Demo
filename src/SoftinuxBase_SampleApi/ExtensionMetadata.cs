// Copyright © 2017-2019 SOFTINUX. All rights reserved.
// Licensed under the MIT License, Version 2.0. See LICENSE file in the project root for license information.

using System;
using System.Collections.Generic;
using System.Reflection;
using SoftinuxBase.Infrastructure;
using SoftinuxBase.Infrastructure.Interfaces;

namespace SampleApi
{
    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => null;
        public IEnumerable<Script> Scripts => null;
        public IEnumerable<MenuGroup> MenuGroups => new List<MenuGroup>
        {
            new MenuGroup("SampleApi", 100, new List<MenuItem>
            {
                new MenuItem("/api/values", "GET values from API", 1),
                new MenuItem("/ajax", "Test ajax calls", 2)
            })
        };
        public bool IsAvailableForPermissions => true;
        /// <summary>
        /// Gets the current assembly object.
        /// </summary>
        public Assembly CurrentAssembly => Assembly.GetExecutingAssembly();

        /// <summary>
        /// Gets the full path with assembly name.
        /// </summary>
        public string CurrentAssemblyPath => CurrentAssembly.Location;

        /// <summary>
        /// Gets the name of the extension.
        /// </summary>
        public string Name => CurrentAssembly.GetName().Name;

        /// <summary>
        /// Gets the URL of the extension.
        /// </summary>
        public string Url => Attribute.GetCustomAttribute(CurrentAssembly, typeof(AssemblyTitleAttribute)).ToString();

        /// <summary>
        /// Gets the version of the extension.
        /// </summary>
        public string Version => Attribute.GetCustomAttribute(CurrentAssembly, typeof(AssemblyVersionAttribute)).ToString();

        /// <summary>
        /// Gets the authors of the extension (separated by commas).
        /// </summary>
        public string Authors => Attribute.GetCustomAttribute(CurrentAssembly, typeof(AssemblyCompanyAttribute)).ToString();

        /// <summary>
        /// Gets the description of the extension (separated by commas).
        /// </summary>
        public string Description => Attribute.GetCustomAttribute(CurrentAssembly, typeof(AssemblyDescriptionAttribute)).ToString();
    }
}
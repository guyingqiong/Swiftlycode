﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductCatalog.Mvc {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProductCatalog.Mvc.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server error on {0}: Please contact developer..
        /// </summary>
        public static string ERR_SERVER_ERROR {
            get {
                return ResourceManager.GetString("ERR_SERVER_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a New Product.
        /// </summary>
        public static string TXT_CREATE_PRODUCT {
            get {
                return ResourceManager.GetString("TXT_CREATE_PRODUCT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product Catalog.
        /// </summary>
        public static string TXT_PRODUCT_CATALOG {
            get {
                return ResourceManager.GetString("TXT_PRODUCT_CATALOG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Details of Product: {0}.
        /// </summary>
        public static string TXT_PRODUCT_DETAIL {
            get {
                return ResourceManager.GetString("TXT_PRODUCT_DETAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Product: {0}.
        /// </summary>
        public static string TXT_PRODUCT_EDIT {
            get {
                return ResourceManager.GetString("TXT_PRODUCT_EDIT", resourceCulture);
            }
        }
    }
}
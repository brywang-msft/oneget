﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PackageManagement.Providers.Resources {
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PackageManagement.Providers.Internal.Resources.Messages", typeof(Messages).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fail to extract and copy to &apos;{0}&apos;..
        /// </summary>
        internal static string FailedToExtractAndCopy {
            get {
                return ResourceManager.GetString("FailedToExtractAndCopy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finding the package &apos;{0}&apos;..
        /// </summary>
        internal static string FindingPackage {
            get {
                return ResourceManager.GetString("FindingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed the package &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        internal static string InstalledPackage {
            get {
                return ResourceManager.GetString("InstalledPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing the package &apos;{0}&apos;..
        /// </summary>
        internal static string InstallingPackage {
            get {
                return ResourceManager.GetString("InstallingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version is not found for the specified provider &apos;{0}&apos;..
        /// </summary>
        internal static string MissingVersion {
            get {
                return ResourceManager.GetString("MissingVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than 1 dll with provider manifest exists in provider &apos;{0}&apos;..
        /// </summary>
        internal static string MoreThanOneDllExists {
            get {
                return ResourceManager.GetString("MoreThanOneDllExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link &apos;{0}&apos; is not using https..
        /// </summary>
        internal static string OnlyHttpsSchemeSupported {
            get {
                return ResourceManager.GetString("OnlyHttpsSchemeSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to bootstrap the required package provider due to problems with network connectivity. Please fix your network connection. If this is not possible, refer to &apos;Get-Help Install-PackageProvider&apos; or http://go.microsoft.com/fwlink/?LinkId=626941 for guidance on installing the package provider manually..
        /// </summary>
        internal static string ProviderBootstrapFailed {
            get {
                return ResourceManager.GetString("ProviderBootstrapFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot download link &apos;{0}&apos;, retrying for &apos;{1}&apos; more times..
        /// </summary>
        internal static string RetryDownload {
            get {
                return ResourceManager.GetString("RetryDownload", resourceCulture);
            }
        }
    }
}

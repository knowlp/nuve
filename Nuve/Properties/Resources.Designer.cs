﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nuve.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nuve.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to abbrv.txt.
        /// </summary>
        internal static string Abbreviations {
            get {
                return ResourceManager.GetString("Abbreviations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to morphotactics.xml.
        /// </summary>
        internal static string Morphotactics {
            get {
                return ResourceManager.GetString("Morphotactics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to name.txt.
        /// </summary>
        internal static string Names {
            get {
                return ResourceManager.GetString("Names", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to orthography.xml.
        /// </summary>
        internal static string Orthography {
            get {
                return ResourceManager.GetString("Orthography", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ..\..\Nuve\Resources\.
        /// </summary>
        internal static string ResourcesPath {
            get {
                return ResourceManager.GetString("ResourcesPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to root.txt.
        /// </summary>
        internal static string Roots {
            get {
                return ResourceManager.GetString("Roots", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dictionary_tr.xlsx.
        /// </summary>
        internal static string RootsFile {
            get {
                return ResourceManager.GetString("RootsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to probability must be in range [0-1].
        /// </summary>
        internal static string SolutionFrequency_SetProbability_ExceptionMessage {
            get {
                return ResourceManager.GetString("SolutionFrequency_SetProbability_ExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to suffix.txt.
        /// </summary>
        internal static string Suffixes {
            get {
                return ResourceManager.GetString("Suffixes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to suffix_tr.xlsx.
        /// </summary>
        internal static string SuffixFile {
            get {
                return ResourceManager.GetString("SuffixFile", resourceCulture);
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gerador_de_CNPJ.Resources {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Gerador_de_CNPJ.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Criação finalizada!.
        /// </summary>
        internal static string Finished {
            get {
                return ResourceManager.GetString("Finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sem mascara.
        /// </summary>
        internal static string Mask1 {
            get {
                return ResourceManager.GetString("Mask1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Com mascara.
        /// </summary>
        internal static string Mask2 {
            get {
                return ResourceManager.GetString("Mask2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tipo inválido.
        /// </summary>
        internal static string Warning1 {
            get {
                return ResourceManager.GetString("Warning1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modelo inválido.
        /// </summary>
        internal static string Warning2 {
            get {
                return ResourceManager.GetString("Warning2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Você só pode digitar numeros aqui!.
        /// </summary>
        internal static string Warning3 {
            get {
                return ResourceManager.GetString("Warning3", resourceCulture);
            }
        }
    }
}
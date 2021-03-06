﻿// Developer Express Code Central Example:
// How to provide cylindrical equal-area projections of a map
// 
// This example illustrates how to get map equal-area projections (Lambert,
// Behrmann, Tristan Edwards, Peters, Gall orthographic and Balthasart) for the
// shapes loaded from the Shapefiles (Countries.shp, Countries.dbf).
// 
// To
// accomplish this task, create an EqualAreaProjection object and assign it to the
// VectorLayerBase.MapProjection
// (http://documentation.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_MapProjectiontopic)
// property. Then, specify the Width/height aspect ratio for each equal area
// projection using the VectorLayerBase.InitialMapSize
// (http://documentation.devexpress.com/#WPF/DevExpressXpfMapVectorLayerBase_InitialMapSizetopic)
// property. To learn more about the equal-area projections, see Cylindrical
// equal-area projection
// (http://en.wikipedia.org/wiki/Cylindrical_equal-area_projection).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4253

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvoidMapDistortion.Properties {


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
                if ((resourceMan == null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AvoidMapDistortion.Properties.Resources", typeof(Resources).Assembly);
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
    }
}

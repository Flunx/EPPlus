//------------------------------------------------------------------------------
// <copyright file="Color.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace EPPlus.Drawing
{
    using System.Globalization;
    using System.Text;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System;
    using System.ComponentModel;

    /// <devdoc>
    ///    Represents an ARGB color.
    /// </devdoc>
    [
    Serializable(),
    TypeConverter(typeof(ColorConverter)),
    DebuggerDisplay("{NameAndARGBValue}")
    ]
    public struct Color
    {
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static readonly Color Empty = new Color();

        // -------------------------------------------------------------------
        //  static list of "web" colors...
        //
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Transparent
        {
            get
            {
                return new Color(KnownColor.Transparent);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color AliceBlue
        {
            get
            {
                return new Color(KnownColor.AliceBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color AntiqueWhite
        {
            get
            {
                return new Color(KnownColor.AntiqueWhite);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Aqua
        {
            get
            {
                return new Color(KnownColor.Aqua);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Aquamarine
        {
            get
            {
                return new Color(KnownColor.Aquamarine);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Azure
        {
            get
            {
                return new Color(KnownColor.Azure);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Beige
        {
            get
            {
                return new Color(KnownColor.Beige);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Bisque
        {
            get
            {
                return new Color(KnownColor.Bisque);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Black
        {
            get
            {
                return new Color(KnownColor.Black);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color BlanchedAlmond
        {
            get
            {
                return new Color(KnownColor.BlanchedAlmond);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Blue
        {
            get
            {
                return new Color(KnownColor.Blue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color BlueViolet
        {
            get
            {
                return new Color(KnownColor.BlueViolet);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Brown
        {
            get
            {
                return new Color(KnownColor.Brown);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color BurlyWood
        {
            get
            {
                return new Color(KnownColor.BurlyWood);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color CadetBlue
        {
            get
            {
                return new Color(KnownColor.CadetBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Chartreuse
        {
            get
            {
                return new Color(KnownColor.Chartreuse);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Chocolate
        {
            get
            {
                return new Color(KnownColor.Chocolate);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Coral
        {
            get
            {
                return new Color(KnownColor.Coral);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color CornflowerBlue
        {
            get
            {
                return new Color(KnownColor.CornflowerBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Cornsilk
        {
            get
            {
                return new Color(KnownColor.Cornsilk);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Crimson
        {
            get
            {
                return new Color(KnownColor.Crimson);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Cyan
        {
            get
            {
                return new Color(KnownColor.Cyan);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkBlue
        {
            get
            {
                return new Color(KnownColor.DarkBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkCyan
        {
            get
            {
                return new Color(KnownColor.DarkCyan);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkGoldenrod
        {
            get
            {
                return new Color(KnownColor.DarkGoldenrod);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkGray
        {
            get
            {
                return new Color(KnownColor.DarkGray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkGreen
        {
            get
            {
                return new Color(KnownColor.DarkGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkKhaki
        {
            get
            {
                return new Color(KnownColor.DarkKhaki);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkMagenta
        {
            get
            {
                return new Color(KnownColor.DarkMagenta);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkOliveGreen
        {
            get
            {
                return new Color(KnownColor.DarkOliveGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkOrange
        {
            get
            {
                return new Color(KnownColor.DarkOrange);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkOrchid
        {
            get
            {
                return new Color(KnownColor.DarkOrchid);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkRed
        {
            get
            {
                return new Color(KnownColor.DarkRed);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkSalmon
        {
            get
            {
                return new Color(KnownColor.DarkSalmon);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkSeaGreen
        {
            get
            {
                return new Color(KnownColor.DarkSeaGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkSlateBlue
        {
            get
            {
                return new Color(KnownColor.DarkSlateBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkSlateGray
        {
            get
            {
                return new Color(KnownColor.DarkSlateGray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkTurquoise
        {
            get
            {
                return new Color(KnownColor.DarkTurquoise);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DarkViolet
        {
            get
            {
                return new Color(KnownColor.DarkViolet);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DeepPink
        {
            get
            {
                return new Color(KnownColor.DeepPink);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DeepSkyBlue
        {
            get
            {
                return new Color(KnownColor.DeepSkyBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DimGray
        {
            get
            {
                return new Color(KnownColor.DimGray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color DodgerBlue
        {
            get
            {
                return new Color(KnownColor.DodgerBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Firebrick
        {
            get
            {
                return new Color(KnownColor.Firebrick);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color FloralWhite
        {
            get
            {
                return new Color(KnownColor.FloralWhite);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color ForestGreen
        {
            get
            {
                return new Color(KnownColor.ForestGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Fuchsia
        {
            get
            {
                return new Color(KnownColor.Fuchsia);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Gainsboro
        {
            get
            {
                return new Color(KnownColor.Gainsboro);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color GhostWhite
        {
            get
            {
                return new Color(KnownColor.GhostWhite);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Gold
        {
            get
            {
                return new Color(KnownColor.Gold);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Goldenrod
        {
            get
            {
                return new Color(KnownColor.Goldenrod);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Gray
        {
            get
            {
                return new Color(KnownColor.Gray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Green
        {
            get
            {
                return new Color(KnownColor.Green);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color GreenYellow
        {
            get
            {
                return new Color(KnownColor.GreenYellow);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Honeydew
        {
            get
            {
                return new Color(KnownColor.Honeydew);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color HotPink
        {
            get
            {
                return new Color(KnownColor.HotPink);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color IndianRed
        {
            get
            {
                return new Color(KnownColor.IndianRed);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Indigo
        {
            get
            {
                return new Color(KnownColor.Indigo);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Ivory
        {
            get
            {
                return new Color(KnownColor.Ivory);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Khaki
        {
            get
            {
                return new Color(KnownColor.Khaki);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Lavender
        {
            get
            {
                return new Color(KnownColor.Lavender);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LavenderBlush
        {
            get
            {
                return new Color(KnownColor.LavenderBlush);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LawnGreen
        {
            get
            {
                return new Color(KnownColor.LawnGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LemonChiffon
        {
            get
            {
                return new Color(KnownColor.LemonChiffon);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightBlue
        {
            get
            {
                return new Color(KnownColor.LightBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightCoral
        {
            get
            {
                return new Color(KnownColor.LightCoral);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightCyan
        {
            get
            {
                return new Color(KnownColor.LightCyan);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightGoldenrodYellow
        {
            get
            {
                return new Color(KnownColor.LightGoldenrodYellow);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightGreen
        {
            get
            {
                return new Color(KnownColor.LightGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightGray
        {
            get
            {
                return new Color(KnownColor.LightGray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightPink
        {
            get
            {
                return new Color(KnownColor.LightPink);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightSalmon
        {
            get
            {
                return new Color(KnownColor.LightSalmon);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightSeaGreen
        {
            get
            {
                return new Color(KnownColor.LightSeaGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightSkyBlue
        {
            get
            {
                return new Color(KnownColor.LightSkyBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightSlateGray
        {
            get
            {
                return new Color(KnownColor.LightSlateGray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightSteelBlue
        {
            get
            {
                return new Color(KnownColor.LightSteelBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LightYellow
        {
            get
            {
                return new Color(KnownColor.LightYellow);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Lime
        {
            get
            {
                return new Color(KnownColor.Lime);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color LimeGreen
        {
            get
            {
                return new Color(KnownColor.LimeGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Linen
        {
            get
            {
                return new Color(KnownColor.Linen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Magenta
        {
            get
            {
                return new Color(KnownColor.Magenta);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Maroon
        {
            get
            {
                return new Color(KnownColor.Maroon);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumAquamarine
        {
            get
            {
                return new Color(KnownColor.MediumAquamarine);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumBlue
        {
            get
            {
                return new Color(KnownColor.MediumBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumOrchid
        {
            get
            {
                return new Color(KnownColor.MediumOrchid);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumPurple
        {
            get
            {
                return new Color(KnownColor.MediumPurple);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumSeaGreen
        {
            get
            {
                return new Color(KnownColor.MediumSeaGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumSlateBlue
        {
            get
            {
                return new Color(KnownColor.MediumSlateBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumSpringGreen
        {
            get
            {
                return new Color(KnownColor.MediumSpringGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumTurquoise
        {
            get
            {
                return new Color(KnownColor.MediumTurquoise);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MediumVioletRed
        {
            get
            {
                return new Color(KnownColor.MediumVioletRed);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MidnightBlue
        {
            get
            {
                return new Color(KnownColor.MidnightBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MintCream
        {
            get
            {
                return new Color(KnownColor.MintCream);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color MistyRose
        {
            get
            {
                return new Color(KnownColor.MistyRose);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Moccasin
        {
            get
            {
                return new Color(KnownColor.Moccasin);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color NavajoWhite
        {
            get
            {
                return new Color(KnownColor.NavajoWhite);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Navy
        {
            get
            {
                return new Color(KnownColor.Navy);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color OldLace
        {
            get
            {
                return new Color(KnownColor.OldLace);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Olive
        {
            get
            {
                return new Color(KnownColor.Olive);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color OliveDrab
        {
            get
            {
                return new Color(KnownColor.OliveDrab);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Orange
        {
            get
            {
                return new Color(KnownColor.Orange);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color OrangeRed
        {
            get
            {
                return new Color(KnownColor.OrangeRed);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Orchid
        {
            get
            {
                return new Color(KnownColor.Orchid);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PaleGoldenrod
        {
            get
            {
                return new Color(KnownColor.PaleGoldenrod);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PaleGreen
        {
            get
            {
                return new Color(KnownColor.PaleGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PaleTurquoise
        {
            get
            {
                return new Color(KnownColor.PaleTurquoise);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PaleVioletRed
        {
            get
            {
                return new Color(KnownColor.PaleVioletRed);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PapayaWhip
        {
            get
            {
                return new Color(KnownColor.PapayaWhip);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PeachPuff
        {
            get
            {
                return new Color(KnownColor.PeachPuff);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Peru
        {
            get
            {
                return new Color(KnownColor.Peru);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Pink
        {
            get
            {
                return new Color(KnownColor.Pink);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Plum
        {
            get
            {
                return new Color(KnownColor.Plum);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color PowderBlue
        {
            get
            {
                return new Color(KnownColor.PowderBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Purple
        {
            get
            {
                return new Color(KnownColor.Purple);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Red
        {
            get
            {
                return new Color(KnownColor.Red);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color RosyBrown
        {
            get
            {
                return new Color(KnownColor.RosyBrown);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color RoyalBlue
        {
            get
            {
                return new Color(KnownColor.RoyalBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SaddleBrown
        {
            get
            {
                return new Color(KnownColor.SaddleBrown);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Salmon
        {
            get
            {
                return new Color(KnownColor.Salmon);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SandyBrown
        {
            get
            {
                return new Color(KnownColor.SandyBrown);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SeaGreen
        {
            get
            {
                return new Color(KnownColor.SeaGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SeaShell
        {
            get
            {
                return new Color(KnownColor.SeaShell);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Sienna
        {
            get
            {
                return new Color(KnownColor.Sienna);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Silver
        {
            get
            {
                return new Color(KnownColor.Silver);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SkyBlue
        {
            get
            {
                return new Color(KnownColor.SkyBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SlateBlue
        {
            get
            {
                return new Color(KnownColor.SlateBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SlateGray
        {
            get
            {
                return new Color(KnownColor.SlateGray);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Snow
        {
            get
            {
                return new Color(KnownColor.Snow);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SpringGreen
        {
            get
            {
                return new Color(KnownColor.SpringGreen);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color SteelBlue
        {
            get
            {
                return new Color(KnownColor.SteelBlue);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Tan
        {
            get
            {
                return new Color(KnownColor.Tan);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Teal
        {
            get
            {
                return new Color(KnownColor.Teal);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Thistle
        {
            get
            {
                return new Color(KnownColor.Thistle);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Tomato
        {
            get
            {
                return new Color(KnownColor.Tomato);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Turquoise
        {
            get
            {
                return new Color(KnownColor.Turquoise);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Violet
        {
            get
            {
                return new Color(KnownColor.Violet);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Wheat
        {
            get
            {
                return new Color(KnownColor.Wheat);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color White
        {
            get
            {
                return new Color(KnownColor.White);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color WhiteSmoke
        {
            get
            {
                return new Color(KnownColor.WhiteSmoke);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color Yellow
        {
            get
            {
                return new Color(KnownColor.Yellow);
            }
        }
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public static Color YellowGreen
        {
            get
            {
                return new Color(KnownColor.YellowGreen);
            }
        }
        //
        //  end "web" colors
        // -------------------------------------------------------------------

        // NOTE : The "zero" pattern (all members being 0) must represent
        //      : "not set". This allows "Color c;" to be correct.

        private static short StateKnownColorValid = 0x0001;
        private static short StateARGBValueValid = 0x0002;
        private static short StateValueMask = (short)(StateARGBValueValid);
        private static short StateNameValid = 0x0008;
        private static long NotDefinedValue = 0;

        /**
         * Shift count and bit mask for A, R, G, B components in ARGB mode!
         */
        private const int ARGBAlphaShift = 24;
        private const int ARGBRedShift = 16;
        private const int ARGBGreenShift = 8;
        private const int ARGBBlueShift = 0;

        ///    WARNING!!! WARNING!!! WARNING!!! WARNING!!! 
        ///    WARNING!!! WARNING!!! WARNING!!! WARNING!!!
        ///    We can never change the layout of this class (adding or removing or changing the 
        ///    order of member variables) if you want to be compatible v1.0 version of the runtime.
        ///    This is so that we can push into the runtime a custom marshaller for OLE_COLOR to Color.

        // user supplied name of color. Will not be filled in if
        // we map to a "knowncolor"
        //
        private readonly string name;

        // will contain standard 32bit sRGB (ARGB)
        //
        private readonly long value;

        // ignored, unless "state" says it is valid
        //
        private readonly short knownColor;

        // implementation specific information
        //
        private readonly short state;


        internal Color(KnownColor knownColor)
        {
            value = 0;
            state = StateKnownColorValid;
            name = null;
            this.knownColor = unchecked((short)knownColor);
        }

        private Color(long value, short state, string name, KnownColor knownColor)
        {
            this.value = value;
            this.state = state;
            this.name = name;
            this.knownColor = unchecked((short)knownColor);
        }

        /// <devdoc>
        ///    Gets the red component value for this <see cref='Color'/>.
        /// </devdoc>
        public byte R
        {
            get
            {
                return (byte)((Value >> ARGBRedShift) & 0xFF);
            }
        }

        /// <devdoc>
        ///    Gets the green component value for this <see cref='Color'/>.
        /// </devdoc>
        public byte G
        {
            get
            {
                return (byte)((Value >> ARGBGreenShift) & 0xFF);
            }
        }

        /// <devdoc>
        ///    <para>
        ///       Gets the blue component value for this <see cref='Color'/>.
        ///    </para>
        /// </devdoc>
        public byte B
        {
            get
            {
                return (byte)((Value >> ARGBBlueShift) & 0xFF);
            }
        }

        /// <devdoc>
        ///    <para>
        ///       Gets the alpha component value for this <see cref='Color'/>.
        ///    </para>
        /// </devdoc>
        public byte A
        {
            get
            {
                return (byte)((Value >> ARGBAlphaShift) & 0xFF);
            }
        }

        /// <devdoc>
        ///    <para>
        ///       Specifies whether this <see cref='Color'/> is a known (predefined) color.
        ///       Predefined colors are defined in the <see cref='EPPlus.Drawing.KnownColor'/>
        ///       enum.
        ///    </para>
        /// </devdoc>
        public bool IsKnownColor
        {
            get
            {
                return ((state & StateKnownColorValid) != 0);
            }
        }

        /// <devdoc>
        ///    Specifies whether this <see cref='Color'/> is uninitialized.
        /// </devdoc>
        public bool IsEmpty
        {
            get
            {
                return state == 0;
            }
        }

        /// <devdoc>
        ///    Specifies whether this <see cref='Color'/> has a name or is a <see cref='EPPlus.Drawing.KnownColor'/>.
        /// </devdoc>
        public bool IsNamedColor
        {
            get
            {
                return ((state & StateNameValid) != 0) || IsKnownColor;
            }
        }

        /// <devdoc>
        ///     Determines if this color is a system color.
        /// </devdoc>
        public bool IsSystemColor
        {
            get
            {
                return IsKnownColor && ((((KnownColor)knownColor) <= KnownColor.WindowText) || (((KnownColor)knownColor) > KnownColor.YellowGreen));
            }
        }

        // Not localized because it's only used for the DebuggerDisplayAttribute, and the values are
        // programmatic items.
        // Also, don't inline into the attribute for performance reasons.  This way means the debugger
        // does 1 func-eval instead of 5.
        [SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters")]
        private string NameAndARGBValue
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
                                     "{{Name={0}, ARGB=({1}, {2}, {3}, {4})}}",
                                              Name, A, R, G, B);
            }
        }

        /// <devdoc>
        ///    <para>
        ///       Gets the name of this <see cref='Color'/> . This will either return the user
        ///       defined name of the color, if the color was created from a name, or
        ///       the name of the known color. For custom colors, the RGB value will
        ///       be returned.
        ///    </para>
        /// </devdoc>
        public string Name
        {
            get
            {
                if ((state & StateNameValid) != 0)
                {
                    return name;
                }

                if (IsKnownColor)
                {
                    // first try the table so we can avoid the (slow!) .ToString()
                    string tablename = KnownColorTable.KnownColorToName((KnownColor)knownColor);
                    if (tablename != null)
                        return tablename;

                    Debug.Assert(false, "Could not find known color '" + ((KnownColor)knownColor) + "' in the KnownColorTable");

                    return ((KnownColor)knownColor).ToString();
                }

                // if we reached here, just encode the value
                //
                return Convert.ToString(value, 16);
            }
        }

        /// <devdoc>
        ///     Actual color to be rendered.
        /// </devdoc>
        private long Value
        {
            get
            {
                if ((state & StateValueMask) != 0)
                {
                    return value;
                }
                if (IsKnownColor)
                {
                    return unchecked((int)KnownColorTable.KnownColorToArgb((KnownColor)knownColor));
                }

                return NotDefinedValue;
            }
        }

        private static void CheckByte(int value, string name)
        {
            if (value < 0 || value > 255)
                throw new ArgumentException("Argument is out of bounds");
            //throw new ArgumentException(SR.GetString(SR.InvalidEx2BoundArgument, name, value, 0, 255));
        }

        /// <devdoc>
        ///     Encodes the four values into ARGB (32 bit) format.
        /// </devdoc>
        private static long MakeArgb(byte alpha, byte red, byte green, byte blue)
        {
            return (long)(unchecked((uint)(red << ARGBRedShift |
                         green << ARGBGreenShift |
                         blue << ARGBBlueShift |
                         alpha << ARGBAlphaShift))) & 0xffffffff;
        }

        /// <devdoc>
        ///    <para>
        ///       Creates a Color from its 32-bit component
        ///       (alpha, red, green, and blue) values.
        ///    </para>
        /// </devdoc>
        public static Color FromArgb(int argb)
        {
            return new Color((long)argb & 0xffffffff, StateARGBValueValid, null, (KnownColor)0);
        }

        /// <devdoc>
        ///    <para>
        ///       Creates a Color from its 32-bit component (alpha, red,
        ///       green, and blue) values.
        ///    </para>
        /// </devdoc>
        public static Color FromArgb(int alpha, int red, int green, int blue)
        {
            CheckByte(alpha, "alpha");
            CheckByte(red, "red");
            CheckByte(green, "green");
            CheckByte(blue, "blue");
            return new Color(MakeArgb((byte)alpha, (byte)red, (byte)green, (byte)blue), StateARGBValueValid, null, (KnownColor)0);
        }

        /// <devdoc>
        ///    <para>
        ///       Creates a new <see cref='Color'/> from the specified <see cref='Color'/>, but with
        ///       the new specified alpha value.
        ///    </para>
        /// </devdoc>
        public static Color FromArgb(int alpha, Color baseColor)
        {
            CheckByte(alpha, "alpha");
            // unchecked - because we already checked that alpha is a byte in CheckByte above
            return new Color(MakeArgb(unchecked((byte)alpha), baseColor.R, baseColor.G, baseColor.B), StateARGBValueValid, null, (KnownColor)0);
        }

        /// <devdoc>
        ///    <para>
        ///       Creates a <see cref='Color'/> from the specified red, green, and
        ///       blue values.
        ///    </para>
        /// </devdoc>
        public static Color FromArgb(int red, int green, int blue)
        {
            return FromArgb(255, red, green, blue);
        }

        /// <devdoc>
        ///    <para>
        ///       Creates a <see cref='Color'/> from the specified <see cref='EPPlus.Drawing.KnownColor'/> .
        ///    </para>
        /// </devdoc>
        public static Color FromKnownColor(KnownColor color)
        {
            if (!IsEnumValid(color, unchecked((int)color), (int)KnownColor.ActiveBorder, (int)KnownColor.MenuHighlight))
            {
                return Color.FromName(color.ToString());
            }
            return new Color(color);
        }

        public static bool IsEnumValid(Enum enumValue, int value, int minValue, int maxValue)
        {
            return (value >= minValue) && (value <= maxValue);
        }

        /// <devdoc>
        ///    <para>
        ///       Creates a <see cref='Color'/> with the specified name.
        ///    </para>
        /// </devdoc>
        public static Color FromName(string name)
        {
            // try to get a known color first
            object color = ColorConverter.GetNamedColor(name);
            if (color != null)
            {
                return (Color)color;
            }
            // otherwise treat it as a named color
            return new Color(NotDefinedValue, StateNameValid, name, (KnownColor)0);
        }

        /// <devdoc>
        ///    <para>
        ///       Returns the Hue-Saturation-Brightness (HSB) brightness
        ///       for this <see cref='Color'/> .
        ///    </para>
        /// </devdoc>
        public float GetBrightness()
        {
            float r = (float)R / 255.0f;
            float g = (float)G / 255.0f;
            float b = (float)B / 255.0f;

            float max, min;

            max = r; min = r;

            if (g > max) max = g;
            if (b > max) max = b;

            if (g < min) min = g;
            if (b < min) min = b;

            return (max + min) / 2;
        }


        /// <devdoc>
        ///    <para>
        ///       Returns the Hue-Saturation-Brightness (HSB) hue
        ///       value, in degrees, for this <see cref='Color'/> .  
        ///       If R == G == B, the hue is meaningless, and the return value is 0.
        ///    </para>
        /// </devdoc>
        public Single GetHue()
        {
            if (R == G && G == B)
                return 0; // 0 makes as good an UNDEFINED value as any

            float r = (float)R / 255.0f;
            float g = (float)G / 255.0f;
            float b = (float)B / 255.0f;

            float max, min;
            float delta;
            float hue = 0.0f;

            max = r; min = r;

            if (g > max) max = g;
            if (b > max) max = b;

            if (g < min) min = g;
            if (b < min) min = b;

            delta = max - min;

            if (r == max)
            {
                hue = (g - b) / delta;
            }
            else if (g == max)
            {
                hue = 2 + (b - r) / delta;
            }
            else if (b == max)
            {
                hue = 4 + (r - g) / delta;
            }
            hue *= 60;

            if (hue < 0.0f)
            {
                hue += 360.0f;
            }
            return hue;
        }

        /// <devdoc>
        ///    <para>
        ///       The Hue-Saturation-Brightness (HSB) saturation for this
        ///    <see cref='Color'/>
        ///    .
        /// </para>
        /// </devdoc>
        public float GetSaturation()
        {
            float r = (float)R / 255.0f;
            float g = (float)G / 255.0f;
            float b = (float)B / 255.0f;

            float max, min;
            float l, s = 0;

            max = r; min = r;

            if (g > max) max = g;
            if (b > max) max = b;

            if (g < min) min = g;
            if (b < min) min = b;

            // if max == min, then there is no color and
            // the saturation is zero.
            //
            if (max != min)
            {
                l = (max + min) / 2;

                if (l <= .5)
                {
                    s = (max - min) / (max + min);
                }
                else
                {
                    s = (max - min) / (2 - max - min);
                }
            }
            return s;
        }

        /// <devdoc>
        ///    <para>
        ///       Returns the ARGB value of this <see cref='Color'/> .
        ///    </para>
        /// </devdoc>
        public int ToArgb()
        {
            return unchecked((int)Value);
        }

        /// <devdoc>
        ///    <para>
        ///       Returns the <see cref='EPPlus.Drawing.KnownColor'/> value for this color, if it is
        ///       based on a <see cref='EPPlus.Drawing.KnownColor'/> .
        ///    </para>
        /// </devdoc>
        public KnownColor ToKnownColor()
        {
            return (KnownColor)knownColor;
        }

        /// <devdoc>
        ///    Converts this <see cref='Color'/> to a human-readable
        ///    string.
        /// </devdoc>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(32);
            sb.Append(GetType().Name);
            sb.Append(" [");

            if ((state & StateNameValid) != 0)
            {
                sb.Append(Name);
            }
            else if ((state & StateKnownColorValid) != 0)
            {
                sb.Append(Name);
            }
            else if ((state & StateValueMask) != 0)
            {
                sb.Append("A=");
                sb.Append(A);
                sb.Append(", R=");
                sb.Append(R);
                sb.Append(", G=");
                sb.Append(G);
                sb.Append(", B=");
                sb.Append(B);
            }
            else
            {
                sb.Append("Empty");
            }


            sb.Append("]");

            return sb.ToString();
        }

        /// <devdoc>
        ///    <para>
        ///       Tests whether two specified <see cref='Color'/> objects
        ///       are equivalent.
        ///    </para>
        /// </devdoc>
        public static bool operator ==(Color left, Color right)
        {
            if (left.value == right.value
                && left.state == right.state
                && left.knownColor == right.knownColor)
            {

                if (left.name == right.name)
                {
                    return true;
                }

                if (left.name == (object)null || right.name == (object)null)
                {
                    return false;
                }

                return left.name.Equals(right.name);
            }

            return false;
        }

        /// <devdoc>
        ///    <para>
        ///       Tests whether two specified <see cref='Color'/> objects
        ///       are equivalent.
        ///    </para>
        /// </devdoc>
        public static bool operator !=(Color left, Color right)
        {
            return !(left == right);
        }

        /// <devdoc>
        ///    Tests whether the specified object is a
        /// <see cref='Color'/> 
        /// and is equivalent to this <see cref='Color'/>.
        /// </devdoc>
        public override bool Equals(object obj)
        {
            if (obj is Color)
            {
                Color right = (Color)obj;
                if (value == right.value
                    && state == right.state
                    && knownColor == right.knownColor)
                {

                    if (name == right.name)
                    {
                        return true;
                    }

                    if (name == (object)null || right.name == (object)null)
                    {
                        return false;
                    }

                    return name.Equals(name);
                }
            }
            return false;
        }

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public override int GetHashCode()
        {
            return unchecked(value.GetHashCode() ^
                    state.GetHashCode() ^
                    knownColor.GetHashCode());
        }
    }
}
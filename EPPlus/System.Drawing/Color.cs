using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Drawing
{
    //------------------------------------------------------------------------------
    // <copyright file="Color.cs" company="Microsoft">
    //     Copyright (c) Microsoft Corporation.  All rights reserved.
    // </copyright>                                                                
    //------------------------------------------------------------------------------

    ///    Represents an ARGB color.
    [Serializable]
    public struct Color
    {
        public static readonly Color Empty = new Color();

        // -------------------------------------------------------------------
        //  static list of "web" colors...
        //


        public static Color Transparent
        {
            get
            {
                return new Color(KnownColor.Transparent);
            }
        }

        public static Color AliceBlue
        {
            get
            {
                return new Color(KnownColor.AliceBlue);
            }
        }
        public static Color AntiqueWhite
        {
            get
            {
                return new Color(KnownColor.AntiqueWhite);
            }
        }
        public static Color Aqua
        {
            get
            {
                return new Color(KnownColor.Aqua);
            }
        }
        public static Color Aquamarine
        {
            get
            {
                return new Color(KnownColor.Aquamarine);
            }
        }

        public static Color Azure
        {
            get
            {
                return new Color(KnownColor.Azure);
            }
        }

        public static Color Beige
        {
            get
            {
                return new Color(KnownColor.Beige);
            }
        }

        public static Color Bisque
        {
            get
            {
                return new Color(KnownColor.Bisque);
            }
        }

        public static Color Black
        {
            get
            {
                return new Color(KnownColor.Black);
            }
        }

        public static Color BlanchedAlmond
        {
            get
            {
                return new Color(KnownColor.BlanchedAlmond);
            }
        }

        public static Color Blue
        {
            get
            {
                return new Color(KnownColor.Blue);
            }
        }

        public static Color BlueViolet
        {
            get
            {
                return new Color(KnownColor.BlueViolet);
            }
        }

        public static Color Brown
        {
            get
            {
                return new Color(KnownColor.Brown);
            }
        }

        public static Color BurlyWood
        {
            get
            {
                return new Color(KnownColor.BurlyWood);
            }
        }

        public static Color CadetBlue
        {
            get
            {
                return new Color(KnownColor.CadetBlue);
            }
        }

        public static Color Chartreuse
        {
            get
            {
                return new Color(KnownColor.Chartreuse);
            }
        }

        public static Color Chocolate
        {
            get
            {
                return new Color(KnownColor.Chocolate);
            }
        }

        public static Color Coral
        {
            get
            {
                return new Color(KnownColor.Coral);
            }
        }

        public static Color CornflowerBlue
        {
            get
            {
                return new Color(KnownColor.CornflowerBlue);
            }
        }

        public static Color Cornsilk
        {
            get
            {
                return new Color(KnownColor.Cornsilk);
            }
        }

        public static Color Crimson
        {
            get
            {
                return new Color(KnownColor.Crimson);
            }
        }

        public static Color Cyan
        {
            get
            {
                return new Color(KnownColor.Cyan);
            }
        }

        public static Color DarkBlue
        {
            get
            {
                return new Color(KnownColor.DarkBlue);
            }
        }

        public static Color DarkCyan
        {
            get
            {
                return new Color(KnownColor.DarkCyan);
            }
        }

        public static Color DarkGoldenrod
        {
            get
            {
                return new Color(KnownColor.DarkGoldenrod);
            }
        }

        public static Color DarkGray
        {
            get
            {
                return new Color(KnownColor.DarkGray);
            }
        }

        public static Color DarkGreen
        {
            get
            {
                return new Color(KnownColor.DarkGreen);
            }
        }

        public static Color DarkKhaki
        {
            get
            {
                return new Color(KnownColor.DarkKhaki);
            }
        }

        public static Color DarkMagenta
        {
            get
            {
                return new Color(KnownColor.DarkMagenta);
            }
        }

        public static Color DarkOliveGreen
        {
            get
            {
                return new Color(KnownColor.DarkOliveGreen);
            }
        }

        public static Color DarkOrange
        {
            get
            {
                return new Color(KnownColor.DarkOrange);
            }
        }

        public static Color DarkOrchid
        {
            get
            {
                return new Color(KnownColor.DarkOrchid);
            }
        }

        public static Color DarkRed
        {
            get
            {
                return new Color(KnownColor.DarkRed);
            }
        }

        public static Color DarkSalmon
        {
            get
            {
                return new Color(KnownColor.DarkSalmon);
            }
        }

        public static Color DarkSeaGreen
        {
            get
            {
                return new Color(KnownColor.DarkSeaGreen);
            }
        }

        public static Color DarkSlateBlue
        {
            get
            {
                return new Color(KnownColor.DarkSlateBlue);
            }
        }

        public static Color DarkSlateGray
        {
            get
            {
                return new Color(KnownColor.DarkSlateGray);
            }
        }

        public static Color DarkTurquoise
        {
            get
            {
                return new Color(KnownColor.DarkTurquoise);
            }
        }

        public static Color DarkViolet
        {
            get
            {
                return new Color(KnownColor.DarkViolet);
            }
        }
        public static Color DeepPink
        {
            get
            {
                return new Color(KnownColor.DeepPink);
            }
        }
        public static Color DeepSkyBlue
        {
            get
            {
                return new Color(KnownColor.DeepSkyBlue);
            }
        }
        public static Color DimGray
        {
            get
            {
                return new Color(KnownColor.DimGray);
            }
        }
        public static Color DodgerBlue
        {
            get
            {
                return new Color(KnownColor.DodgerBlue);
            }
        }
        public static Color Firebrick
        {
            get
            {
                return new Color(KnownColor.Firebrick);
            }
        }
        public static Color FloralWhite
        {
            get
            {
                return new Color(KnownColor.FloralWhite);
            }
        }
        public static Color ForestGreen
        {
            get
            {
                return new Color(KnownColor.ForestGreen);
            }
        }
        public static Color Fuchsia
        {
            get
            {
                return new Color(KnownColor.Fuchsia);
            }
        }
        public static Color Gainsboro
        {
            get
            {
                return new Color(KnownColor.Gainsboro);
            }
        }
        public static Color GhostWhite
        {
            get
            {
                return new Color(KnownColor.GhostWhite);
            }
        }
        public static Color Gold
        {
            get
            {
                return new Color(KnownColor.Gold);
            }
        }
        public static Color Goldenrod
        {
            get
            {
                return new Color(KnownColor.Goldenrod);
            }
        }
        public static Color Gray
        {
            get
            {
                return new Color(KnownColor.Gray);
            }
        }
        public static Color Green
        {
            get
            {
                return new Color(KnownColor.Green);
            }
        }
        public static Color GreenYellow
        {
            get
            {
                return new Color(KnownColor.GreenYellow);
            }
        }
        public static Color Honeydew
        {
            get
            {
                return new Color(KnownColor.Honeydew);
            }
        }
        public static Color HotPink
        {
            get
            {
                return new Color(KnownColor.HotPink);
            }
        }
        public static Color IndianRed
        {
            get
            {
                return new Color(KnownColor.IndianRed);
            }
        }
        public static Color Indigo
        {
            get
            {
                return new Color(KnownColor.Indigo);
            }
        }
        public static Color Ivory
        {
            get
            {
                return new Color(KnownColor.Ivory);
            }
        }
        public static Color Khaki
        {
            get
            {
                return new Color(KnownColor.Khaki);
            }
        }
        public static Color Lavender
        {
            get
            {
                return new Color(KnownColor.Lavender);
            }
        }
        public static Color LavenderBlush
        {
            get
            {
                return new Color(KnownColor.LavenderBlush);
            }
        }
        public static Color LawnGreen
        {
            get
            {
                return new Color(KnownColor.LawnGreen);
            }
        }
        public static Color LemonChiffon
        {
            get
            {
                return new Color(KnownColor.LemonChiffon);
            }
        }
        public static Color LightBlue
        {
            get
            {
                return new Color(KnownColor.LightBlue);
            }
        }
        public static Color LightCoral
        {
            get
            {
                return new Color(KnownColor.LightCoral);
            }
        }
        public static Color LightCyan
        {
            get
            {
                return new Color(KnownColor.LightCyan);
            }
        }
        public static Color LightGoldenrodYellow
        {
            get
            {
                return new Color(KnownColor.LightGoldenrodYellow);
            }
        }
        public static Color LightGreen
        {
            get
            {
                return new Color(KnownColor.LightGreen);
            }
        }
        public static Color LightGray
        {
            get
            {
                return new Color(KnownColor.LightGray);
            }
        }
        public static Color LightPink
        {
            get
            {
                return new Color(KnownColor.LightPink);
            }
        }
        public static Color LightSalmon
        {
            get
            {
                return new Color(KnownColor.LightSalmon);
            }
        }
        public static Color LightSeaGreen
        {
            get
            {
                return new Color(KnownColor.LightSeaGreen);
            }
        }
        public static Color LightSkyBlue
        {
            get
            {
                return new Color(KnownColor.LightSkyBlue);
            }
        }
        public static Color LightSlateGray
        {
            get
            {
                return new Color(KnownColor.LightSlateGray);
            }
        }
        public static Color LightSteelBlue
        {
            get
            {
                return new Color(KnownColor.LightSteelBlue);
            }
        }
        public static Color LightYellow
        {
            get
            {
                return new Color(KnownColor.LightYellow);
            }
        }
        public static Color Lime
        {
            get
            {
                return new Color(KnownColor.Lime);
            }
        }
        public static Color LimeGreen
        {
            get
            {
                return new Color(KnownColor.LimeGreen);
            }
        }
        public static Color Linen
        {
            get
            {
                return new Color(KnownColor.Linen);
            }
        }
        public static Color Magenta
        {
            get
            {
                return new Color(KnownColor.Magenta);
            }
        }
        public static Color Maroon
        {
            get
            {
                return new Color(KnownColor.Maroon);
            }
        }
        public static Color MediumAquamarine
        {
            get
            {
                return new Color(KnownColor.MediumAquamarine);
            }
        }
        public static Color MediumBlue
        {
            get
            {
                return new Color(KnownColor.MediumBlue);
            }
        }
        public static Color MediumOrchid
        {
            get
            {
                return new Color(KnownColor.MediumOrchid);
            }
        }
        public static Color MediumPurple
        {
            get
            {
                return new Color(KnownColor.MediumPurple);
            }
        }
        public static Color MediumSeaGreen
        {
            get
            {
                return new Color(KnownColor.MediumSeaGreen);
            }
        }
        public static Color MediumSlateBlue
        {
            get
            {
                return new Color(KnownColor.MediumSlateBlue);
            }
        }
        public static Color MediumSpringGreen
        {
            get
            {
                return new Color(KnownColor.MediumSpringGreen);
            }
        }
        public static Color MediumTurquoise
        {
            get
            {
                return new Color(KnownColor.MediumTurquoise);
            }
        }
        public static Color MediumVioletRed
        {
            get
            {
                return new Color(KnownColor.MediumVioletRed);
            }
        }
        public static Color MidnightBlue
        {
            get
            {
                return new Color(KnownColor.MidnightBlue);
            }
        }
        public static Color MintCream
        {
            get
            {
                return new Color(KnownColor.MintCream);
            }
        }
        public static Color MistyRose
        {
            get
            {
                return new Color(KnownColor.MistyRose);
            }
        }
        public static Color Moccasin
        {
            get
            {
                return new Color(KnownColor.Moccasin);
            }
        }
        public static Color NavajoWhite
        {
            get
            {
                return new Color(KnownColor.NavajoWhite);
            }
        }
        public static Color Navy
        {
            get
            {
                return new Color(KnownColor.Navy);
            }
        }
        public static Color OldLace
        {
            get
            {
                return new Color(KnownColor.OldLace);
            }
        }
        public static Color Olive
        {
            get
            {
                return new Color(KnownColor.Olive);
            }
        }
        public static Color OliveDrab
        {
            get
            {
                return new Color(KnownColor.OliveDrab);
            }
        }
        public static Color Orange
        {
            get
            {
                return new Color(KnownColor.Orange);
            }
        }
        public static Color OrangeRed
        {
            get
            {
                return new Color(KnownColor.OrangeRed);
            }
        }
        public static Color Orchid
        {
            get
            {
                return new Color(KnownColor.Orchid);
            }
        }
        public static Color PaleGoldenrod
        {
            get
            {
                return new Color(KnownColor.PaleGoldenrod);
            }
        }
        public static Color PaleGreen
        {
            get
            {
                return new Color(KnownColor.PaleGreen);
            }
        }
        public static Color PaleTurquoise
        {
            get
            {
                return new Color(KnownColor.PaleTurquoise);
            }
        }
        public static Color PaleVioletRed
        {
            get
            {
                return new Color(KnownColor.PaleVioletRed);
            }
        }
        public static Color PapayaWhip
        {
            get
            {
                return new Color(KnownColor.PapayaWhip);
            }
        }
        public static Color PeachPuff
        {
            get
            {
                return new Color(KnownColor.PeachPuff);
            }
        }
        public static Color Peru
        {
            get
            {
                return new Color(KnownColor.Peru);
            }
        }
        public static Color Pink
        {
            get
            {
                return new Color(KnownColor.Pink);
            }
        }
        public static Color Plum
        {
            get
            {
                return new Color(KnownColor.Plum);
            }
        }
        public static Color PowderBlue
        {
            get
            {
                return new Color(KnownColor.PowderBlue);
            }
        }
        public static Color Purple
        {
            get
            {
                return new Color(KnownColor.Purple);
            }
        }
        public static Color Red
        {
            get
            {
                return new Color(KnownColor.Red);
            }
        }
        public static Color RosyBrown
        {
            get
            {
                return new Color(KnownColor.RosyBrown);
            }
        }
        public static Color RoyalBlue
        {
            get
            {
                return new Color(KnownColor.RoyalBlue);
            }
        }
        public static Color SaddleBrown
        {
            get
            {
                return new Color(KnownColor.SaddleBrown);
            }
        }
        public static Color Salmon
        {
            get
            {
                return new Color(KnownColor.Salmon);
            }
        }
        public static Color SandyBrown
        {
            get
            {
                return new Color(KnownColor.SandyBrown);
            }
        }
        public static Color SeaGreen
        {
            get
            {
                return new Color(KnownColor.SeaGreen);
            }
        }
        public static Color SeaShell
        {
            get
            {
                return new Color(KnownColor.SeaShell);
            }
        }
        public static Color Sienna
        {
            get
            {
                return new Color(KnownColor.Sienna);
            }
        }
        public static Color Silver
        {
            get
            {
                return new Color(KnownColor.Silver);
            }
        }
        public static Color SkyBlue
        {
            get
            {
                return new Color(KnownColor.SkyBlue);
            }
        }
        public static Color SlateBlue
        {
            get
            {
                return new Color(KnownColor.SlateBlue);
            }
        }
        public static Color SlateGray
        {
            get
            {
                return new Color(KnownColor.SlateGray);
            }
        }
        public static Color Snow
        {
            get
            {
                return new Color(KnownColor.Snow);
            }
        }
        public static Color SpringGreen
        {
            get
            {
                return new Color(KnownColor.SpringGreen);
            }
        }
        public static Color SteelBlue
        {
            get
            {
                return new Color(KnownColor.SteelBlue);
            }
        }

        public static Color Tan
        {
            get
            {
                return new Color(KnownColor.Tan);
            }
        }

        public static Color Teal
        {
            get
            {
                return new Color(KnownColor.Teal);
            }
        }

        public static Color Thistle
        {
            get
            {
                return new Color(KnownColor.Thistle);
            }
        }

        public static Color Tomato
        {
            get
            {
                return new Color(KnownColor.Tomato);
            }
        }
        public static Color Turquoise
        {
            get
            {
                return new Color(KnownColor.Turquoise);
            }
        }
        public static Color Violet
        {
            get
            {
                return new Color(KnownColor.Violet);
            }
        }
        public static Color Wheat
        {
            get
            {
                return new Color(KnownColor.Wheat);
            }
        }
        public static Color White
        {
            get
            {
                return new Color(KnownColor.White);
            }
        }
        public static Color WhiteSmoke
        {
            get
            {
                return new Color(KnownColor.WhiteSmoke);
            }
        }
        public static Color Yellow
        {
            get
            {
                return new Color(KnownColor.Yellow);
            }
        }
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

        ///    Gets the red component value for this <see cref='EPPlus.Color'/>.
        public byte R
        {
            get
            {
                return (byte)((Value >> ARGBRedShift) & 0xFF);
            }
        }

        ///    Gets the green component value for this <see cref='EPPlus.Color'/>.
        public byte G
        {
            get
            {
                return (byte)((Value >> ARGBGreenShift) & 0xFF);
            }
        }

        ///       Gets the blue component value for this <see cref='EPPlus.Color'/>.
        ///    </para>
        public byte B
        {
            get
            {
                return (byte)((Value >> ARGBBlueShift) & 0xFF);
            }
        }

        ///       Gets the alpha component value for this <see cref='EPPlus.Color'/>.
        ///    </para>
        public byte A
        {
            get
            {
                return (byte)((Value >> ARGBAlphaShift) & 0xFF);
            }
        }

        ///       Specifies whether this <see cref='EPPlus.Color'/> is a known (predefined) color.
        ///       Predefined colors are defined in the <see cref='EPPlus.KnownColor'/>
        ///       enum.
        ///    </para>
        public bool IsKnownColor
        {
            get
            {
                return ((state & StateKnownColorValid) != 0);
            }
        }

        ///    Specifies whether this <see cref='EPPlus.Color'/> is uninitialized.
        public bool IsEmpty
        {
            get
            {
                return state == 0;
            }
        }

        ///    Specifies whether this <see cref='EPPlus.Color'/> has a name or is a <see cref='EPPlus.KnownColor'/>.
        public bool IsNamedColor
        {
            get
            {
                return ((state & StateNameValid) != 0) || IsKnownColor;
            }
        }

        ///     Determines if this color is a system color.
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
        private string NameAndARGBValue
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
                                     "{{Name={0}, ARGB=({1}, {2}, {3}, {4})}}",
                                              Name, A, R, G, B);
            }
        }

        ///       Gets the name of this <see cref='EPPlus.Color'/> . This will either return the user
        ///       defined name of the color, if the color was created from a name, or
        ///       the name of the known color. For custom colors, the RGB value will
        ///       be returned.
        ///    </para>
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

        ///     Actual color to be rendered.
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
                throw new ArgumentException("Value is out of bounds");//SR.GetString(SR.InvalidEx2BoundArgument, name, value, 0, 255));
        }

        ///     Encodes the four values into ARGB (32 bit) format.
        private static long MakeArgb(byte alpha, byte red, byte green, byte blue)
        {
            return (long)(unchecked((uint)(red << ARGBRedShift |
                         green << ARGBGreenShift |
                         blue << ARGBBlueShift |
                         alpha << ARGBAlphaShift))) & 0xffffffff;
        }

        ///       Creates a Color from its 32-bit component
        ///       (alpha, red, green, and blue) values.
        ///    </para>
        public static Color FromArgb(int argb)
        {
            return new Color((long)argb & 0xffffffff, StateARGBValueValid, null, (KnownColor)0);
        }

        ///       Creates a Color from its 32-bit component (alpha, red,
        ///       green, and blue) values.
        ///    </para>
        public static Color FromArgb(int alpha, int red, int green, int blue)
        {
            CheckByte(alpha, "alpha");
            CheckByte(red, "red");
            CheckByte(green, "green");
            CheckByte(blue, "blue");
            return new Color(MakeArgb((byte)alpha, (byte)red, (byte)green, (byte)blue), StateARGBValueValid, null, (KnownColor)0);
        }

        ///       Creates a new <see cref='EPPlus.Color'/> from the specified <see cref='EPPlus.Color'/>, but with
        ///       the new specified alpha value.
        ///    </para>
        public static Color FromArgb(int alpha, Color baseColor)
        {
            CheckByte(alpha, "alpha");
            // unchecked - because we already checked that alpha is a byte in CheckByte above
            return new Color(MakeArgb(unchecked((byte)alpha), baseColor.R, baseColor.G, baseColor.B), StateARGBValueValid, null, (KnownColor)0);
        }

        ///       Creates a <see cref='EPPlus.Color'/> from the specified red, green, and
        ///       blue values.
        ///    </para>
        public static Color FromArgb(int red, int green, int blue)
        {
            return FromArgb(255, red, green, blue);
        }

        ///       Creates a <see cref='EPPlus.Color'/> from the specified <see cref='EPPlus.KnownColor'/> .
        ///    </para>
        public static Color FromKnownColor(KnownColor color)
        {
            if (!IsEnumValid(color, unchecked((int)color), (int)KnownColor.ActiveBorder, (int)KnownColor.MenuHighlight))
            {
                return Color.FromName(color.ToString());
            }
            return new Color(color);
        }

        private static bool IsEnumValid(Enum enumValue, int value, int minValue, int maxValue)
        {
            return (value >= minValue) && (value <= maxValue);
        }

        ///       Creates a <see cref='EPPlus.Color'/> with the specified name.
        ///    </para>
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

        ///       Returns the Hue-Saturation-Brightness (HSB) brightness
        ///       for this <see cref='EPPlus.Color'/> .
        ///    </para>
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

        ///       Returns the Hue-Saturation-Brightness (HSB) hue
        ///       value, in degrees, for this <see cref='EPPlus.Color'/> .  
        ///       If R == G == B, the hue is meaningless, and the return value is 0.
        ///    </para>
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

        ///       The Hue-Saturation-Brightness (HSB) saturation for this
        ///    <see cref='EPPlus.Color'/>
        ///    .
        /// </para>
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

        ///       Returns the ARGB value of this <see cref='EPPlus.Color'/> .
        ///    </para>
        public int ToArgb()
        {
            return unchecked((int)Value);
        }

        ///       Returns the <see cref='EPPlus.KnownColor'/> value for this color, if it is
        ///       based on a <see cref='EPPlus.KnownColor'/> .
        ///    </para>
        public KnownColor ToKnownColor()
        {
            return (KnownColor)knownColor;
        }

        ///    Converts this <see cref='EPPlus.Color'/> to a human-readable
        ///    string.
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

        ///       Tests whether two specified <see cref='EPPlus.Color'/> objects
        ///       are equivalent.
        ///    </para>
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

        ///       Tests whether two specified <see cref='EPPlus.Color'/> objects
        ///       are equivalent.
        ///    </para>
        public static bool operator !=(Color left, Color right)
        {
            return !(left == right);
        }

        ///    Tests whether the specified object is a
        /// <see cref='EPPlus.Color'/> 
        /// and is equivalent to this <see cref='EPPlus.Color'/>.
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

        public override int GetHashCode()
        {
            return unchecked(value.GetHashCode() ^
                    state.GetHashCode() ^
                    knownColor.GetHashCode());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models.ChartJs
{
    /// <summary>
    /// Yönlere ihtiyacım olduğunda bu sınıfı kullanacağım.
    /// </summary>
    public static class Position
    {
        public static string Top = "top";
        public static string Bottom = "bottom";
        public static string Right = "right";
        public static string Left = "left";
    }

    public static class ChartType
    {
        public static string Bar = "bar";
        public static string Bubble = "bubble";
        public static string Doughnut = "doughnut";
        public static string Line = "line";
        public static string Pie = "pie";
        public static string PolarArea = "polarArea";
        public static string Radar = "radar";
        public static string Scatter = "scatter";
    }

	public static class BackgroundColor
	{
		public static string aliceblue = "rgba(240, 248, 255)";
		public static string antiquewhite = "rgba(250, 235, 215)";
		public static string aqua = "rgba(0, 255, 255)";
		public static string aquamarine = "rgba(127, 255, 212)";
		public static string azure = "rgba(240, 255, 255)";
		public static string beige = "rgba(245, 245, 220)";
		public static string bisque = "rgba(255, 228, 196)";
		public static string black = "rgba(0, 0, 0)";
		public static string blanchedalmond = "rgba(255, 235, 205)";
		public static string blue = "rgba(0, 0, 255)";
		public static string blueviolet = "rgba(138, 43, 226)";
		public static string brown = "rgba(165, 42, 42)";
		public static string burlywood = "rgba(222, 184, 135)";
		public static string cadetblue = "rgba(95, 158, 160)";
		public static string chartreuse = "rgba(127, 255, 0)";
		public static string chocolate = "rgba(210, 105, 30)";
		public static string coral = "rgba(255, 127, 80)";
		public static string cornflowerblue = "rgba(100, 149, 237)";
		public static string cornsilk = "rgba(255, 248, 220)";
		public static string crimson = "rgba(220, 20, 60)";
		public static string cyan = "rgba(0, 255, 255)";
		public static string darkblue = "rgba(0, 0, 139)";
		public static string darkcyan = "rgba(0, 139, 139)";
		public static string darkgoldenrod = "rgba(184, 134, 11)";
		public static string darkgray = "rgba(169, 169, 169)";
		public static string darkgreen = "rgba(0, 100, 0)";
		public static string darkgrey = "rgba(169, 169, 169)";
		public static string darkkhaki = "rgba(189, 183, 107)";
		public static string darkmagenta = "rgba(139, 0, 139)";
		public static string darkolivegreen = "rgba(85, 107, 47)";
		public static string darkorange = "rgba(255, 140, 0)";
		public static string darkorchid = "rgba(153, 50, 204)";
		public static string darkred = "rgba(139, 0, 0)";
		public static string darksalmon = "rgba(233, 150, 122)";
		public static string darkseagreen = "rgba(143, 188, 143)";
		public static string darkslateblue = "rgba(72, 61, 139)";
		public static string darkslategray = "rgba(47, 79, 79)";
		public static string darkslategrey = "rgba(47, 79, 79)";
		public static string darkturquoise = "rgba(0, 206, 209)";
		public static string darkviolet = "rgba(148, 0, 211)";
		public static string deeppink = "rgba(255, 20, 147)";
		public static string deepskyblue = "rgba(0, 191, 255)";
		public static string dimgray = "rgba(105, 105, 105)";
		public static string dimgrey = "rgba(105, 105, 105)";
		public static string dodgerblue = "rgba(30, 144, 255)";
		public static string firebrick = "rgba(178, 34, 34)";
		public static string floralwhite = "rgba(255, 250, 240)";
		public static string forestgreen = "rgba(34, 139, 34)";
		public static string fuchsia = "rgba(255, 0, 255)";
		public static string gainsboro = "rgba(220, 220, 220)";
		public static string ghostwhite = "rgba(248, 248, 255)";
		public static string gold = "rgba(255, 215, 0)";
		public static string goldenrod = "rgba(218, 165, 32)";
		public static string gray = "rgba(128, 128, 128)";
		public static string green = "rgba(0, 128, 0)";
		public static string greenyellow = "rgba(173, 255, 47)";
		public static string grey = "rgba(128, 128, 128)";
		public static string honeydew = "rgba(240, 255, 240)";
		public static string hotpink = "rgba(255, 105, 180)";
		public static string indianred = "rgba(205, 92, 92)";
		public static string indigo = "rgba(75, 0, 130)";
		public static string ivory = "rgba(255, 255, 240)";
		public static string khaki = "rgba(240, 230, 140)";
		public static string lavender = "rgba(230, 230, 250)";
		public static string lavenderblush = "rgba(255, 240, 245)";
		public static string lawngreen = "rgba(124, 252, 0)";
		public static string lemonchiffon = "rgba(255, 250, 205)";
		public static string lightblue = "rgba(173, 216, 230)";
		public static string lightcoral = "rgba(240, 128, 128)";
		public static string lightcyan = "rgba(224, 255, 255)";
		public static string lightgoldenrodyellow = "rgba(250, 250, 210)";
		public static string lightgray = "rgba(211, 211, 211)";
		public static string lightgreen = "rgba(144, 238, 144)";
		public static string lightgrey = "rgba(211, 211, 211)";
		public static string lightpink = "rgba(255, 182, 193)";
		public static string lightsalmon = "rgba(255, 160, 122)";
		public static string lightseagreen = "rgba(32, 178, 170)";
		public static string lightskyblue = "rgba(135, 206, 250)";
		public static string lightslategray = "rgba(119, 136, 153)";
		public static string lightslategrey = "rgba(119, 136, 153)";
		public static string lightsteelblue = "rgba(176, 196, 222)";
		public static string lightyellow = "rgba(255, 255, 224)";
		public static string lime = "rgba(0, 255, 0)";
		public static string limegreen = "rgba(50, 205, 50)";
		public static string linen = "rgba(250, 240, 230)";
		public static string magenta = "rgba(255, 0, 255)";
		public static string maroon = "rgba(128, 0, 0)";
		public static string mediumaquamarine = "rgba(102, 205, 170)";
		public static string mediumblue = "rgba(0, 0, 205)";
		public static string mediumorchid = "rgba(186, 85, 211)";
		public static string mediumpurple = "rgba(147, 112, 219)";
		public static string mediumseagreen = "rgba(60, 179, 113)";
		public static string mediumslateblue = "rgba(123, 104, 238)";
		public static string mediumspringgreen = "rgba(0, 250, 154)";
		public static string mediumturquoise = "rgba(72, 209, 204)";
		public static string mediumvioletred = "rgba(199, 21, 133)";
		public static string midnightblue = "rgba(25, 25, 112)";
		public static string mintcream = "rgba(245, 255, 250)";
		public static string mistyrose = "rgba(255, 228, 225)";
		public static string moccasin = "rgba(255, 228, 181)";
		public static string navajowhite = "rgba(255, 222, 173)";
		public static string navy = "rgba(0, 0, 128)";
		public static string oldlace = "rgba(253, 245, 230)";
		public static string olive = "rgba(128, 128, 0)";
		public static string olivedrab = "rgba(107, 142, 35)";
		public static string orange = "rgba(255, 165, 0)";
		public static string orangered = "rgba(255, 69, 0)";
		public static string orchid = "rgba(218, 112, 214)";
		public static string palegoldenrod = "rgba(238, 232, 170)";
		public static string palegreen = "rgba(152, 251, 152)";
		public static string paleturquoise = "rgba(175, 238, 238)";
		public static string palevioletred = "rgba(219, 112, 147)";
		public static string papayawhip = "rgba(255, 239, 213)";
		public static string peachpuff = "rgba(255, 218, 185)";
		public static string peru = "rgba(205, 133, 63)";
		public static string pink = "rgba(255, 192, 203)";
		public static string plum = "rgba(221, 160, 221)";
		public static string powderblue = "rgba(176, 224, 230)";
		public static string purple = "rgba(128, 0, 128)";
		public static string rebeccapurple = "rgba(102, 51, 153)";
		public static string red = "rgba(255, 0, 0)";
		public static string rosybrown = "rgba(188, 143, 143)";
		public static string royalblue = "rgba(65, 105, 225)";
		public static string saddlebrown = "rgba(139, 69, 19)";
		public static string salmon = "rgba(250, 128, 114)";
		public static string sandybrown = "rgba(244, 164, 96)";
		public static string seagreen = "rgba(46, 139, 87)";
		public static string seashell = "rgba(255, 245, 238)";
		public static string sienna = "rgba(160, 82, 45)";
		public static string silver = "rgba(192, 192, 192)";
		public static string skyblue = "rgba(135, 206, 235)";
		public static string slateblue = "rgba(106, 90, 205)";
		public static string slategray = "rgba(112, 128, 144)";
		public static string slategrey = "rgba(112, 128, 144)";
		public static string snow = "rgba(255, 250, 250)";
		public static string springgreen = "rgba(0, 255, 127)";
		public static string steelblue = "rgba(70, 130, 180)";
		public static string tan = "rgba(210, 180, 140)";
		public static string teal = "rgba(0, 128, 128)";
		public static string thistle = "rgba(216, 191, 216)";
		public static string tomato = "rgba(255, 99, 71)";
		public static string turquoise = "rgba(64, 224, 208)";
		public static string violet = "rgba(238, 130, 238)";
		public static string wheat = "rgba(245, 222, 179)";
		public static string white = "rgba(255, 255, 255)";
		public static string whitesmoke = "rgba(245, 245, 245)";
		public static string yellow = "rgba(255, 255, 0)";
		public static string yellowgreen = "rgba(154, 205, 50)";
	}

    public class GraphicInit
    {
        /// <summary>
        /// Grafik Tipini Belirtmeye yarar.  ChartType static classını kullan.
        /// </summary>
        public string ChartType { get; set; }

        /// <summary>
        /// Title null ise, Grafikte başlık gösterilmez.
        /// </summary>
        public string Title { get; set; } //Title null ise, Kullanıcı başlık göstermek istemiyor.

        /// <summary>
        /// Title'ın nerede görüntüleneceğini ayarlamaya yarar. Position classını kullan
        /// </summary>
        public string LegendPositon { get; set; }

        /// <summary>
        /// Renk Dizisi
        /// </summary>
        public List<string> BackgroundColorList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class Chart
    {
        public List<string> Labels { get; set; }
        public List<string> Data { get; set; }
        public string Title { get; set; }
        public Color Color { get; set; }
        public List<string> ColorList { get; set; }//Pie ve Doughnut için
    }

    public class Color
    {
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
    }
}

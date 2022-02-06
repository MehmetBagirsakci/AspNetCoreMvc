using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MvcWebUI.ViewComponents
{
    public class ChartjsLineChartViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke(Chart chart)
        {
            var color = RandomColor();
            chart.Color = color;
            return View(chart);
        }

        private Color RandomColor()
        {
            List<Color> colors = new List<Color>
            {
                new Color{ BackgroundColor="rgba(255, 99, 132, 0.2)", BorderColor="rgba(255, 99, 132, 1)"},
                new Color{ BackgroundColor="rgba(54, 162, 235, 0.2)", BorderColor="rgba(54, 162, 235, 1)"},
                new Color{ BackgroundColor="rgba(255, 206, 86, 0.2)", BorderColor="rgba(255, 206, 86, 1)"},
                new Color{ BackgroundColor="rgba(75, 192, 192, 0.2)", BorderColor="rgba(75, 192, 192, 1)"},
                new Color{ BackgroundColor="rgba(153, 102, 255, 0.2)", BorderColor="rgba(153, 102, 255, 1)"},
                new Color{ BackgroundColor="rgba(255, 159, 64, 0.2)", BorderColor="rgba(255, 159, 64, 1)"}
            };
            Random random = new Random();
            int index = random.Next(colors.Count - 1);
            return colors[index];
        }
    }
}

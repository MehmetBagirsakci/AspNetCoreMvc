using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models.ChartJs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ViewComponents
{
    public class ChartjsAdvancedViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke(GraphicInit graphic)
        {
            string chartType;
            if (graphic.ChartType == null)
            {
                chartType = "line";
            }
            else
            {
                chartType = graphic.ChartType;
            }
            //-----------------
            Title title = new Title();
            if (graphic.Title != null)
            {
                title.display = true;
                title.text = graphic.Title;
            }
            else
            {
                title.display = false;
                title.text = graphic.Title;
            }
            //--------------------
            Legend legend = new Legend();
            if(graphic.LegendPositon==null)
            {
                legend.position = "top";
            }
            else
            {
                legend.position = graphic.LegendPositon;
            }
            //-------------------- Arka plan renk

            if(graphic.BackgroundColorList==null || graphic.BackgroundColorList.Count == 0)
            {
                graphic.BackgroundColorList = new List<string>();
                graphic.BackgroundColorList.Add(BackgroundColor.red);
            }
        
            string[] labelsArray = new string[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            Dataset[] datasetsArray = new Dataset[]
            {
                new Dataset
                {
                    label="Veri Kümesi",
                    borderColor=graphic.BackgroundColorList.ToArray(),
                    backgroundColor=graphic.BackgroundColorList.ToArray(),
                    data=new string[] { "15", "25", "30", "20", "11", "8", "23", "32", "25", "5", "41", "34" }
                }
            };
            Data data = new Data
            {
                labels = labelsArray,
                datasets = datasetsArray
            };
            //-------------------------------------------


            Options options = new Options
            {
                responsive = true,
                plugins = new Plugins { title = title, legend = legend }
            };
            //----------------

            Chartjs chartjs = new Chartjs
            {
                type = chartType,
                data = data,
                options = options
            };

            var result = JsonConvert.SerializeObject(chartjs);
         
            return View(new BurayaOzelModel { ChartJson = result });
        }

    }

    public class BurayaOzelModel
    {
        public string ChartJson { get; set; }
    }
}

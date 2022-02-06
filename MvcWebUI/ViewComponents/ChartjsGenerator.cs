using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ViewComponents
{
    //Bir ChartJs 3 bölümden oluşur.
    //1-type: 'pie', Grafiğin tipi burada belirtilir
    //2-data: data, Grafiğin verisi burada belirtilir
    //3-options: grafik ile ilgili ayarlar burada yapılır.
    public class Chartjs
    {
        public string type { get; set; }
        public Data data { get; set; }
        public Options options { get; set; }
    }
    public class Data
    {
        public string[] labels { get; set; }
        public Dataset[] datasets { get; set; }
    }

    public class Options
    {
        public bool responsive { get; set; }
        public Plugins plugins { get; set; }
    }
    //-------------------Yardımcı Classlar Buradan başlıyor
    public class Dataset
    {
        public string label { get; set; }
        public string[] data { get; set; }
        public string[] backgroundColor { get; set; }
        public string[] borderColor { get; set; }
    }
    public class Plugins
    {
        public Legend legend { get; set; }
        public Title title { get; set; }
    }
    public class Legend
    {
        public string position { get; set; }
    }
    public class Title
    {
        public bool display { get; set; }
        public string text { get; set; }
    }

}

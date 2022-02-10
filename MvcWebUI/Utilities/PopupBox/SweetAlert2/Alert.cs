using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Utilities.PopupBox.SweetAlert2
{
    public class Alert
    {
        public string icon { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string confirmButtonText { get; set; } = "Tamam";
        public string confirmButtonColor { get; set; }
        public int timer { get; set; }

    }
}

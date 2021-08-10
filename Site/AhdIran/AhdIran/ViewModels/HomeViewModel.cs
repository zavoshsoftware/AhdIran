using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace ViewModels
{
    public class HomeViewModel : _BaseViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Slider> Sliders { get; set; }
        public string Sec2Col1 { get; set; }
        public string Sec2Col2 { get; set; }
        public string Sec2Col3 { get; set; }
        public List<TextItem> Features { get; set; }
        public List<TextItem> Process { get; set; }
        public List<TextItem> Values { get; set; }
        public string ServiceText { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Telegram { get; set; }

    }
}
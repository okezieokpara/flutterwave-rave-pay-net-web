using System;
using System.Collections.Generic;


namespace FlutterWave.RavePay.Web.Models
{
    public class CardPayModel
    {
        public string CardNumber { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string CVV { get; set; }
        public string Pin { get; set; }
    }
}

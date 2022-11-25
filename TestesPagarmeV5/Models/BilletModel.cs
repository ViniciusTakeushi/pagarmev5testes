using System;
using System.Collections.Generic;

namespace TestesPagarmeV5.Models
{
    public class BilletModelAddress
    {
        public string line_1 { get; set; }
        public string line_2 { get; set; }
        public string zip_code { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }

    public class BilletModelBoleto
    {
        public string instructions { get; set; }
        public DateTime due_at { get; set; }
        public string document_number { get; set; }
        public string type { get; set; }
    }

    public class BilletModelCustomer
    {
        public string name { get; set; }
        public string email { get; set; }
        public string document_type { get; set; }
        public string document { get; set; }
        public string type { get; set; }
        public BilletModelAddress address { get; set; }
        public BilletModelPhones phones { get; set; }
    }

    public class BilletModelItem
    {
        public string code { get; set; }
        public int amount { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
    }

    public class BilletModelMobilePhone
    {
        public string country_code { get; set; }
        public string area_code { get; set; }
        public string number { get; set; }
    }

    public class BilletModelPayment
    {
        public string payment_method { get; set; }
        public BilletModelBoleto boleto { get; set; }
    }

    public class BilletModelPhones
    {
        public BilletModelMobilePhone mobile_phone { get; set; }
    }

    public class BilletModel
    {
        public string code { get; set; }
        public List<BilletModelItem> items { get; set; }
        public BilletModelCustomer customer { get; set; }
        public List<BilletModelPayment> payments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestesPagarmeV5.Models
{
    public class BilletResultModelAddress
    {
        public string id { get; set; }
        public string line_1 { get; set; }
        public string line_2 { get; set; }
        public string zip_code { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class BilletResultModelCharge
    {
        public string id { get; set; }
        public string code { get; set; }
        public string gateway_id { get; set; }
        public int amount { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public string payment_method { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public BilletResultModelCustomer customer { get; set; }
        public BilletResultModelLastTransaction last_transaction { get; set; }
    }

    public class BilletResultModelCustomer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string document { get; set; }
        public string document_type { get; set; }
        public string type { get; set; }
        public bool delinquent { get; set; }
        public BilletResultModelAddress address { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public BilletResultModelPhones phones { get; set; }
    }

    public class BilletResultModelGatewayResponse
    {
        public string code { get; set; }
    }

    public class BilletResultModelItem
    {
        public string id { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public int amount { get; set; }
        public int quantity { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string code { get; set; }
    }

    public class BilletResultModelLastTransaction
    {
        public string id { get; set; }
        public string transaction_type { get; set; }
        public string gateway_id { get; set; }
        public int amount { get; set; }
        public string status { get; set; }
        public bool success { get; set; }
        public string url { get; set; }
        public string pdf { get; set; }
        public string line { get; set; }
        public string barcode { get; set; }
        public string qr_code { get; set; }
        public string nosso_numero { get; set; }
        public string type { get; set; }
        public string bank { get; set; }
        public string document_number { get; set; }
        public string instructions { get; set; }
        public DateTime due_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public BilletResultModelGatewayResponse gateway_response { get; set; }
    }

    public class BilletResultModelMobilePhone
    {
        public string country_code { get; set; }
        public string number { get; set; }
        public string area_code { get; set; }
    }

    public class BilletResultModelPhones
    {
        public BilletResultModelMobilePhone mobile_phone { get; set; }
    }

    public class BilletResultModel
    {
        public string id { get; set; }
        public string code { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public bool closed { get; set; }
        public List<BilletResultModelItem> items { get; set; }
        public BilletResultModelCustomer customer { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime closed_at { get; set; }
        public List<BilletResultModelCharge> charges { get; set; }
        public List<object> checkouts { get; set; }
    }
}

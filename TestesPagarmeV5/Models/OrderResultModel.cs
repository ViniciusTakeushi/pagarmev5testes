using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesPagarmeV5.Models
{
    public class Address
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

    public class AntifraudResponse
    {
    }

    public class Charge
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
        public Customer customer { get; set; }
        public LastTransaction last_transaction { get; set; }
    }

    public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string document { get; set; }
        public string document_type { get; set; }
        public string type { get; set; }
        public bool delinquent { get; set; }
        public Address address { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Phones phones { get; set; }
    }

    public class GatewayResponse
    {
        public string code { get; set; }
    }

    public class Item
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

    public class LastTransaction
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
        public GatewayResponse gateway_response { get; set; }
        public AntifraudResponse antifraud_response { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
    }

    public class MobilePhone
    {
        public string country_code { get; set; }
        public string number { get; set; }
        public string area_code { get; set; }
    }

    public class Phones
    {
        public MobilePhone mobile_phone { get; set; }
    }

    public class OrderResultModel
    {
        public string id { get; set; }
        public string code { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public bool closed { get; set; }
        public List<Item> items { get; set; }
        public Customer customer { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime closed_at { get; set; }
        public List<Charge> charges { get; set; }
        public List<object> checkouts { get; set; }
    }
}

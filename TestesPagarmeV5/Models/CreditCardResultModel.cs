using System;
using System.Collections.Generic;

namespace TestesPagarmeV5.Models
{
    public class CreditCardResultModelAddress
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

    public class CreditCardResultModelAntifraudResponse
    {
        public string status { get; set; }
        public string score { get; set; }
        public string provider_name { get; set; }
    }

    public class CreditCardResultModelBillingAddress
    {
        public string zip_code { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string line_1 { get; set; }
    }

    public class CreditCardResultModelCard
    {
        public string id { get; set; }
        public string first_six_digits { get; set; }
        public string last_four_digits { get; set; }
        public string brand { get; set; }
        public string holder_name { get; set; }
        public int exp_month { get; set; }
        public int exp_year { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public CreditCardResultModelBillingAddress billing_address { get; set; }
    }

    public class CreditCardResultModelCharge
    {
        public string id { get; set; }
        public string code { get; set; }
        public string gateway_id { get; set; }
        public int amount { get; set; }
        public int paid_amount { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public string payment_method { get; set; }
        public DateTime paid_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public CreditCardResultModelCustomer customer { get; set; }
        public CreditCardResultModelLastTransaction last_transaction { get; set; }
    }

    public class CreditCardResultModelCustomer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string document { get; set; }
        public string document_type { get; set; }
        public string type { get; set; }
        public bool delinquent { get; set; }
        public CreditCardResultModelAddress address { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public CreditCardResultModelPhones phones { get; set; }
    }

    public class CreditCardResultModelGatewayResponse
    {
        public string code { get; set; }
        public List<object> errors { get; set; }
    }

    public class CreditCardResultModelItem
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

    public class CreditCardResultModelLastTransaction
    {
        public string id { get; set; }
        public string transaction_type { get; set; }
        public string gateway_id { get; set; }
        public int amount { get; set; }
        public string status { get; set; }
        public bool success { get; set; }
        public int installments { get; set; }
        public string statement_descriptor { get; set; }
        public string acquirer_name { get; set; }
        public string acquirer_tid { get; set; }
        public string acquirer_nsu { get; set; }
        public string acquirer_auth_code { get; set; }
        public string acquirer_message { get; set; }
        public string acquirer_return_code { get; set; }
        public string operation_type { get; set; }
        public CreditCardResultModelCard card { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public CreditCardResultModelGatewayResponse gateway_response { get; set; }
        public CreditCardResultModelAntifraudResponse antifraud_response { get; set; }
    }

    public class CreditCardResultModelMobilePhone
    {
        public string country_code { get; set; }
        public string number { get; set; }
        public string area_code { get; set; }
    }

    public class CreditCardResultModelPhones
    {
        public CreditCardResultModelMobilePhone mobile_phone { get; set; }
    }

    public class CreditCardResultModel
    {
        public string id { get; set; }
        public string code { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public bool closed { get; set; }
        public List<CreditCardResultModelItem> items { get; set; }
        public CreditCardResultModelCustomer customer { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime closed_at { get; set; }
        public List<CreditCardResultModelCharge> charges { get; set; }
    }
}

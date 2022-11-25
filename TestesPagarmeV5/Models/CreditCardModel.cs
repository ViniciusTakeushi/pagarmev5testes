using System.Collections.Generic;

namespace TestesPagarmeV5.Models
{
    public class CreditCardModelAddress
    {
        public string line_1 { get; set; }
        public string line_2 { get; set; }
        public string zip_code { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }

    public class CreditCardModelBillingAddress
    {
        public string line_1 { get; set; }
        public string zip_code { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }

    public class CreditCardModelCard
    {
        public string number { get; set; }
        public string holder_name { get; set; }
        public int exp_month { get; set; }
        public int exp_year { get; set; }
        public string cvv { get; set; }
        public CreditCardModelBillingAddress billing_address { get; set; }
    }

    public class CreditCardModelCreditCard
    {
        public bool recurrence { get; set; }
        public int installments { get; set; }
        public string statement_descriptor { get; set; }
        public CreditCardModelCard card { get; set; }
    }

    public class CreditCardModelCustomer
    {
        public string name { get; set; }
        public string email { get; set; }
        public string document_type { get; set; }
        public string document { get; set; }
        public string type { get; set; }
        public CreditCardModelAddress address { get; set; }
        public CreditCardModelPhones phones { get; set; }
    }

    public class CreditCardModelItem
    {
        public string code { get; set; }
        public int amount { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
    }

    public class CreditCardModelMobilePhone
    {
        public string country_code { get; set; }
        public string area_code { get; set; }
        public string number { get; set; }
    }

    public class CreditCardModelPayment
    {
        public string payment_method { get; set; }
        public CreditCardModelCreditCard credit_card { get; set; }
    }

    public class CreditCardModelPhones
    {
        public CreditCardModelMobilePhone mobile_phone { get; set; }
    }

    public class CreditCardModel
    {
        public string code { get; set; }
        public List<CreditCardModelItem> items { get; set; }
        public CreditCardModelCustomer customer { get; set; }
        public List<CreditCardModelPayment> payments { get; set; }
    }
}

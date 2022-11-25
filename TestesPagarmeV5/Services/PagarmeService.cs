using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TestesPagarmeV5.Models;

namespace TestesPagarmeV5.Services
{
    public class PagarmeService
    {
        private readonly string _apiKey = "SUA CHAVE";
        private readonly string _urlOrder = "https://api.pagar.me/core/v5/orders";

        public void CreateBilletTransaction()
        {
            var client = new RestClient(_urlOrder);
            client.Authenticator = new HttpBasicAuthenticator(_apiKey, "");

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            var objBillet = this.GetObjBillet();
            request.AddJsonBody(objBillet);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var objResultResponse = JsonConvert.DeserializeObject<BilletResultModel>(response.Content);

                var orderData = this.GetOrderById(objResultResponse.id);

                var isPaid = orderData.status == "paid";
            }
        }

        public void CreateCreditCardTransaction()
        {
            var client = new RestClient(_urlOrder);
            client.Authenticator = new HttpBasicAuthenticator(_apiKey, "");

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            var objCreditCard = this.GetObjCreditCard();
            request.AddJsonBody(objCreditCard);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var objResultResponse = JsonConvert.DeserializeObject<CreditCardResultModel>(response.Content);

                var orderData = this.GetOrderById(objResultResponse.id);

                var isPaid = orderData.status == "paid";
            }
        }

        private BilletModel GetObjBillet()
        {
            var objResult = new BilletModel();
            objResult.code = "P004";
            objResult.payments = new List<BilletModelPayment>();

            objResult.payments.Add(new BilletModelPayment()
            {
                payment_method = "boleto",
                boleto = new BilletModelBoleto()
                {
                    document_number = "123",
                    instructions = "Pagar até o vencimento",
                    due_at = new DateTime(2022, 9, 10),
                    type = "DM"
                }
            });

            objResult.items = new List<BilletModelItem>();
            objResult.items.Add(new BilletModelItem()
            {
                amount = 1000,
                code = "I001",
                description = "Item de teste",
                quantity = 1
            });

            objResult.customer = new BilletModelCustomer();
            objResult.customer.document = "93095135270";
            objResult.customer.name = "Tony Stark";
            objResult.customer.type = "Individual";
            objResult.customer.document_type = "CPF";
            objResult.customer.email = "avengerstark@ligadajustica.com.br";

            objResult.customer.address = new BilletModelAddress();
            objResult.customer.address.zip_code = "20021130";
            objResult.customer.address.line_2 = "8º andar";
            objResult.customer.address.state = "RJ";
            objResult.customer.address.country = "BR";
            objResult.customer.address.city = "Rio de Janeiro";
            objResult.customer.address.line_1 = "375, Av.General Justo, Centro";

            objResult.customer.phones = new BilletModelPhones();
            objResult.customer.phones.mobile_phone = new BilletModelMobilePhone()
            {
                area_code = "11",
                country_code = "55",
                number = "987452356"
            };

            return objResult;
        }

        private CreditCardModel GetObjCreditCard()
        {
            var objResult = new CreditCardModel();
            objResult.code = "P005";
            objResult.payments = new List<CreditCardModelPayment>();

            objResult.payments.Add(new CreditCardModelPayment()
            {
                payment_method = "credit_card",
                credit_card = new CreditCardModelCreditCard()
                {
                    recurrence = false,
                    installments = 1,
                    statement_descriptor = "AVENGERS",
                    card = new CreditCardModelCard()
                    {
                        billing_address = new CreditCardModelBillingAddress()
                        {
                            line_1 = "10880, Malibu Point, Malibu Central",
                            zip_code = "90265",
                            city = "Malibu",
                            state = "CA",
                            country = "US"
                        },
                        cvv = "3531",
                        exp_month = 1,
                        exp_year = 30,
                        holder_name = "Tony Stark",
                        number = "4000000000000010",
                    }
                }
            });

            objResult.items = new List<CreditCardModelItem>();
            objResult.items.Add(new CreditCardModelItem()
            {
                amount = 1000,
                code = "I001",
                description = "Item de teste",
                quantity = 1
            });

            objResult.customer = new CreditCardModelCustomer();
            objResult.customer.document = "93095135270";
            objResult.customer.name = "Tony Stark";
            objResult.customer.type = "Individual";
            objResult.customer.document_type = "CPF";
            objResult.customer.email = "avengerstark@ligadajustica.com.br";

            objResult.customer.address = new CreditCardModelAddress();
            objResult.customer.address.zip_code = "20021130";
            objResult.customer.address.line_2 = "8º andar";
            objResult.customer.address.state = "RJ";
            objResult.customer.address.country = "BR";
            objResult.customer.address.city = "Rio de Janeiro";
            objResult.customer.address.line_1 = "375, Av.General Justo, Centro";

            objResult.customer.phones = new CreditCardModelPhones();
            objResult.customer.phones.mobile_phone = new CreditCardModelMobilePhone()
            {
                area_code = "11",
                country_code = "55",
                number = "987452356"
            };

            return objResult;
        }

        public OrderResultModel GetOrderById(string idOrder)
        {
            var client = new RestClient($"{_urlOrder}/{idOrder}");
            client.Authenticator = new HttpBasicAuthenticator(_apiKey, "");

            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            var response = client.Execute(request);

           return JsonConvert.DeserializeObject<OrderResultModel>(response.Content);
        }
    }
}

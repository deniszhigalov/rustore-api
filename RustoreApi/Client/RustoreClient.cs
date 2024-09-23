using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace RustoreApi
{
    public class RustoreClient
    {
        private readonly string _privateKey;
        private readonly string _keyId;
        private readonly string _timeZone;
        private readonly string _api = "https://public-api.rustore.ru";

        public RustoreClient(RustoreParams clientParams)
        {
            _privateKey = clientParams.PrivateKey;
            _keyId = clientParams.KeyId;
            _timeZone = clientParams.TimeZone;
        }
        //����� ��������� ������ ����������� ��� ������������ ��������� ����������� ������� public
        private async Task<AuthResponse> Auth()
        {
            var yearMonthDay = DateTime.Now.ToString("yyyy-MM-dd");
            var hourMinuteSeconds = DateTime.Now.ToString("HH:mm:ss");

            var clockBelt = _timeZone;

            var stringToSign = yearMonthDay + "T" + hourMinuteSeconds + clockBelt;

            RsaKeyParameters rsaKeyParameter;
            try
            {
                var keyBytes = Convert.FromBase64String(_privateKey);
                var asymmetricKeyParameter = PrivateKeyFactory.CreateKey(keyBytes);
                rsaKeyParameter = (RsaKeyParameters)asymmetricKeyParameter;
            }
            catch (Exception e)
            {
                throw e;
            }

            var signer = SignerUtilities.GetSigner("SHA512withRSA");
            signer.Init(true, rsaKeyParameter);
            var messageBytes = Encoding.UTF8.GetBytes(_keyId + stringToSign);
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);
            var signed = signer.GenerateSignature();

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    string payload = JsonConvert.SerializeObject(new
                    {
                        keyId = _keyId,
                        timestamp = stringToSign,
                        signature = signed
                    });

                    var content = new StringContent(payload, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(RustoreEndpoints.Endpoints.AuthEndpoint, content);

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<AuthResponse>(resultStr);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //����� ��� ��������� ������ �������
        public async Task<PaymentByPaymentIdResponse> GetPaymentByPaymentId(PaymentByPaymentIdRequest model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.PaymentByPaymentIdEndpoint}/{model.SubscriptionToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    PaymentByPaymentIdResponse result = JsonConvert.DeserializeObject<PaymentByPaymentIdResponse>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //����� ��� ��������� ������ ��������� �������
        public async Task<PaymentByPaymentIdResponse> GetPaymentByPaymentIdTest(PaymentByPaymentIdRequest model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.PaymentByPaymentIdEndpointTest}/{model.SubscriptionToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    PaymentByPaymentIdResponse result = JsonConvert.DeserializeObject<PaymentByPaymentIdResponse>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //��������� ������ ��������
        public async Task<PaymentBySubscriptionIdResponse> GetPaymentBySubscriptionId(PaymentBySubscriptionIdRequest model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.PaymentBySubscriptionIdEndpoint}/{model.SubscriptionToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<PaymentBySubscriptionIdResponse>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //��������� ������ �������� ��������
        public async Task<PaymentBySubscriptionIdResponse> GetPaymentBySubscriptionIdTest(PaymentBySubscriptionIdRequest model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.PaymentBySubscriptionIdEndpointTest}/{model.SubscriptionToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<PaymentBySubscriptionIdResponse>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //��������� ������ �������� ������ 2 ������ ������ ��������, ������������ ������ 3
        public async Task<SubscriptionsV2Response> GetSubscriptionsByPaymentIdV2(SubscriptionsV2Request model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;


            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var purchaseToken = model.SubscriptionToken + "." + model.UserId;

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.SubscriptionsByPaymentIdV2Endpoint}/{model.PackageName}/{model.SubscriptionId}/{purchaseToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<SubscriptionsV2Response>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        //��������� ������ �������� ������ 3
        public async Task<SubscriptionsV2Response> GetSubscriptionsByPaymentIdV3(SubscriptionsV2Request model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;


            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var purchaseToken = model.SubscriptionToken + "." + model.UserId;

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.SubscriptionsByPaymentIdV3Endpoint}/{model.PackageName}/{model.SubscriptionId}/{purchaseToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<SubscriptionsV2Response>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        //��������� ������ �������� �������� ������ 3
        public async Task<SubscriptionsV2Response> GetSubscriptionsByPaymentIdV3Test(SubscriptionsV2Request model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;


            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var purchaseToken = model.SubscriptionToken + "." + model.UserId;

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.SubscriptionsByPaymentIdV3EndpointTest}/{model.PackageName}/{model.SubscriptionId}/{purchaseToken}");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<SubscriptionsV2Response>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        //��������� ������� ��������
        public async Task<StatusSubscriptionResponse> GetStatusSubscription(StatusSubscriptionRequest model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.PaymentBySubscriptionIdEndpoint}/{model.SubscriptionToken}/state");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<StatusSubscriptionResponse>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        //��������� ������� �������� ��������
        public async Task<StatusSubscriptionResponse> GetStatusSubscriptionTest(StatusSubscriptionRequest model)
        {
            var auth = await Auth();
            var jwe = auth.Body.Jwe;

            using (var client = new HttpClient { BaseAddress = new Uri(_api) })
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Public-Token", jwe);

                    var response = await client.GetAsync($"{RustoreEndpoints.Endpoints.PaymentBySubscriptionIdEndpointTest}/{model.SubscriptionToken}/state");

                    var resultStr = await response.Content.ReadAsStringAsync();

                    var jsonSettings = new JsonSerializerSettings()
                    {
                        MissingMemberHandling = MissingMemberHandling.Error,
                        Error = (sender, eventArgs) => {
                            Console.WriteLine(eventArgs.ErrorContext.Error.Message);
                            eventArgs.ErrorContext.Handled = true;
                        }
                    };

                    var result = JsonConvert.DeserializeObject<StatusSubscriptionResponse>(resultStr, jsonSettings);

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
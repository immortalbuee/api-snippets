// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
class Example
{
  static void Main(string[] args)
  {
    // Find your Account Sid and Auth Token at twilio.com/console
    string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    string authToken = "your_auth_token";
    TwilioClient.Init(accountSid, authToken);

    var url = new Uri("http://demo.twilio.com/docs/voice.xml");
    var to = new PhoneNumber("+14155551212");
    var from = new PhoneNumber("+18668675309");
    var sendDigits = "1234#";
    var method = "GET";
    var call = CallResource.Create(to,
                                   from,
                                   url: url,
                                   sendDigits: sendDigits,
                                   method: method);

    Console.WriteLine(call.Sid);
  }
}
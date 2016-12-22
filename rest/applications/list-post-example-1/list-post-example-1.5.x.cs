// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Http;
class Example
{
  static void Main(string[] args)
  {
    // Find your Account Sid and Auth Token at twilio.com/console
    string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    string authToken = "your_auth_token";
    TwilioClient.Init(accountSid, authToken);

    var voiceUrl = new Uri("http://demo.twilio.com/docs/voice.xml");
    var voiceMethod = HttpMethod.Get;

    var app = ApplicationResource.Create("Phone Me",
                                         voiceUrl: voiceUrl,
                                         voiceMethod: voiceMethod);

    Console.WriteLine(app.Sid);
  }
}
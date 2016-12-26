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
    const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    const string authToken = "your_auth_token";
    TwilioClient.Init(accountSid, authToken);

    var phoneNumber = new PhoneNumber("+14158675309");
    var callerIds = OutgoingCallerIdResource.Read(phoneNumber: phoneNumber);

    foreach (var callerId in callerIds)
    {
      Console.WriteLine(callerId.PhoneNumber);
    }
  }
}
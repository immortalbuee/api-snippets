// Download the **Next-Gen** twilio-java library from:
// twilio.com/docs/libraries/java#installation-nextgen
import com.twilio.Twilio;
import com.twilio.rest.preview.wireless.Device;

public class Example {

  // Find your Account Sid and Token at twilio.com/console
  public static final String ACCOUNT_SID = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
  public static final String AUTH_TOKEN = "your_auth_token";

  public static void main(String[] args) {
    Twilio.init(ACCOUNT_SID, AUTH_TOKEN);

    Device device = Device.fetcher("DEb8eff34b248d066a31c4a953134e183e")
      .fetch();
    
    System.out.println(device.getFriendlyName());
  }
}
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Stripe.Stripeterminal;
using Stripe;
using Stripe.Terminal;
using TestStripeBinding.CallbackClasses;
using System.Collections.Generic;

namespace TestStripeBinding
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //StripeConfiguration.SetApiKey("");
            //var options = new ConnectionTokenCreateOptions { };
            //var service = new ConnectionTokenService();
            //ConnectionToken connectionToken = service.Create(options);

            Terminal.InitTerminal(Android.App.Application.Context, Com.Stripe.Stripeterminal.LogLevel.Verbose, new ConnectionTokenProvider(), new TerminalListener());
            DiscoveryConfiguration config = new DiscoveryConfiguration(0, DeviceType.Chipper2x, true);
            Terminal.Instance.DiscoverReaders(config, new DiscoveryListener(), new Callback());
            Com.Stripe.Stripeterminal.Reader reader = DiscoveryListener.readers[0];

            Terminal.Instance.ConnectReader(reader, new ReaderCallback());

            var paymentIntentService = new PaymentIntentService();
            var paymentIntentOptions = new PaymentIntentCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                PaymentMethodTypes = new List<string> { "card_present" },
                CaptureMethod = "manual",
            };

            Terminal.Instance.RetrievePaymentIntent(
                paymentIntentService.Create(paymentIntentOptions).ClientSecret,
                new PaymentIntentCallback());

            Cancelable cancelable = Terminal.Instance.CollectPaymentMethod(PaymentIntentCallback.paymentIntent,
                new ReaderListener(),
                new PaymentIntentCallback());

            Terminal.Instance.ProcessPayment(PaymentIntentCallback.paymentIntent,
                new PaymentIntentCallback());

            var intent = paymentIntentService.Capture(PaymentIntentCallback.paymentIntent.Id, new PaymentIntentCaptureOptions());
        }
    }
}
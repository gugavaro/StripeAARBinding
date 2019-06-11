using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Stripe.Stripeterminal;

namespace TestStripeBinding.CallbackClasses
{
    public class PaymentIntentCallback : Java.Lang.Object, IPaymentIntentCallback
    {
        public IntPtr Handle => throw new NotImplementedException();
        public static PaymentIntent paymentIntent;
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnFailure(TerminalException p0)
        {
            throw new NotImplementedException();
        }

        public void OnSuccess(PaymentIntent p0)
        {
            paymentIntent = p0;
        }
    }
}
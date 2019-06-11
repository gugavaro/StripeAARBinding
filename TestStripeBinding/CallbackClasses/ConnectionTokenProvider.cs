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
    public class ConnectionTokenProvider : Java.Lang.Object, IConnectionTokenProvider
    {
        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void FetchConnectionToken(IConnectionTokenCallback p0)
        {
            throw new NotImplementedException();
        }
    }
}
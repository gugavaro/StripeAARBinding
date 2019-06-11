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
    public class Callback : Java.Lang.Object, ICallback
    {
        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnFailure(TerminalException p0)
        {
            throw new NotImplementedException();
        }

        public void OnSuccess()
        {
            throw new NotImplementedException();
        }
    }
}
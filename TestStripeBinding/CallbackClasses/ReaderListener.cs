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
    public class ReaderListener : Java.Lang.Object, IReaderDisplayListener
    {
        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnRequestReaderDisplayMessage(ReaderDisplayMessage p0)
        {
            throw new NotImplementedException();
        }

        public void OnRequestReaderInput(ReaderInputOptions p0)
        {
            throw new NotImplementedException();
        }
    }
}
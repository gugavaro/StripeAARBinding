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
    public class DiscoveryListener : Java.Lang.Object, IDiscoveryListener
    {
        public static IList<Reader> readers;
        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnUpdateDiscoveredReaders(IList<Reader> p0)
        {
            readers = p0;
        }
    }
}
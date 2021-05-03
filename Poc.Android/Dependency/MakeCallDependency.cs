using System;
using Android.Content;
using Poc.Droid.Dependency;
using Poc.Helper.Dependency;
using Xamarin.Forms;

[assembly: Dependency(typeof(MakeCallDependency))]
namespace Poc.Droid.Dependency
{
    public class MakeCallDependency : PhoneCall
    {
        [Obsolete]
        public void MakeCall(string Number)
        {
            try
            {
                var URI = Android.Net.Uri.Parse(string.Format("tel:{0}", Number));
                var intent = new Intent(Intent.ActionCall, URI);
                Xamarin.Forms.Forms.Context.StartActivity(intent);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}

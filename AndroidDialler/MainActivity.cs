using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Security;
using Xamarin.Essentials;

namespace AndroidDialler
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText editText;
        private Button button;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button button= FindViewById<Button>(Resource.Id.todailer);
            EditText editText = FindViewById<EditText>(Resource.Id.takeno);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            EditText editText = FindViewById<EditText>(Resource.Id.takeno);

            string number = editText.Text;
            PhoneDialer.Open(number);

            /*Android.Net.Uri u = Android.Net.Uri.Parse("tel: " + editText.Text.ToString());
            Intent i = new Intent(Intent.ActionDial, u);
            try
            {
                StartActivity(i);
            }
            catch (SecurityException s)
            {
                // show() method display the toast with 
                // exception message.
                Toast.MakeText(this, "An error occurred", ToastLength.Short)
                     .Show();
            }*/


           
        }
        

        

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public class PhoneDialerTest
        {
            public void PlacePhoneCall(string number)
            {
                
            }
        }
    }
}
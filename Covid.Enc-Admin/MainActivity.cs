using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Covid.Enc_Admin
{
   
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button1;
        Button button2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        

        public void GoToActivity(Type myActivity)
        {
            StartActivity(myActivity);
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            GoToActivity(typeof(Invitado_Activity));
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            GoToActivity(typeof(Administrador_Activity));
        }
    }
}
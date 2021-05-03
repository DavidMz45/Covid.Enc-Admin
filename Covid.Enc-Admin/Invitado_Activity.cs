using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Covid.Enc_Admin
{
    [Activity(Label = "Usuario_Activity")]
    public class Invitado_Activity : Activity
    {
        Button button1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.invitado_layout);
            button1 = FindViewById<Button>(Resource.Id.buttonBack1);
            button1.Click += Button1_Click;
        }

        public void GoToActivity(Type myActivity)
        {
            StartActivity(myActivity);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            GoToActivity(typeof(MainActivity));
        }
    }
}
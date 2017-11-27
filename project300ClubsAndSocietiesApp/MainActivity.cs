using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace project300ClubsAndSocietiesApp
{
    [Activity(Label = "project300ClubsAndSocietiesApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button gBtnSignUp;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            gBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            gBtnSignUp.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_signUp signUpDialog = new dialog_signUp();
                signUpDialog.Show(transaction,"dialog fragment");
            };
        }
    }
}


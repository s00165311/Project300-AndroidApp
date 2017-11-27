using Android.App;
using Android.Widget;
using Android.OS;

namespace project300
{
    [Activity(Label = "project300", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //private Button gBtnSignUp;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}


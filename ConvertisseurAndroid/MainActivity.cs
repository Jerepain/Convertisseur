using Android.App;
using Android.OS;
using Android.Widget;

namespace ConvertisseurAndroid
{
    [Activity(Label = "ConvertisseurAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            this.SetContentView(Resource.Layout.Main);

            var button = this.FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = $"{this.count++} clicks!"; };
        }
    }
}
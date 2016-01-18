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

            var convert = this.FindViewById<Button>(Resource.Id.Convert);
            var result = this.FindViewById<TextView>(Resource.Id.Result);
            var input = this.FindViewById<TextView>(Resource.Id.Input);
            
            convert.Click += delegate { result.Text = (int.Parse(input.Text) * 3).ToString(); };
        }
    }
}
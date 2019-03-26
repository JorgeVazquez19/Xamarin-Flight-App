using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using static Android.Views.View;
using Android.Views;
using Firebase;
using Firebase.Auth;
using System;
using Android.Gms.Tasks;
using Android.Support.Design.Widget;
using XamarinFlightApp.Droid.Classes;

namespace XamarinFlightApp.Droid
{
    [Activity(Label = "XamarinFlightApp", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public class Login : AppCompatActivity, IOnClickListener, IOnCompleteListener
    {
        Button btnLogin;
        EditText input_email, input_password;
        TextView btnSignUp, btnForgotPassword;

        RelativeLayout activity_login;

        public static FirebaseApp appFlights;
        FirebaseAuth auth;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);

            //Init Firebase
            initFirebaseAuth();

            //View
            btnLogin = FindViewById<Button>(Resource.Id.login_btn);
            input_email = FindViewById<EditText>(Resource.Id.login_email);
            input_password = FindViewById<EditText>(Resource.Id.login_password);
            btnSignUp = FindViewById<TextView>(Resource.Id.login_btn_sign_up);
            btnForgotPassword = FindViewById<TextView>(Resource.Id.login_btn_forgot_password);
            activity_login = FindViewById<RelativeLayout>(Resource.Id.login);

            btnSignUp.SetOnClickListener(this);
            btnLogin.SetOnClickListener(this);
            btnForgotPassword.SetOnClickListener(this);

        }

        private void initFirebaseAuth()
        {
            FirebaseOptions options = new FirebaseOptions.Builder()
                .SetApplicationId("1:455934613873:android:692f1cfe19f776b1")
                .SetApiKey("AIzaSyBgHY6ZH3sXko7CBOTwrDBXcK5eY3durks")
                .Build();

            if (appFlights != null)
            {
                appFlights = FirebaseApp.InitializeApp(this, options);
                auth = FirebaseAuth.GetInstance(appFlights);
            }
        }

        public void OnClick(View v)
        {
            if (v.Id == Resource.Id.login_btn_forgot_password)
            {
                StartActivity(new Android.Content.Intent(this, typeof(ForgotPassword)));
                Finish();
            }
            else
            if (v.Id == Resource.Id.login_btn_sign_up)
            {
                StartActivity(new Android.Content.Intent(this, typeof(SignUp)));
                Finish();
            }
            else
            if (v.Id == Resource.Id.login_btn)
            {
                LoginUser(input_email.Text, input_password.Text);
            }
        }

        private void LoginUser(String email, String password)
        {
            auth.SignInWithEmailAndPassword(email, password)
                .AddOnCompleteListener(this);

        }
        public void OnComplete(Task task)
        {
            if (task.IsSuccessful)
            {
                StartActivity(new Android.Content.Intent(this, typeof(DashBoard)));
                Snackbar snackBar = Snackbar.Make(activity_login, "Login Successfull", Snackbar.LengthShort);
                Finish();
            }
            else
            {
                Snackbar snackBar = Snackbar.Make(activity_login, "Login Failes", Snackbar.LengthShort);
                snackBar.Show();
            }
        }
    }
}


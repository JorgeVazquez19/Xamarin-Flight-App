using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Tasks;
using Android.OS;
using Firebase;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using static Android.Views.View;

namespace XamarinFlightApp.Droid.Classes
{
    [Activity(Label = "SignUp", Theme = "@style/AppTheme")]
    public class SignUp : AppCompatActivity, IOnClickListener, IOnCompleteListener
    {
        Button btnSignup;
        TextView btnLogin, btnForgotPass;
        EditText input_email, input_password;
        RelativeLayout activity_signup;

        FirebaseAuth auth;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUp);

            //init Firebase
            try
            {
                auth = FirebaseAuth.GetInstance(Login.appFlights);
            }
            catch
            {
                Console.WriteLine(auth);
            }
            //view
            btnSignup = FindViewById<Button>(Resource.Id.signup_btn);
            btnLogin = FindViewById<TextView>(Resource.Id.signup_login);
            btnForgotPass = FindViewById<TextView>(Resource.Id.signup_btn_forgot_password);
            input_email = FindViewById<EditText>(Resource.Id.signup_email);
            input_password = FindViewById<EditText>(Resource.Id.signup_password);
            activity_signup = FindViewById<RelativeLayout>(Resource.Id.signUp);

            btnLogin.SetOnClickListener(this);
            btnForgotPass.SetOnClickListener(this);
            btnSignup.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if (v.Id == Resource.Id.signup_login)
            {
                StartActivity(new Intent(this, typeof(Login)));
                Finish();
            }
            else
             if (v.Id == Resource.Id.signup_btn_forgot_password)
            {
                StartActivity(new Intent(this, typeof(ForgotPassword)));
                Finish();
            }
            else
             if (v.Id == Resource.Id.signup_btn)
            {
                SignUpUser(input_email.Text, input_password.Text);
            }
        }
        private void SignUpUser(String email, String password)
        {
            Console.WriteLine("===========================> " ,auth);
            Console.WriteLine("===========================> ", email);
            Console.WriteLine("===========================> ", password);

            auth.CreateUserWithEmailAndPassword(email, password)
                .AddOnCompleteListener(this, this);
        }

        public void OnComplete(Task task)
        {
            if (task.IsSuccessful == true)
            {
                Snackbar snackBar = Snackbar.Make(activity_signup, "Register Succesfully", Snackbar.LengthShort);
                snackBar.Show();
            }
            else
            {
                Snackbar snackBar = Snackbar.Make(activity_signup, "Register Failed", Snackbar.LengthShort);
                snackBar.Show();
            }
        }
    }
}
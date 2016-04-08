using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;
using CoreAnimation;

namespace Maive
{
	partial class LoginController : UIViewController
	{
		public LoginController (IntPtr handle) : base (handle)
		{
		}
			

		public override void ViewDidLoad()
		{

				// Perform any additional setup after loading the view, typically from a nib.
				// Making a Profile Image Circular in iOS
			CALayer LoginBtnCircle = btnLogin.Layer;
				LoginBtnCircle.CornerRadius = 27; // relative to the width/height of imageview (50%)
				LoginBtnCircle.MasksToBounds = true;
			CALayer SignUpbtnCircle = btnSignUp.Layer;
			SignUpbtnCircle.CornerRadius = 27; // relative to the width/height of imageview (50%)
			SignUpbtnCircle.MasksToBounds = true;

			if (ParseUser.CurrentUser != null)
			{
				// navigate to the welcome page,
				var home = Storyboard.InstantiateViewController("home") as ProfileController;
				NavigationController.PushViewController (home, true);
			}

			this.txtPassword.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder();
				return true;
			};
			this.txtEmail1.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder();
				return true;
			};

		}


		async partial void BtnLogin_TouchUpInside (UIButton sender)
		{
			// to prevent the user from clicking on the button multiple times,
			// I will hide my login button when it is clicked on till all the processing is complete
			btnLogin.Hidden = true;
			var email = txtEmail1.Text;
			var password = txtPassword.Text;
			var error = "Enter a valid E-mail Address and Password";

			var alert = new UIAlertView();

			// if email and password is not provided don't make the Parse call
			if ((string.IsNullOrEmpty(email)) || (string.IsNullOrEmpty(password)))
			{
				alert = new UIAlertView("Login Failed", error, null, "OK");
				alert.Show();
			}
			else
			{
				try
				{
					// you only need this one line to authenticate the user against Parse
					ParseUser myUser = await ParseUser.LogInAsync(email, password);


					// navigate to the welcome page,
					// note: "home" is the StoryBoard ID of the HomeController
					var home = Storyboard.InstantiateViewController("home") as ProfileController;
					NavigationController.PushViewController (home, true);
				}
				catch (ParseException f)
				{
					alert = new UIAlertView("Login Failed", error, null, "OK");
					alert.Show();
				}
				catch (Exception f)
				{
					alert = new UIAlertView("Login Failed", 
						"Check your network access! Or try again later", null, "OK");
					alert.Show();
				}
			}
			// now I will display my login button
			btnLogin.Hidden = false;
		}


	}
}

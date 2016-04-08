using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;
// ADD: CoreAnimation to your ViewController
using CoreAnimation;

namespace Maive
{
	partial class ProfileController : UIViewController
	{
		public ProfileController (IntPtr handle) : base (handle)
		{

			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			// on page load we will show the current user's First Name from Parse
			var currentUser = ParseUser.CurrentUser;
			lblWelcome.Text = "Welcome, " + currentUser["FirstName"] + "! " ;


			//ParseUser.LogOutAsync ();
				
				// Perform any additional setup after loading the view, typically from a nib.
			// Making a Profile Image Circular in iOS
			CALayer profileImageCircle = imgProfile.Layer;
			profileImageCircle.CornerRadius = 27; // relative to the width/height of imageview (50%)
			profileImageCircle.MasksToBounds = true;

			CALayer ButtonCircle = btnEditProfile.Layer;
			ButtonCircle.CornerRadius = 45; // relative to the width/height of imageview (50%)
			ButtonCircle.MasksToBounds = true;

			// for editibng profile button: 
//			var bio = currentUser["Bio"].ToString(); 
//			txtBio.Text = bio;
//			lblBio.Text = bio;
//
//			txtBio.Hidden = true ; 
//			if (string.IsNullOrEmpty (bio))
//				
//				lblBio.Hidden = true;
//			else
//				lblBio.Hidden = false; 
//
//		}
//
//		partial void BtnEditProfile_TouchUpInside (UIButton sender)
//		{
//			txtBio.Hidden = false;
//			lblBio.Hidden = true ; 
//			btnEditProfile.Hidden = true ; 

//		}
//
//		partial void txtBio_EditingDidEnd (UITextField sender)
//		{ 
//			// PerformSegue a UISimpleTextPrintFormatter validation 
//			if ( txtBio.Text.Length > 0 ) {
//
//				// TODO call parse here. 
//				// here our bio that a user types in can be sent to our Parse database! 
//				var currentUser = ParseUser.CurrentUser;
			//				currentUser["Bio"] = txtBio.Text;
//				currentUser.SaveAsync();
//
//				lblBio.Text = txtBio.Text;
//
//				txtBio.Hidden = true;
//				lblBio.Hidden = false ; 
//				btnEditProfile.Hidden = false ; 
//
//		}
		}


}

}

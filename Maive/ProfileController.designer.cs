// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Maive
{
	[Register ("ProfileController")]
	partial class ProfileController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnEditProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblFollowers { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblFollowing { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblWelcome { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationBar Profile { get; set; }

		[Action ("txtBio_EditingDidEnd:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void txtBio_EditingDidEnd (UITextField sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnEditProfile != null) {
				btnEditProfile.Dispose ();
				btnEditProfile = null;
			}
			if (imgProfile != null) {
				imgProfile.Dispose ();
				imgProfile = null;
			}
			if (lblFollowers != null) {
				lblFollowers.Dispose ();
				lblFollowers = null;
			}
			if (lblFollowing != null) {
				lblFollowing.Dispose ();
				lblFollowing = null;
			}
			if (lblWelcome != null) {
				lblWelcome.Dispose ();
				lblWelcome = null;
			}
			if (Profile != null) {
				Profile.Dispose ();
				Profile = null;
			}
		}
	}
}

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
	[Register ("EditProfileController")]
	partial class EditProfileController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSaveChanges { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnTakePhoto { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationBar EditProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgProfile2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblEmail { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblFirstName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblLastName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtBio { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtEmail2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtFirstName2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtLastName2 { get; set; }

		[Action ("BtnSaveChanges_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnSaveChanges_TouchUpInside (UIButton sender);

		[Action ("BtnTakePhoto_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnTakePhoto_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSaveChanges != null) {
				btnSaveChanges.Dispose ();
				btnSaveChanges = null;
			}
			if (btnTakePhoto != null) {
				btnTakePhoto.Dispose ();
				btnTakePhoto = null;
			}
			if (EditProfile != null) {
				EditProfile.Dispose ();
				EditProfile = null;
			}
			if (imgProfile2 != null) {
				imgProfile2.Dispose ();
				imgProfile2 = null;
			}
			if (lblEmail != null) {
				lblEmail.Dispose ();
				lblEmail = null;
			}
			if (lblFirstName != null) {
				lblFirstName.Dispose ();
				lblFirstName = null;
			}
			if (lblLastName != null) {
				lblLastName.Dispose ();
				lblLastName = null;
			}
			if (txtBio != null) {
				txtBio.Dispose ();
				txtBio = null;
			}
			if (txtEmail2 != null) {
				txtEmail2.Dispose ();
				txtEmail2 = null;
			}
			if (txtFirstName2 != null) {
				txtFirstName2.Dispose ();
				txtFirstName2 = null;
			}
			if (txtLastName2 != null) {
				txtLastName2.Dispose ();
				txtLastName2 = null;
			}
		}
	}
}

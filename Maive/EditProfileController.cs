using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Parse;
using CoreAnimation;

namespace Maive
{
	partial class EditProfileController : UIViewController
	{
		public EditProfileController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			this.txtBio.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder();
				return true;
			};
			this.txtFirstName2.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder();
				return true;
			};
			this.txtLastName2.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder();
				return true;
			};
			this.txtEmail2.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder();
				return true;
			};

			// Perform any additional setup after loading the view, typically from a nib.
		// Making a Profile Image Circular in iOS
			CALayer profileImageCircle = imgProfile2.Layer;
			profileImageCircle.CornerRadius = 27; // relative to the width/height of imageview (50%)
			profileImageCircle.MasksToBounds = true;

		// for editing profile button: 
			var currentUser = ParseUser.CurrentUser;
			txtEmail2.Text = currentUser.Email.ToString(); 
			txtFirstName2.Text = currentUser["FirstName"].ToString(); 
			txtLastName2.Text = currentUser["LastName"].ToString(); 

			var bio = currentUser["Bio"].ToString();  
			txtBio.Text = bio;
			this.txtBio.ShouldReturn += (textField) => 
			{
				textField.ResignFirstResponder ();
				return true;
			};
	
//			
//			
//			// PerformSegue a UISimpleTextPrintFormatter validation 
//			if ( txtBio.Text.Length > 0 ) 
//			{
//				// TODO call parse here. 
//				// here our bio that a user types in can be sent to our Parse database! 
//				currentUser["Bio"] = txtBio.Text;
//				currentUser.SaveAsync();
//				lblBio.Text = txtBio.Text;
//				txtBio.Hidden = true;
//				lblBio.Hidden = false; 
//
//			}


	}



		partial void BtnTakePhoto_TouchUpInside (UIButton sender)
		{
			Maive.Camera.TakePicture (this, async (obj) =>
				{
					var photo = obj.ValueForKey(new NSString("UIImagePickerControllerOriginalImage")) as UIImage; 
					var documentsDirectory = Environment.GetFolderPath  (Environment.SpecialFolder.Personal);
					string imageFileName = "myPhoto.jpg"; 

					string jpgFilename = System.IO.Path.Combine (documentsDirectory, imageFileName); // hardcoded filename, overwritten each time 
					NSData imgData = photo.AsJPEG();  NSError err = null; 

					try 
					{
						if (imgData.Save(jpgFilename, false, out err))
						{
							// TODO: show image in the imageView 
							UIImage outputImage = UIImage.FromFile(jpgFilename);  
							imgProfile2.Image = outputImage; 
							// convert the UIImage to Bytes array 
							var imageStream = outputImage.AsJPEG (.25f).AsStream (); // reduce the image quality by 75% 
							ParseFile imageFile = new ParseFile(imageFileName,
								imageStream); 
							// Save the file to Parse first  await imageFile.SaveAsync(); 
							// now save a reference to the image in your database table  
							var myPhotos = ParseUser.CurrentUser;
							// name of your Parse Table 

							myPhotos["MyPhotos"] = imageFile; // the Parse file   
							await myPhotos.SaveAsync(); 
						}
						else
						{
							Console.WriteLine("NOT saved as " + jpgFilename + " because" + err.LocalizedDescription);
						}
					}
					catch(Exception ex) 
					{
						Console.WriteLine("Error: " + ex.Message); 
					}

				});
}

		partial void BtnSaveChanges_TouchUpInside (UIButton sender)
		{
			// PerformSegue a UISimpleTextPrintFormatter validation 
			if ( txtBio.Text.Length > 0 ) 
			{
				// TODO call parse here. 
				// here our bio that a user types in can be sent to our Parse database! 
				var currentUser = ParseUser.CurrentUser;
				currentUser["Bio"] = txtBio.Text;
				currentUser.SaveAsync();

			}
		}
	}

}
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

namespace WatchDemoWatchKitExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton buttonTwo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton myButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel myLabel { get; set; }

		[Action ("myButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void myButton_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (buttonTwo != null) {
				buttonTwo.Dispose ();
				buttonTwo = null;
			}
			if (myButton != null) {
				myButton.Dispose ();
				myButton = null;
			}
			if (myLabel != null) {
				myLabel.Dispose ();
				myLabel = null;
			}
		}
	}
}

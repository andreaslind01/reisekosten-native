// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace ReisekostenNative.iOS
{
    public partial class LoginSegue : UIStoryboardSegue
    {
        public LoginSegue(IntPtr handle) : base(handle)
        {
        }

        public override void Perform()
        {
            var src = SourceViewController as LoginViewController;
            var dest = SourceViewController as BelegeTableViewController;
            if (src != null && dest != null)
            {
                if(src.isDataValid()) {
                    dest.setUser(src.getUser());
                    src.ShowViewController(dest, null);   
                }
                else {
                    //Create Alert
                    var okAlertController = UIAlertController.Create("Fehler", "Login fehlgeschlagen", UIAlertControllerStyle.Alert);

                    //Add Action
                    okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));

                    // Present Alert
                    src.PresentViewController(okAlertController, true, null);
                }
            }

        }
    }
}
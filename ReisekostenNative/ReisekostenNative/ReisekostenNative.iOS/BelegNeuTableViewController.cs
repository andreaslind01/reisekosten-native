// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using IO.Swagger.Model;

namespace ReisekostenNative.iOS
{
    public partial class BelegNeuTableViewController : UITableViewController
	{
        bool datumExp = false;
        bool artExp = false;
        bool beschrExp = false;

        public BelegNeuTableViewController(IntPtr handle) : base(handle)
        {

        }

        public void setBeleg(Beleg newBeleg) {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var belegeTabView = this.TableView as BelegNeuTableView;
            if(belegeTabView != null) {
                belegeTabView.initTableView();
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            var belegeTabView = tableView as BelegNeuTableView;
            nint ret = 0;
            if (section == 0)
            {
                ret++;
                if (datumExp)
                {
                    ret++;
                }
            }
            else if (section == 1)
            {
                ret++;
                if (artExp)
                {
                    ret++;
                }
            }
            else if (section == 5)
            {
                ret++;
                if (beschrExp)
                {
                    ret++;
                }
            }
            else if (section == 6)
            {
                ret++;
                if (belegeTabView != null && belegeTabView.hasImage())
                {
                    ret++;
                }
            }
            else
            {
                ret++;
            }
            return ret;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
            if (indexPath.Row == 0)
            {
                if (indexPath.Section == 0)
                {
                    datumExp = !datumExp;
                }
                else if (indexPath.Section == 1)
                {
                    artExp = !artExp;
                }
                else if (indexPath.Section == 5) 
                {
                    beschrExp = !beschrExp;
                }    
            }
            tableView.ReloadData();
        }
	}
}

// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation;
using UIKit;
using ReisekostenNative.Services;

namespace ReisekostenNative.iOS
{
	public partial class BelegeTableViewController : UITableViewController
	{
		public BelegeTableViewController (IntPtr handle) : base (handle)
		{
		}

        List<string> belege = new List<string>();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            initTableView();
        }

        public void initTableView()
        {
           // UIService.Instance.GetBelege((o) => setBelege(o));
        }

        private void setBelege(Task<List<string>> o)
        {
            belege = o.Result;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 0;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return belege.Capacity;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return UITableView.AutomaticDimension;
        }

        public override nfloat EstimatedHeight(UITableView tableView, NSIndexPath indexPath)
        {
            return UITableView.AutomaticDimension;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("belege", indexPath);
            if(cell is BelegeTableViewCell) {
                var belegCell = cell as BelegeTableViewCell;
                // belegCell
            }
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
            // Details öffnen
        }
	}
}

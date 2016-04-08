using System;
using UIKit;
using Foundation;

namespace Maive
{
	public class TableSource: UITableViewSource
	{

		string[] TableItems;
		string CellIdentifier = "TableCell"; 
		//  NOTE: this matches the CellIdentifier set in the StoryBoard
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)



		public TableSource (string[] items)
		{
			TableItems = items;
		}
		public override nint RowsInSection ( UITableView tableview,nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell ( UITableView tableView,NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems[indexPath.Row];

			//---- if there are no cells to reuse, create a new one

			if (cell == null)
			{  
				cell = new UITableViewCell( UITableViewCellStyle.Default, CellIdentifier); 
			}

			// the cell’s Text property is set here

			cell.TextLabel.Text = item;
			return cell;
		}
	}


}


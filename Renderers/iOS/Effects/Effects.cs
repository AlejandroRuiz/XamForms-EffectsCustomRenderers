using System;
using Renderers.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("AwesomeEffects")]
[assembly: ExportEffect(typeof(NoClickableListViewEffect), "NoClickableListViewEffect")]
namespace Renderers.iOS
{
	public class NoClickableListViewEffect : PlatformEffect
	{
		#region Effect Life Cycle

		protected override void OnAttached()
		{
			var listView = (UITableView)Control;
			listView.AllowsSelection = false;
		}

		protected override void OnDetached()
		{
			var listView = (UITableView)Control;
			listView.AllowsSelection = true;
		}

		#endregion
	}
}

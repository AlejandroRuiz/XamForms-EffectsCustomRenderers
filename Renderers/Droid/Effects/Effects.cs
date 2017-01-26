using System;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using Renderers.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("AwesomeEffects")]
[assembly: ExportEffect(typeof(NoClickableListViewEffect), "NoClickableListViewEffect")]
namespace Renderers.Droid
{
	public class NoClickableListViewEffect : PlatformEffect
	{
		#region Effect Life Cycle

		protected override void OnAttached()
		{
			var listView = (global::Android.Widget.ListView)Control;
			listView.OnItemClickListener = null;
		}

		protected override void OnDetached()
		{
			var listView = (global::Android.Widget.ListView)Control;
		}

		#endregion
	}
}

using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WatchDemoWatchKitExtension
{
	partial class DemoTableController : WatchKit.WKInterfaceController
	{
		private List<Session> _sessions;

		public DemoTableController (IntPtr handle) : base (handle)
		{

		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			LoadTableRows();
			OpenParentApplication (new NSDictionary ("request", "sessions"), (replyInfo, error) => {
				if(error != null)
				{
					Console.WriteLine(error);
					return;
				}

				var returnObject = replyInfo[FromObject("sessions")].ToString();
				var sessions = JsonConvert.DeserializeObject<List<Session>>(returnObject);
				if(sessions != null) {
					_sessions = sessions;
					LoadTableRows();
				}
			});
		}

		public override void WillActivate ()
		{
			base.WillActivate ();
		}

		void LoadTableRows()
		{
			if (_sessions == null) {
				SessionsTable.SetNumberOfRows (1, "DemoTableRow");
				var row = (DemoTableRowController)SessionsTable.GetRowController (0);
				row.TitleLabel.SetText ("Loading...");
				row.DescriptionLabel.SetText ("Be Cool");
				return;
			}

			SessionsTable.SetNumberOfRows (_sessions.Count, "DemoTableRow");

			for (var i = 0; i < _sessions.Count; i++) {
				var row = (DemoTableRowController)SessionsTable.GetRowController (i);
				row.TitleLabel.SetText (_sessions [i].Title);
				row.DescriptionLabel.SetText (_sessions [i].Description);
			}
		}
	}
}

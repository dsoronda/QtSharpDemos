using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtSharpDemos.media;

namespace QtSharpDemos.GuiExample
{
	/// <summary>
	/// Container for QToolBar
	/// </summary>
	public class ToolbarDemo : BaseDemoWidget
	{
		public static readonly string Description = "Simple toolbar demo";

		public override void InitUI()
		{
			var toolbar = new QToolBar(this);
			toolbar.AddAction(MediaIconHelper.NewDocumentIcon, "New File");
			toolbar.AddAction(MediaIconHelper.OpenDocumentIcon, "Open File");
			toolbar.AddSeparator();
			QAction quit = toolbar.AddAction(MediaIconHelper.SystemLogOugIcon, "Quit Application");

			quit.Triggered += Quit_Triggered;
		}

		private void Quit_Triggered(bool obj)
		{
			var msg = new QMessageBox(icon: QMessageBox.Icon.Information, title:"Info", text: "Quit button clicked");
			//QApplication.CloseAllWindows();
		}

	}
}

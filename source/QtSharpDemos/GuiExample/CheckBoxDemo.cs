using QtCore.Qt;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
	/// <summary>
	/// Display QCheckBox  widget to show/hide the title of the window
	/// </summary>
	public class CheckBoxDemo : BaseDemoWidget
	{
		public static readonly string Description = "Show checkbox status";
		QLabel status = new QLabel("status");

		public override void InitUI()
		{
			this.Layout = new QVBoxLayout();
			var checkBox = new QCheckBox("Show title", this)
			{
				Checked = true,
			};
			checkBox.StateChanged += ShowTitle;

			this.Layout.AddWidget(checkBox);
			this.Layout.AddWidget(status);
		}

		public void ShowTitle(int state)
		{
			this.status.Text = (state == (int)CheckState.Checked) ? "checked" : "unchecked";
		}
	}
}

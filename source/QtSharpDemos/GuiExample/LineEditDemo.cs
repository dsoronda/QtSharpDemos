using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
	public class LineEditDemo : BaseDemoWidget
	{
		QLabel label = new QLabel();
		public static readonly string Description = "This program shows text which is entered in a QLineEdit widget in a QLabel widget.";

		public override void InitUI()
		{
			var layout = new QVBoxLayout(this);

			var edit = new QLineEdit(this);
			edit.TextChanged += OnChanged;
			edit.Text = "LineEdit demo";

			layout.AddWidget(label);
			layout.AddWidget(edit);

		}

		public void OnChanged(string text)
		{
			label.Text = text;
			label.AdjustSize();
		}

	}
}
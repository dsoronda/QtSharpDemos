using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
	public class LabelDemo : QtWidgets.QWidget
	{
		public LabelDemo()
		{
			WindowTitle = "Label demo";

			var vboxLayout = GetLayout();
			this.Layout = vboxLayout;

			Resize(250, 150);
			Show();
		}

		/// <summary>
		/// Gets VBoxLayout with label
		/// </summary>
		/// <returns>The layout.</returns>
		QLayout GetLayout()
		{
			var vbox = new QVBoxLayout();
			vbox.AddWidget(InitLabel("Hello world"));
			return vbox;
		}

		/// <summary>
		/// Inits the label.
		/// </summary>
		/// <returns>The label.</returns>
		/// <param name="text">Label text</param>
		/// <param name="font">Font for text (default is Arial 12)</param>
		public static QLabel InitLabel(string text = "Hi", QFont font = null)
		{
            return new QLabel(text)
            {
                Font = font ?? new QFont("Arial", 12)
            };
		}
	}
}

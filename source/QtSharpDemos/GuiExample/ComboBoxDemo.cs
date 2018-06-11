using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
	public class ComboBoxDemo : BaseDemoWidget
	{
		QLabel label;
		public static readonly string Description = "Combo box usage";

		//public ComboBoxDemo()
		//{
		//	WindowTitle = "ComboBox Demo";

		//	InitUI();

		//	Resize(250, 200);
		//	Move(100, 100);
		//	Show();
		//}

		public override void InitUI()
		{
			var layout = new QVBoxLayout(this);

			label = new QLabel("Selected");
			label.AdjustSize();

			layout.AddWidget(label);

			var combo = new QComboBox(this);
			combo.AddItem("Ubuntu");
			combo.AddItem("Arch");
			combo.AddItem("Fedora");
			combo.AddItem("Red Hat");
			combo.AddItem("Gentoo");

			layout.AddWidget(combo);

			combo.ActivatedText += OnActivated;
		}

		public void OnActivated(string text)
		{
			label.Text = $"Selected text: {text}";
			label.AdjustSize();
		}
	}
}

using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class FontDialogDemo : BaseDemoWidget
    {
		public static readonly string Description = "Open Font dialog and get font name";
		QLabel label;

		public override void InitUI()
		{
			label = new QLabel("Click me to open font dialog", this);

			var vbox = new QVBoxLayout(this);
			label.Alignment = QtCore.Qt.AlignmentFlag.AlignCenter;
			vbox.AddWidget(label);
		}

		protected override void OnMousePressEvent(QMouseEvent @event)
        {
            base.OnMousePressEvent(@event);

            bool ok = true;
            var font = QFontDialog.GetFont(ref ok);
            if (!ok) return;

            label.Font = font;
			label.Text = $"Selected font is {font.Family}";
        }
    }
}

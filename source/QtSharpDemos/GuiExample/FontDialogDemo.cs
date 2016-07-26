using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class FontDialogDemo : QtWidgets.QWidget
    {
        QLabel label;

        public FontDialogDemo()
        {
            WindowTitle = "FontDialog Demo";

            InitUI();

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        public void InitUI()
        {
            label = new QLabel("FontDialog Demo", this);

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
        }
    }
}

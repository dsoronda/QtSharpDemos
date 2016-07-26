using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class ColorDialogDemo : QtWidgets.QWidget
    {
        QLabel label;

        public ColorDialogDemo()
        {
            WindowTitle = "ColorDialog Demo";

            InitUI();

            Resize(250, 150);
            Move(300, 300);
            Show();
        }

        public void InitUI()
        {
            label = new QLabel("ColorDialog Demo", this);

            var vbox = new QVBoxLayout(this);
            label.Alignment = QtCore.Qt.AlignmentFlag.AlignCenter;
            vbox.AddWidget(label);
        }

        protected override void OnMousePressEvent(QMouseEvent @event)
        {
            base.OnMousePressEvent(@event);

            var color = QColorDialog.GetColor();
            if (!color.IsValid) return;

            this.label.StyleSheet = string.Format("QWidget {{ color: {0} }}", color.Name());
        }
    }
}

using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    class QtWidgetDemo1 : QtWidgets.QWidget
    {
        const int WIDTH = 250;
        const int HEIGHT = 150;

        public QtWidgetDemo1()
        {
            WindowTitle = "TEST";
            ToolTip = "This is QT Qwidget";
            Resize(250, 150);
            Center();
            Show();
        }

        private void Center()
        {
            var qdw = new QDesktopWidget();

            int screenWidth = qdw.Width;
            int screenHeight = qdw.Height;

            int cx = (screenWidth - WIDTH) / 2;
            int cy = (screenHeight - HEIGHT) / 2;

            Move(cx, cy);
        }
    }

}

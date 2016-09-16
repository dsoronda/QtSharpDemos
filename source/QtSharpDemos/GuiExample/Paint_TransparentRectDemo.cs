using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore.Qt;
using QtCore;

namespace QtSharpDemos.GuiExample {
    public class Paint_TransparentRectDemo : QtWidgets.QWidget {

        public Paint_TransparentRectDemo ( ) {
            WindowTitle = "PaintTransparent Rect Demo";

            Resize ( 600, 300 );
            Show ( );
        }


        protected override void OnPaintEvent ( QPaintEvent e ) {
            base.OnPaintEvent ( e );

            // this is example from Qt site, http://doc.qt.io/qt-5/qtwidgets-widgets-scribble-example.html
            var painter = new QPainter(this);

            DrawRectangles ( painter );
            painter.End ( );
        }


        void DrawRectangles ( QPainter painter ) {
            painter.SetPen ( PenStyle.NoPen );

            for ( int i = 1 ; i < 11 ; i++ ) {
                painter.Brush = new QColor ( 0, 0, 255, i * 25 );
                painter.DrawRect ( 50 * i, 20, 40, 40 );
            }
        }
    }
}

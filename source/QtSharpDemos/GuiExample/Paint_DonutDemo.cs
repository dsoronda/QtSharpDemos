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
    public class Paint_DonutDemo : QtWidgets.QWidget {

        public Paint_DonutDemo ( ) {
            WindowTitle = "Paint Donut Demo";

            Resize ( 400, 300 );
            Show ( );
        }


        protected override void OnPaintEvent ( QPaintEvent e ) {
            base.OnPaintEvent ( e );

            var painter = new QPainter(this);

            DrawDonut ( painter );
            painter.End ( );
        }

        void DrawDonut ( QPainter painter ) {
            var color = new QColor();
            color.SetNamedColor ( "#333333" );

            painter.Pen = new QPen ( color, 0.5 );
            painter.SetRenderHint ( QPainter.RenderHint.Antialiasing );


            painter.Translate ( new QPoint ( Width / 2, Height / 2 ) );

            for ( double rot = 0 ; rot < 360.0 ; rot += 5.0 ) {
                painter.DrawEllipse ( -125, -40, 250, 80 );
                painter.Rotate ( 5.0 );
            }
        }

    }
}

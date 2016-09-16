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
    public class Paint_TextDemo : QtWidgets.QWidget {

        public Paint_TextDemo ( ) {
            WindowTitle = "Paint Text Demo";

            Resize ( 400, 300 );
            Show ( );
        }


        protected override void OnPaintEvent ( QPaintEvent e ) {
            base.OnPaintEvent ( e );

            var painter = new QPainter(this);

            DrawLyrics ( painter );
            painter.End ( );
        }

        void DrawLyrics ( QPainter painter ) {
            painter.Brush = new QColor ( 25, 25, 25 );
            painter.Font = new QFont ( "Courier", 10 );

            painter.DrawText ( new QPoint ( 20, 30 ), "Most relationships seem so transitory" );
            painter.DrawText ( new QPoint ( 20, 60 ), "They're good but not the permanent one" );
            painter.DrawText ( new QPoint ( 20, 120 ), "Who doesn't long for someone to hold" );
            painter.DrawText ( new QPoint ( 20, 150 ), "Who knows how to love without being told" );
            painter.DrawText ( new QPoint ( 20, 180 ), "Somebody tell me why I'm on my own" );
            painter.DrawText ( new QPoint ( 20, 210 ), "If there's a soulmate for everyone" );
        }

    }
}

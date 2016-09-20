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
    public class Paint_ShapesDemo : QtWidgets.QWidget {

        public Paint_ShapesDemo ( ) {
            WindowTitle = "Paint Demo";

            Resize ( 400, 300 );
            Show ( );
        }


        protected override void OnPaintEvent ( QPaintEvent e ) {
            base.OnPaintEvent ( e );

            var painter = new QPainter(this);

            DrawShapes ( painter );
            painter.End ( );
        }

        void DrawShapes ( QPainter painter ) {
            painter.SetRenderHint ( QPainter.RenderHint.Antialiasing );
            painter.Pen = new QPen ( new QBrush ( new QColor ( "Gray" ) ), 1 );
            painter.Brush = new QColor ( "Gray" );

            var path = new QPainterPath();

            path.MoveTo ( 5, 5 );
            path.CubicTo ( 40, 5, 50, 50, 99, 99 );
            path.CubicTo ( 5, 99, 50, 50, 5, 5 );
            painter.DrawPath ( path );

            painter.DrawPie ( 130, 20, 90, 60, 30 * 16, 120 * 16 );
            painter.DrawChord ( 240, 30, 90, 60, 0, 16 * 180 );
            var rectangle = new QRect(new QPoint(20,120),new QSize(80,50));
            painter.DrawRoundedRect ( rect: rectangle, xRadius: 10, yRadius: 10 );

            // to be implemented
            //var points = new List<QPoint>();
            //points.Add ( new QPoint ( 130, 140 ) );
            //points.Add ( new QPoint ( 180, 170 ) );
            //points.Add ( new QPoint ( 180, 140 ) );
            //points.Add ( new QPoint ( 220, 110 ) );
            //points.Add ( new QPoint ( 140, 100 ) );

            //// http://doc.qt.io/qt-5/qpolygon.html#QPolygon-2 , we should be able to pase point list
            //var polygon = new QPolygon(points);
            //painter.DrawPolygon ( polygon );

            // this is workaround for DrawPolygon
            unsafe
            {
                var polygon = new QPolygon();
                var points = new int[] { 130, 140, 180, 170, 180, 140, 220, 110, 140, 100 };
                fixed ( int* point = points ) {
                    polygon.SetPoints ( points.Length / 2, ref *point );
                }
                painter.DrawPolygon ( polygon );
            }



            painter.DrawRect ( 250, 110, 60, 60 );

            var baseline = new QPointF(20, 250);
            var font = new QFont("Georgia", 55);
            var forntPath = new QPainterPath();
            forntPath.AddText ( baseline, font, "Q" );
            painter.DrawPath ( forntPath );

            painter.DrawEllipse ( 140, 200, 60, 60 );
            painter.DrawEllipse ( 240, 200, 90, 60 );
        }
    }
}

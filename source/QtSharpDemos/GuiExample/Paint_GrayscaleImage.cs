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
    public class Paint_GrayscaleImage : QtWidgets.QWidget {
        QImage colorImage;
        QImage grayscaleImage;

        public Paint_GrayscaleImage ( ) {
            WindowTitle = "Paint Grayscale Demo";
            colorImage = media.MediaGfxHelper.PancakeImage.ScaledToWidth ( 400, mode: TransformationMode.SmoothTransformation ); // get image
            grayscaleImage = ConvertToGrayScale ( colorImage );
            //grayscaleImage = ConvertToGrayScaleIndexed ( colorImage );

            Resize ( 840, 400 );
            Show ( );
        }


        protected override void OnPaintEvent ( QPaintEvent e ) {
            base.OnPaintEvent ( e );

            var painter = new QPainter(this);

            DrawImages ( painter );
            painter.End ( );
        }

        void DrawImages ( QPainter painter ) {
            painter.DrawImage ( 5, 15, colorImage );
            painter.DrawImage ( colorImage.Width + 10, 15, grayscaleImage );
        }

        /// <summary>
        /// Convert RGBA image to grayscale RGBA
        /// </summary>
        /// <param name="originalImage"></param>
        /// <returns></returns>
        public static QImage ConvertToGrayScale ( QImage originalImage ) {
            var newImage = originalImage.Copy();

            for ( int x = 0 ; x < originalImage.Width ; x++ ) {
                for ( int y = 0 ; y < originalImage.Height ; y++ ) {
                    var point = new QPoint(x, y); // pixel position

                    using ( var color = originalImage.PixelColor ( point ) ) {

                        UInt32 pixel = originalImage.Pixel(point);
                        int alpha = color.Alpha;
                        int gray = qrgb.QGray ( pixel );

                        using ( var qColor = new QColor ( gray, gray, gray, alpha ) ) {
                            newImage.SetPixelColor ( point, qColor );
                        }
                    }
                }
            }

            return newImage;
        }

        /// <summary>
        /// Convert Image to grayscale indexed image (like GIF)
        /// </summary>
        /// <param name="originalImage"></param>
        /// <returns></returns>
        public static QImage ConvertToGrayScaleIndexed ( QImage originalImage ) {
            var newImage = new QImage(originalImage.Size, QImage.Format.Format_Grayscale8);

            // Generate grayscale color table
            var my_table = new QColor[256];
            for ( int i = 0 ; i < 256 ; i++ ) my_table[i].SetRgb ( i, i, i );
            // Add color table to image
            // [looking at example](http://stackoverflow.com/questions/5504768/how-to-use-a-color-lut-in-qt-qimage)
            
            /* this is C++ code example
            QImage image(data, imwidth, imheight, QImage::Format_Indexed8);
            QVector<QRgb> colorTable;
            // Translate each color in lutData to a QRgb and push it onto colorTable;
            image.setColorTable ( colorTable );
            */

            //newImage.ColorTable = my_table;

            for ( int x = 0 ; x < originalImage.Width ; x++ ) {
                for ( int y = 0 ; y < originalImage.Height ; y++ ) {
                    var point = new QPoint(x, y); // pixel position

                    UInt32 pixel = originalImage.Pixel(point);
                    var gray = (uint) qrgb.QGray ( pixel );
                    newImage.SetPixel ( point, gray );
                }
            }

            return newImage;
        }

        //public static QImage GrayScale_Scanline (QImage image) {
        //    var newImage = new QImage(image.Size,QImage.Format.Format_Grayscale8);

        //    var my_table = new QColor[256];
        //    for ( int i = 0 ; i < 256 ; i++ ) my_table[i].SetRgb ( i, i, i ) ;

        //    newImage.setpi
        //    qi->setColorTable ( my_table );


        //    for ( int rowCount = 0 ; rowCount < image.Height ; rowCount++ ) {
        //        byte* line = image.ScanLine ( rowCount );
        //        uchar* scan = image.scanLine(rowCount);
        //        int depth = 4;
        //        for ( int jj = 0 ; jj < image.width ( ) ; jj++ ) {

        //            QRgb* rgbpixel = reinterpret_cast<QRgb*>(scan + jj*depth);
        //            int gray = qGray(*rgbpixel);
        //            *rgbpixel = QColor ( gray, gray, gray ).rgba ( );
        //        }
        //    }
        //    return newImage;
        //}

    }

}

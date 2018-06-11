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
    public class Paint_GrayscaleImage : BaseDemoWidget {
		public static readonly string Description = "Convert image to grayscale";

		QImage colorImage;
        QImage grayscaleImage;

        public Paint_GrayscaleImage ( ) {
            colorImage = media.MediaGfxHelper.PancakeImage.ScaledToWidth ( 400, mode: TransformationMode.SmoothTransformation ); // get image
            //grayscaleImage = ConvertToGrayScale ( colorImage );
            grayscaleImage = ConvertToGrayScaleIndexed ( colorImage );
        }

        protected override void OnPaintEvent ( QPaintEvent e ) {
            base.OnPaintEvent ( e );

            var painter = new QPainter(this);

            DrawImages ( painter );
            painter.End ( );
        }

        void DrawImages ( QPainter painter ) {
            painter.DrawImage ( 5, 15, colorImage );
            painter.DrawImage ( 5, colorImage.Height + 10, grayscaleImage );
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
            newImage.ColorCount = 256;
            for ( int i = 0 ; i < 256 ; i++ ) newImage.SetColor ( i, qrgb.QRgb ( i, i, i ) );


            // Add color table for image
            // [looking at example](http://stackoverflow.com/questions/5504768/how-to-use-a-color-lut-in-qt-qimage)

            for ( int x = 0 ; x < originalImage.Width ; x++ ) {
                for ( int y = 0 ; y < originalImage.Height ; y++ ) {
                    var point = new QPoint(x, y); // pixel position

                    UInt32 pixel = originalImage.Pixel(point);
                    var gray =  qrgb.QGray ( pixel );
                    newImage.SetPixel ( point, qrgb.QRgb ( gray, gray, gray ) );
                }
            }
            //newImage.Save ( @"d:\dump.png", "png" );
            return newImage;
        }

		public override void InitUI() { }
	}
}

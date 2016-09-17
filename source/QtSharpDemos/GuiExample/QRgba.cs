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

    /// <summary>
    /// This class is partial so we could extend QRgba with additional properties
    /// </summary>
    public partial class QRgba {
        // An ARGB quadruplet on the format #AARRGGBB, equivalent to an unsigned int.
        public UInt32 ColorBits { get; set; } = 0x00000000;

        public Byte Alpha {
            get { return ( Byte ) ( ( ColorBits & 0xFF000000 ) >> 24 ); }
            set {
                var cleared = ColorBits & 0x00FFFFFF;
                ColorBits = cleared ^ ( ( ( UInt32 ) value ) << 24 ); // xor Alpha values into to 8 bits
            }
        }

        public Byte Red {
            get { return ( Byte ) ( ( ColorBits & 0x00FF0000 ) >> 16 ); }
            set {
                var cleared = ColorBits & 0xFF00FFFF;
                ColorBits = cleared ^ ( ( ( UInt32 ) value ) << 16 ); // xor Red values
            }
        }
        public Byte Green {
            get { return ( Byte ) ( ( ColorBits & 0x0000FF00 ) >> 8 ); }
            set {
                var cleared = ColorBits & 0xFFFF00FF;
                ColorBits = cleared ^ ( ( ( UInt32 ) value ) << 8 ); // xor Red values
            }
        }
        public Byte Blue {
            get { return ( Byte ) (  ColorBits & 0x000000FF  ); }
            set {
                var cleared = ColorBits & 0xFFFFFF00;
                ColorBits = cleared ^ ( ( UInt32 ) value ); // xor Red values
            }
        }

        public QRgba ( UInt32 colorBits ) {
            this.ColorBits = colorBits;
        }

        public static QRgba ToQRgba ( UInt32 colorBits) => new QRgba ( colorBits );
    }

}

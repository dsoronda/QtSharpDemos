using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtGui;

namespace QtSharpDemos.media {
    public static class MediaGfxHelper {
        // load graphic files
        // all files in project should have "Copy to Output Directory" set to Copy...;

        public const string MediaPath = @"media\gfx";
        private static readonly string pancakeUri = $@"{MediaPath}\pancake.jpg";
        public static readonly QPixmap PancakePixmap = new QPixmap(pancakeUri);
        public static readonly QImage PancakeImage = new QImage(pancakeUri);

        private static readonly string skype1Uri = $@"{MediaPath}\sky1.jpg";
        public static readonly QPixmap Sky1Pixmap = new QPixmap(skype1Uri);
        public static readonly QImage Sky1Image = new QImage(skype1Uri);

        private static readonly string sky2Uri = $@"{MediaPath}\sky2.jpg";
        public static readonly QPixmap Sky2Pixmap = new QPixmap(sky2Uri);
        public static readonly QImage Sky2Image = new QImage(sky2Uri);


    }
}

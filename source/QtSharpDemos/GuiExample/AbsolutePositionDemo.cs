using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtGui;
using QtWidgets;

namespace QtSharpDemos.GuiExample {
	class ImagesWithAbsolutePositionDemo : BaseDemoWidget {
		public ImagesWithAbsolutePositionDemo() : base() {
			WindowTitle = "Absolute position demo";
			Resize( 800, 600 );
			//Show ( );
		}

		public override void InitUI() {
			StyleSheet = "QWidget { background-color: #7e7e7e }";

			var sky1_icon = media.MediaGfxHelper.Sky1Pixmap;
			var sky2_icon = media.MediaGfxHelper.Sky2Pixmap;
			var pancake_icon = media.MediaGfxHelper.PancakePixmap;

			var pancakeLabel = new QLabel( this );
			pancakeLabel.Pixmap = pancake_icon.ScaledToHeight( 320 );
			pancakeLabel.Resize( pancakeLabel.Pixmap.Size );
			pancakeLabel.Move( 170, 50 );

			var skyLabel = new QLabel( this );
			skyLabel.Pixmap = sky1_icon.ScaledToHeight( 160 );
			skyLabel.Resize( skyLabel.Pixmap.Size );
			skyLabel.Move( 20, 20 );

			var sky2Label = new QLabel( this );
			sky2Label.Pixmap = sky2_icon.ScaledToHeight( 120 );
			;
			sky2Label.Resize( sky2Label.Pixmap.Size );
			sky2Label.Move( 40, 180 );
		}
	}
}

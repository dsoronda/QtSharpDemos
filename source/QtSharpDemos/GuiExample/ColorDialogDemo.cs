using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample {
	public class ColorDialogDemo : BaseDemoWidget {
		public static readonly string Description = "Show color dialog";
		QLabel label;


		public ColorDialogDemo() : base() {
			//Resize( 250, 150 );
			//Move( 300, 300 );
			//Show();
		}

		protected override void OnMousePressEvent( QMouseEvent @event ) {
			base.OnMousePressEvent( @event );

			var color = QColorDialog.GetColor();
			if (!color.IsValid)
				return;

			this.label.StyleSheet = string.Format( "QWidget {{ color: {0} }}", color.Name() );
		}

		public override void InitUI() {
			label = new QLabel( "Click me to open dialog", this );

			var vbox = new QVBoxLayout( this );
			label.Alignment = QtCore.Qt.AlignmentFlag.AlignCenter;
			vbox.AddWidget( label );
		}
	}
}

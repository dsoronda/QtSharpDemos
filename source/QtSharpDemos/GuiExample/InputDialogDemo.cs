using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;
using QtGui;

namespace QtSharpDemos.GuiExample {
	public class InputDialogDemo : BaseDemoWidget {
		QLineEdit edit;
		public static readonly string Description = "Show results from InputDialog";

		/// <summary>
		/// This program shows text which is entered in a QLineEdit widget in a QLabel widget.
		/// </summary>
		public InputDialogDemo() : base() {
			Resize( 350, 150 );
		}

		public override void InitUI() {
			this.Layout = new QHBoxLayout();
			QPushButton button = new QPushButton( "Dialog", this );
			button.Clicked += Show_Clicked;

			button.FocusPolicy = QtCore.Qt.FocusPolicy.NoFocus;
			this.Layout.AddWidget( button );
			//show.Move( 20, 20 );

			edit = new QLineEdit( this );
			//edit.Move( 130, 22 );
			this.Layout.AddWidget( edit );
		}

		private void Show_Clicked( bool obj ) {
			String text = QInputDialog.GetText( this, "Input Dialog", "Enter something" );

			if (!string.IsNullOrWhiteSpace( text )) {
				edit.Text = text;
			}
		}

	}
}
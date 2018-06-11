using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtCore;
using QtWidgets;
using QtCore.Qt;

namespace QtSharpDemos.GuiExample {
	class ButtonsDemo : BaseDemoWidget {
		QPlainTextEdit textEditor = new QPlainTextEdit( "some text" );
		public static readonly string Description = "Buttons demo with textbox";

		public ButtonsDemo() : base() {
			WindowTitle = "Buttons demo";

			//InitUI();

			Resize( 300, 150 );
			Move( 300, 300 );
			Show();
		}

		public override void InitUI() {
			var vbox = new QVBoxLayout( this );
			var hbox = new QHBoxLayout();

			var ok = new QPushButton( "OK", this );
			ok.Clicked += Ok_Clicked;
			var apply = new QPushButton( "Apply", this );
			apply.Clicked += Apply_Clicked;

			// Align buttonst to right
			hbox.AddWidget( ok, 1, AlignmentFlag.AlignRight );
			hbox.AddWidget( apply );

			vbox.AddWidget( textEditor );
			//vbox.AddStretch( 1 ); // blank space
			vbox.AddLayout( hbox );
		}

		private void Ok_Clicked( bool obj ) => textEditor.AppendPlainText( "Ok clicked" );
		private void Apply_Clicked( bool obj ) => textEditor.AppendPlainText( $"Apply clicked with event parameter : {obj}" );

	}
}

using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class TogleButtonsDemo : QtWidgets.QWidget
    {
        QWidget _square;
        QColor _color;

        QPushButton _redButton;
        QPushButton _greenButton;
        QPushButton _blueButton;

        public TogleButtonsDemo()
        {
            WindowTitle = "Toggle buttons";

            InitUI();

            Resize(350, 240);
            Move(400, 300);
            Show();
        }

        private void InitUI()
        {
            _color = new QColor();

            _redButton = new QPushButton("Red", this);
            _redButton.Checkable = true;
            _greenButton = new QPushButton("Green", this);
            _greenButton.Checkable = true;
            _blueButton = new QPushButton("Blue", this);
            _blueButton.Checkable = true;

            _redButton.Toggled += OnToggled;
            _greenButton.Toggled += OnToggled;
            _blueButton.Toggled += OnToggled;

            _square = new QWidget(this);
            _square.StyleSheet = "QWidget { background-color: black }";

            _redButton.Move(30, 30);
            _greenButton.Move(30, 80);
            _blueButton.Move(30, 130);
            _square.SetGeometry(150, 25, 150, 150);
        }

        public void OnToggled(bool @checked)
        {
            int red = _color.Red;
            int green = _color.Green;
            int blue = _color.Blue;

            if (_redButton.Checked) red = 255;
            else red = 0;

            if (_greenButton.Checked) green = 255;
            else green = 0;

            if (_blueButton.Checked) blue = 255;
            else blue = 0;

            _color = new QColor(red, green, blue);

            string sheet = System.String.Format("QWidget {{ background-color: {0} }}", _color.Name());
            _square.StyleSheet = sheet;
        }
    }

}

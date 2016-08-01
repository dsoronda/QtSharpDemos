//import related modules
import QtQuick 2.3
import QtQuick.Controls 1.2
import QtQuick.Window 2.2

import QtQuick.Layouts 1.1
import QtQuick.Dialogs 1.1

//window containing the application
ApplicationWindow {

    visible: true
    title: "Qt Quick Controls Gallery"

    width: 640
    height: 480

    //menu containing two menu items
    menuBar: MenuBar {
        Menu {
            title: qsTr("File")
            MenuItem {
                text: qsTr("&Open")
                onTriggered: console.log("Open action triggered");
            }
            MenuItem {
                text: qsTr("Exit")
                onTriggered: Qt.quit();
            }
        }
    }

    //Content Area

    //a button in the middle of the content area
    Button {
        text: qsTr("Hello World")
        anchors.horizontalCenter: parent.horizontalCenter
        anchors.verticalCenter: parent.verticalCenter
    }
     
    TextInput {
        id: textInput1
        x: 141
        y: 37
        width: 80
        height: 20
        text: qsTr("Text Input")
        font.pixelSize: 12
    }

    Button {
        id: button1
        x: 141
        y: 63
        text: qsTr("Button")
    }

    CheckBox {
        id: checkBox1
        x: 145
        y: 92
        text: qsTr("Check Box")
    }

    ComboBox {
        id: comboBox1
        x: 141
        y: 120
    }

    ProgressBar {
        id: progressBar1
        x: 141
        y: 154
    }


}


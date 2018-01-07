#include "mainwindow.h"
#include <QApplication>
#include <QFileInfo>
#include <QTextCodec>

int main(int argc, char *argv[])
{
    QTextCodec *xcodec = QTextCodec::codecForLocale();
    QString exeDir = xcodec->toUnicode(QByteArray(argv[0]));
    QString currentPath = QFileInfo(exeDir).path();
    QApplication::addLibraryPath(currentPath);

    QApplication a(argc, argv);
    MainWindow w(currentPath);
    w.show();

    return a.exec();
}

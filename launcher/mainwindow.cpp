#include "mainwindow.h"

#include <QProcess>
#include <QTimer>
#include "ui_mainwindow.h"

MainWindow::MainWindow(QString currentPath, QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow),
    _currentPath(currentPath)
{
    ui->setupUi(this);
    this->setWindowFlags(Qt::FramelessWindowHint);

    this->setAutoFillBackground(true);
    QPalette palette;
    QPixmap pixmap(_currentPath + "\\background.png");
    palette.setBrush(QPalette::Window, QBrush(pixmap));
    this->setPalette(palette);

    QTimer::singleShot(3*1000, this, SLOT(OnLaunchTimer()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::OnLaunchTimer() {
    QProcess::startDetached(_currentPath + "\\phoenix.exe",QStringList());
    //QProcess::startDetached("D:\\remote_sense\\out\\phoenix.exe", QStringList());
    this->close();
}

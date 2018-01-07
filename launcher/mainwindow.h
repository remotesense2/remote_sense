#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <memory>
#include <QMainWindow>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QString currentPath, QWidget *parent = 0);
    ~MainWindow();

private slots:
    void OnLaunchTimer();

private:
    Ui::MainWindow *ui;
    QString _currentPath;
};

#endif // MAINWINDOW_H

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Chapter_01_020_InheritTheApp
{
    class InheritTheApp : Application // класс InheritTheApp наследует от Application и переопределяет методы
                                      // OnStartup и OnSessionEnding, определяемые в классе Application

    {
        [STAThread]
        public static void Main()
        {
            InheritTheApp app = new InheritTheApp(); // создаётся объект типа InheritTheApp
            app.Run();
        }
        protected override void OnStartup(StartupEventArgs args) // создаётся и отображается объект Window
        {
            base.OnStartup(args);
            Window win = new Window();
            win.Title = "Inherit the App";
            win.Show();
        }
        protected override void OnSessionEnding(SessionEndingCancelEventArgs args)
        // выводит окно сообщения с кнопками Yes, No, Cancel
        // заголовок окна сообщения заполняется текстом MainWindow.Title

        {
            base.OnSessionEnding(args);
            MessageBoxResult result =
            MessageBox.Show("Do you want to save your data?",
            MainWindow.Title, MessageBoxButton.YesNoCancel,
            MessageBoxImage.Question, MessageBoxResult.Yes);
            args.Cancel = (result == MessageBoxResult.Cancel);

        }  // т.к у программы нет данных для сохранения, она игнорирует кнопки Yes и No,
           // разрешая приложению завершиться, а системе Windows продолжить завершение сеанса пользователя

        // если была выбрана кнопка Cancel, программа устанавливает флаг Cancel объекта SessionEndingCancelEventArgs;
        // это запрещает выключение компьютера или завершение сеанса
    }
}
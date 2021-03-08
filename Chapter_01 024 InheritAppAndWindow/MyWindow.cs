using System;
using System.Windows;
using System.Windows.Input;
namespace Petzold.InheritAppAndWindow
{
    public class MyWindow : Window 
    { 
        //Конструктор класса MyWindow
        public MyWindow() 
        { 
            Title = "Inherit App & Window";
        }
        protected override void OnMouseDown(MouseButtonEventArgs args) //Отслеживаем нажатия мыши 
        { 
            base.OnMouseDown(args);
            string strMessage/*Строка*/ = string.Format("Window clicked with  {0} button at point ({1})", args.ChangedButton,/*Какая кнопка*/ args.GetPosition(this) /*Позиция нажатия*/); 
            MessageBox.Show(strMessage, Title); //Отображает окно сообщения
        } 
    }
}
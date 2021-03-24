//---------------------------------------------- 
//SimpleEllipse.cs (c) 2006 by Charles Petzold 
//----------------------------------------------


using System; 
using System.Windows; 
using System.Windows.Media; 

namespace Petzold.RenderTheGraphic 
{     
    class SimpleEllipse : FrameworkElement     
    {         
        protected override void OnRender (DrawingContext dc)         //DrawingContext используется для рисования вызовом DrawEllipse
        {             
            dc.DrawEllipse(Brushes.Blue, new Pen (Brushes.Red, 24),     //Задаем цвет внутренности и границы (в случае границы создаем кастомную кисть со своим цветом и шириной)     
                new Point(RenderSize.Width / 4,  RenderSize.Height / 4),                 
                RenderSize.Width / 4, RenderSize .Height / 4);         
        }     
    } 
} 


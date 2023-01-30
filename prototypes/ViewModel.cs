using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace prototypes
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RoutedCommand Command { get; set; } = new RoutedCommand();

        public CommandBinding bind;
       // DispatcherTimer distTimer = new DispatcherTimer();
        public string CBIndex // свойство для отображения фамилии в Combobox
        {
            get
            {
                return null;
            
                //DispatcherTimer timer = new DispatcherTimer();
                //timer.Interval = TimeSpan.FromSeconds(1);
                //timer.Tick += timer_Tick;
                //timer.Start();
                //distTimer.Interval = new TimeSpan(0, 0, 60);
                // distTimer.Start();

               
                //return "Получить код можно через " + distTimer;


            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //lblTime.Content = DateTime.Now.ToLongTimeString();
        }
        public ViewModel()
        {
            bind = new CommandBinding(Command);  // инициализация объекта для привязки данных
            // добавление обработчика событий
        }

    }
}

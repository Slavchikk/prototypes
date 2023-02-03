using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace prototypes
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        DispatcherTimer distTimer = new DispatcherTimer();
        DispatcherTimer distTimer1 = new DispatcherTimer();
        int wheren = 0;
        public Page1()
        {
            InitializeComponent();
            distTimer.Interval = new TimeSpan(0, 0, 10);
            distTimer.Start();
            distTimer.Tick += new EventHandler(ClosePage);
        }
        public Page1(int two)
        {
            InitializeComponent();
            wheren = 1;
            distTimer1.Interval = new TimeSpan(0, 0, 10);
            distTimer1.Start();
            distTimer1.Tick += new EventHandler(Close1Page);
        }
        private void ClosePage(object sender, EventArgs e)
        {
            Content = null;
            Frameclass.MainFrame.Navigate(new MainPage(1));
        }
        private void Close1Page(object sender, EventArgs e)
        {
            Content = null;
            Frameclass.MainFrame.Navigate(new MainPage(1,1));
        }

        private void btnReg(object sender, TextChangedEventArgs e)
        {
            int str = TbPasReg.Text.Length;
            distTimer.Stop();
            if (Convert.ToInt32(TbPasReg.Text) == Frameclass.globalInt)
            {
                MessageBox.Show("Вы вошли");
            }
            else if (str == 5)
            {

                MessageBox.Show("код введен неверно!");
                if(wheren == 1)
                {
                    Frameclass.MainFrame.Navigate(new MainPage(1,1));
                    Content = null;
                }
                else
                {
                    Frameclass.MainFrame.Navigate(new MainPage(1));
                    Content = null;
                }
             
            }
        }
    }
}

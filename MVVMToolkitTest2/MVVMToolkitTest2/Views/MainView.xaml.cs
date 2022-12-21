using Microsoft.Extensions.DependencyInjection;
using MVVMToolkitTest2.ViewModels;
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
using System.Windows.Shapes;

namespace MVVMToolkitTest2.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private readonly IServiceProvider _service;

        public MainView(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
            //var wnd = _service.GetRequiredService<MainViewModel>();
            //this.DataContext = wnd;
            //wnd.IsActive = true;
            this.DataContext = _service.GetRequiredService<MainViewModel>();
        }
        public MainViewModel ViewModel => (MainViewModel)DataContext;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginWnd = _service.GetRequiredService<LogInView>();
            loginWnd.Show();
        }
    }
}

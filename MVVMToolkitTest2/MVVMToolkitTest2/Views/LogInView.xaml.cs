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
    /// Interaction logic for LogInView.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        private readonly IServiceProvider _service;

        public LogInView(IServiceProvider service)
        {
            InitializeComponent();
            _service = service;
            this.DataContext = _service.GetRequiredService<LogInViewModel>();
        }
        public LogInViewModel ViewModel => (LogInViewModel)DataContext;
    }
}

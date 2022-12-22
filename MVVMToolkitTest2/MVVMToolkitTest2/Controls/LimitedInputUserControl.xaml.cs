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

namespace MVVMToolkitTest2.Controls
{
    /// <summary>
    /// Interaction logic for LimitedInputUserControl.xaml
    /// </summary>
    public partial class LimitedInputUserControl : UserControl
    {
        public LimitedInputUserControl()
        {
            InitializeComponent();
            //this.DataContext = this;
            //Do not define the DataContext in the code-behind
            //Bind the DataContext in the XAML view.
        }

        /*
        DependencyProperty.Register("--Binding으로 연결하는 변수--",
        typeof(--binding으로 연결된 변수의 타입--),
        typeof(--usercontrol을 사용한 클래스의 이름--),
        new PropertyMetadata(--기본은 null값으로--));
        */

        public string ControlText
        {
            get { return (string)GetValue(ControlTextProperty); }
            set { SetValue(ControlTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ControlText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ControlTextProperty =
            DependencyProperty.Register("ControlText", typeof(string)
                , typeof(LimitedInputUserControl), new PropertyMetadata(String.Empty));


        public string? Title { get; set; }
        public int MaxLength { get; set; }
    }
}

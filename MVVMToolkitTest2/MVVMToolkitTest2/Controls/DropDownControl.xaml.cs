using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for DropDownControl.xaml
    /// </summary>
    public partial class DropDownControl : UserControl
    {
        public DropDownControl()
        {
            InitializeComponent();
            //List<string> list = new List<string>() { "Me", "You", "They", "Him", "Her", "Us"};
            //TestList = list;
        }
        #region Control level properties
        //public string? Title { get; set; }

        public List<string> TestList { get; set; }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(DropDownControl), new PropertyMetadata(String.Empty));



        public Visibility ControlVisibility
        {
            get { return (Visibility)GetValue(ControlVisibilityProperty); }
            set { SetValue(ControlVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ControlVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ControlVisibilityProperty =
            DependencyProperty.Register("ControlVisibility", typeof(Visibility), typeof(DropDownControl), new PropertyMetadata(Visibility.Collapsed));
        #endregion
        #region Button properties
        public Visibility PlusVisibility
        {
            get { return (Visibility)GetValue(PlusVisibilityProperty); }
            set { SetValue(PlusVisibilityProperty, value); }
        }
        public Visibility MinusVisibility
        {
            get { return (Visibility)GetValue(MinusVisibilityProperty); }
            set { SetValue(MinusVisibilityProperty, value); }
        }
        public ICommand AddCommand
        {
            get { return (ICommand)GetValue(AddCommandProperty); }
            set { SetValue(AddCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlusVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlusVisibilityProperty =
            DependencyProperty.Register("PlusVisibility", typeof(Visibility), typeof(DropDownControl), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for MinusVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinusVisibilityProperty =
            DependencyProperty.Register("MinusVisibility", typeof(Visibility), typeof(DropDownControl), new PropertyMetadata(Visibility.Visible));

        // Using a DependencyProperty as the backing store for AddCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddCommandProperty =
            DependencyProperty.Register("AddCommand", typeof(ICommand), typeof(DropDownControl), new PropertyMetadata(null));
        #endregion
        #region Dropdown properties
        public ObservableCollection<object> DropDownSource
        {
            get { return (ObservableCollection<object>)GetValue(DropDownSourceProperty); }
            set { SetValue(DropDownSourceProperty, value); }
        }
        public string DropDownDisplayMemberPath
        {
            get { return (string)GetValue(DropDownDisplayMemberPathProperty); }
            set { SetValue(DropDownDisplayMemberPathProperty, value); }
        }
        public object DropDownSelectedItem
        {
            get { return (object)GetValue(DropDownSelectedItemProperty); }
            set { SetValue(DropDownSelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DropDownSelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DropDownSelectedItemProperty =
            DependencyProperty.Register("DropDownSelectedItem", typeof(object), typeof(DropDownControl), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for DropDownDisplayMemberPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DropDownDisplayMemberPathProperty =
            DependencyProperty.Register("DropDownDisplayMemberPath", typeof(string), typeof(DropDownControl), new PropertyMetadata(String.Empty));

        // Using a DependencyProperty as the backing store for DropDownSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DropDownSourceProperty =
            DependencyProperty.Register("DropDownSource", typeof(ObservableCollection<object>), typeof(DropDownControl), new PropertyMetadata(null));

        #endregion
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            ControlVisibility = Visibility.Collapsed;
        }
    }
}

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

namespace homework3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Tip tip;

        public MainWindow()
        {
            InitializeComponent();
            //创建tip对象，用于计算
            tip = new Tip();
        }

        //billAmountTextBox内容修改时，重新计算（performCalculation）
        private void billAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            performCalculation();
        }

        //billAmountTextBox被鼠标点击时，内容清空
        private void amountTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            billAmountTextBox.Text = "";
        }

        //某个RadioButton被选中时，重新计算（performCalculation）
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            performCalculation();
        }

        //用于计算的方法
        private void performCalculation()
        {
            //找出被选中的selectedRadio，或使用初始默认的selectedRadio
            var selectedRadio = myStackPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);

            if (selectedRadio != null)
            {
                //调用tip对象的计算方法CalculateTip，传入输入的值和选中的selectedRadio的值
                tip.CalculateTip(billAmountTextBox.Text, double.Parse(selectedRadio.Tag.ToString()));
                //输入显示
                amountToTipTextBlock.Text = tip.TipAmount;
                totalTextBlock.Text = tip.TotalAmount;
            }

        }

        //private List<float> Width_Proportion = new List<float>();
        //private List<float> Height_Proportion = new List<float>();
        //private List<float> Left_Proportion = new List<float>();
        //private List<float> Top_Proportion = new List<float>();
        //private List<float> Font_Proportion1 = new List<float>();
        //private List<float> Font_Proportion2 = new List<float>();

        //public Form1()
        //{
        //    InitializeComponent();//初始化后会调用其他成员方法，再往下运行。
        //    foreach (Control control in this.Controls)
        //    {
        //        Width_Proportion.Add((float)control.Width / Width);
        //        Height_Proportion.Add((float)control.Height / Height);
        //        Left_Proportion.Add((float)control.Left / Width);
        //        Top_Proportion.Add((float)control.Top / Height);
        //        Font_Proportion1.Add((float)control.Font.Size / control.Width);
        //        Font_Proportion2.Add((float)control.Font.Size / control.Height);
        //    }
        //}

        //private void Resize(object sender, SizeChangedEventArgs e)
        //{
        //    if (Width_Proportion.Count == 0) return;
        //    int i = 0;
        //    foreach (Control control in this.Controls)
        //    {
        //        control.Width = (int)(Width * Width_Proportion[i]);
        //        control.Height = (int)(Height * Height_Proportion[i]);
        //        control.Left = (int)(Width * Left_Proportion[i]);
        //        control.Top = (int)(Height * Top_Proportion[i]);
        //        float font_size1 = Font_Proportion1[i] * control.Width;
        //        float font_size2 = Font_Proportion2[i] * control.Height;
        //        control.Font = new Font(control.Font.Name, font_size1 < font_size2 ? font_size1 : font_size2, control.Font.Style);
        //        i++;
        //    }
        //}
    }
}

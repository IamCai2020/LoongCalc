﻿using System;
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

namespace LoongEgg.Views
{
    /// <summary>
    /// CalculatorView.xaml 的交互逻辑
    /// </summary>
    public partial class CalculatorView : Window
    {
        public CalculatorView() {
            InitializeComponent();
        }

        // TODO: 23-3 窗体移动代码
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }
    }
}

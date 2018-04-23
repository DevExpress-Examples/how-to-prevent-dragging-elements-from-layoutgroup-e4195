// Developer Express Code Central Example:
// How to prevent dragging elements from LayoutGroup
// 
// This example demonstrates how to allow customizing items only inside
// LayoutGroup. All custom logic is implemented in the
// LayoutItemDragAndDropController and LayoutControlController descendants. To
// allow adding new "isolated groups" to LayoutControl, a
// LayoutControlCustomizationController descendant was created.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4195

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.LayoutControl;

namespace LayoutCntMoveInGroup
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

using Microsoft.Toolkit.Forms.UI.XamlHost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUX = Windows.UI.Xaml;

namespace ManagedLibrary
{
    public partial class UserControl1 : UserControl
    {
        Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost windowsXamlHost;
        WUX.Controls.StackPanel stackPanel;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnShowWinForms_Click(object sender, EventArgs e)
        {
            ShowWinUI();
        }

        public void ShowWinUI()
        {
            this.windowsXamlHost = new Microsoft.Toolkit.Forms.UI.XamlHost.WindowsXamlHost();
            //Controls.Add(this.windowsXamlHost);

            this.windowsXamlHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.windowsXamlHost.InitialTypeName = null;
            this.windowsXamlHost.Location = new System.Drawing.Point(0, 0);
            this.windowsXamlHost.Name = "windowsXamlHost";
            this.windowsXamlHost.Size = new System.Drawing.Size(1051, 685);
            this.windowsXamlHost.TabIndex = 0;
            this.windowsXamlHost.Text = "windowsXamlHost1";

            stackPanel = new WUX.Controls.StackPanel()
            {
                Background = new WUX.Media.SolidColorBrush(Windows.UI.Colors.Black),
            };


            // Use helper method to create a UWP control instance.
            Windows.UI.Xaml.Controls.Button myButton =
                Microsoft.Toolkit.Win32.UI.XamlHost.UWPTypeFactory.CreateXamlContentByType(
                    "Windows.UI.Xaml.Controls.Button") as Windows.UI.Xaml.Controls.Button;

            // Initialize UWP control.
            myButton.Name = "button1111";
            myButton.Width = 75;
            myButton.Height = 40;
            myButton.TabIndex = 0;
            myButton.Content = "Win UI button - click me to see Win UI UC";
            myButton.MinWidth = 300;
            myButton.Click += MyButton_Click;
            stackPanel.Children.Add(myButton);
            stackPanel.RequestedTheme = WUX.ElementTheme.Dark;
            windowsXamlHost.Child = stackPanel;

            //AddUC();

            flowLayoutPanel1.Controls.Add(windowsXamlHost);
        }

        private void MyButton_Click(object sender, WUX.RoutedEventArgs e)
        {
            AddUC();
        }

        private void AddUC()
        {
            //crashes MFC app!!!
            var uc = new ClassLibraryUWP.MyUserControlUWP();
            stackPanel.Children.Add(uc);
        }
    }
}

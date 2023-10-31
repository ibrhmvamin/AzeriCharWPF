using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace AzeriChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Message> messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            messages = new List<Message>() 
            {
            new Message("Salam",new DateTime(2023,10,30)) ,
            new Message("Necesen",new DateTime(2023,10,31)) ,
            new Message("5 ci gun futbol xaraso",new DateTime(2023,10,31)) ,
            new Message("Barca Real",new DateTime(2023,10,31)) ,
            new Message("Gedek ?",new DateTime(2023,10,31)) ,
            };

            DataContext = this;
        }

        private void EnterMe(object sender, System.Windows.Input.MouseEventArgs e)
        {
            accesslbl.Content = "writing...";
            if (textbox.Text == "Tap for writing...") { 
            textbox.Text = string.Empty;
            }
        }

        private void LeaveMe(object sender, System.Windows.Input.MouseEventArgs e)
        {
            accesslbl.Content = "online";
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.Text)) 
            {
                Message message = new Message(textbox.Text,DateTime.Now);
                messages.Add(message);
                listview.Items.Add(message);
                textbox.Text=string.Empty;
            }
        }

        private void DoubleClickMe(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (textbox.Text == "Tap for writing...")
            {
                textbox.Text = string.Empty;
                accesslbl.Content = "writing...";
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ControlsExamplePart1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void MyCheckBox_Tapped(object sender,TappedRoutedEventArgs e)
        {
            CheckBoxResultTexBlock.Text = MyCheckBox.IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonTextBox.Text = (bool)YesRadioButton.IsChecked ? "Yes" : "No";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResultTextBlock.Text = item.Content.ToString();
        }

        private void LisBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = MyLisBox.Items.Cast<ListBoxItem>()
                                  .Where(p => p.IsSelected)
                                    .Select(t => t.Content.ToString())
                                      .ToArray();

            LisBoxResultTextBlock.Text = string.Join(", ", selectedItems);
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButtonResultTextBlock.Text = MyToggleButton.IsChecked.ToString();
        }
    }
}

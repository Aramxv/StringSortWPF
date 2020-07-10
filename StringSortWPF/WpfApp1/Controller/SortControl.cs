using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

using StringSorter.View;
using StringSorter.Model;
using StringSorter.Interface;

namespace StringSorter.Controller
{
    public class SortControl 
    {
        private View.SorterMainWindow _main = new SorterMainWindow();
        
        public void SortStringNow()
        {
            try
            {
                _main.SortedString = _main._sorter.Sort((ISorter)_main.cmbAlgo.SelectedItem, _main.txtInput.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

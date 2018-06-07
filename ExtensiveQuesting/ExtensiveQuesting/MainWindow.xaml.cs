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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExtensiveQuesting.QuestingItem.Quest;
using ExtensiveQuesting.QuestingItem.Task;
using ExtensiveQuesting.EnumDescription;
using Newtonsoft.Json;

namespace ExtensiveQuesting {
  /// <summary>
  /// Interaktionslogik für MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();

      MessageBox.Show(Description.GetDescription(TaskIDs.kill_mob));
    }

  }
}

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

using ExtensiveQuesting.QuestingItem.Quest;
using ExtensiveQuesting.QuestingItem.Criterion;
using ExtensiveQuesting.QuestingItem.Task;
using ExtensiveQuesting.QuestingItem.Reward;
using ExtensiveQuesting.EnumDescription;

using Newtonsoft.Json;

namespace ExtensiveQuesting {
  /// <summary>
  /// Interaktionslogik für MainWindow.xaml
  /// </summary>
  /// 

  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();

      test();
    }

    private void test() {
      ExtensiveQuest q = new ExtensiveQuest("NewQuest") { Name = "My New Quest", Text = "Complete this Quest!" };

      q.AddTask(new TaskCollect() { Name = "Collect", TaskItem = new QuestingItem.Item.QuestItem() { ID = "Gold" } });
      q.AddReward(new RewardCommand() { Command = "kill $PLAYER" });

      tblJson.Text = JsonConvert.SerializeObject(q, Formatting.Indented);
      trvQuests.Items.Clear();
      trvQuests.Items.Add(q);
    }

  }
}

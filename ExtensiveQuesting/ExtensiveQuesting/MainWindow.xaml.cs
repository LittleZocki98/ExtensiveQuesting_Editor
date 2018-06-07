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
  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();

      test();
    }

    private void test() {
      ExtensiveQuest q = new ExtensiveQuest("NewQuest") { Name = "My New Quest", Text = "Complete this Quest!" };
      q.AddCriterion(new CriterionExperience() { Level = 12, IsLevel = false, Name = "Get \"Experience\"" });
      q.AddTask(new TaskCollect() { Name = "Collect Items", TaskItem = new QuestingItem.Item.QuestItem("Gold") { Meta = 1, Amount = 16 } });
      q.AddReward(new RewardCommand() { Command = "Excample_Command" });
      q.AddReward(new RewardItem());

      tblTest.Text = JsonConvert.SerializeObject(q, Formatting.Indented);
    }

  }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ExtensiveQuesting.QuestingItem.Task;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Quest {
  /// <summary>
  /// 
  /// </summary>
  class ExtensiveQuest : BaseQuest {

    /// <summary>
    /// Introduction text of the quest
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// Should the quest be visible when the criteria were not reached yet?
    /// </summary>
    [JsonProperty("show_without_criteria")]
    public bool ShowWithoutCriteria { get; set; }

    /// <summary>
    /// List of all tasks
    /// </summary>
    [JsonIgnore]
    public List<BaseTask> Tasks { get; } = new List<BaseTask>();

    [JsonProperty("tasks")]
    public ObservableCollection<BaseItem> Children {
      get {
        List<BaseItem> o = new List<BaseItem>();
        o.AddRange(Tasks);
        return new ObservableCollection<BaseItem>(o);
      }
    }

    /// <summary>
    /// Create a quest without an ID
    /// </summary>
    public ExtensiveQuest() : base() {
      Text = string.Empty;
      ShowWithoutCriteria = false;
    }

    /// <summary>
    /// Create a quest with an ID
    /// </summary>
    /// <param name="ID">ID of the quest</param>
    public ExtensiveQuest(string ID) : base(ID) {
      Text = string.Empty;
      ShowWithoutCriteria = false;
    }


    /// <summary>
    /// Check, if the quest is completely defined
    /// </summary>
    /// <returns>DEfinedness of the quest</returns>
    public override bool IsDefined() {
      return (
        base.IsDefined() &&
        Text != string.Empty
      );
    }

    public void AddTask(BaseTask Task) {
      foreach(BaseTask bt in Tasks) {
        if(bt.Name == Task.Name) {
          throw new Exception("Duplicate Task! Name <" + Task.Name + "> already used!");
        }
      }
      Tasks.Add(Task);
    }

    /// <summary>
    /// Determine, if it's necessary to serialize the 'ShowWithoutCriteria'-Member
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeShowWithoutCriteria() {
      return ShowWithoutCriteria;
    }
  }
}

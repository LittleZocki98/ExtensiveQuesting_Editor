using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using ExtensiveQuesting.EnumDescription;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// A list of all valid task IDs
  /// </summary>
  public enum TaskIDs {
    [Description("Kill mobs")]
    kill_mob,

    [Description("Collect items")]
    collect_items,

    [Description("Walk to region(s)")]
    walk,

    [Description("Talk to NPC")]
    talk_to,

    [Description("Time Limit")]
    time_limit
  };

  /// <summary>
  /// Universal task-parent
  /// </summary>
  class BaseTask : BaseItem {

    /// <summary>
    /// Name of the task
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Create a task without an ID
    /// </summary>
    public BaseTask() : base() {
      Name = string.Empty;
    }

    /// <summary>
    /// Create a task with an ID
    /// </summary>
    /// <param name="ID">ID if the task</param>
    public BaseTask(string ID) : base(ID) {
      this.ID = ID;
      Name = string.Empty;
    }

    /// <summary>
    /// Is the task fully defined?
    /// </summary>
    /// <returns>Definedness of the task</returns>
    public bool IsDefined() {
      return (
        ID != string.Empty &&
        Name != string.Empty
      );
    }
  }
}

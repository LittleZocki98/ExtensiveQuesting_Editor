using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem {
  /// <summary>
  /// Universal task-parent
  /// </summary>
  class BaseTask : BaseItem {

    /// <summary>
    /// A list of all valid task IDs
    /// </summary>
    public enum TaskIDs {
      kill_mob,
      collect_items,
      walk,
      talk_to,
      time_limit
    };

    /// <summary>
    /// Name of the task
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Create a task without an ID
    /// </summary>
    public BaseTask() : base() {

    }

    /// <summary>
    /// Create a task with an ID
    /// </summary>
    /// <param name="ID">ID if the task</param>
    public BaseTask(string ID) : base(ID) {
      this.ID = ID;
    }
  }
}

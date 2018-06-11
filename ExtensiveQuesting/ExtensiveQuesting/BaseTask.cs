using Newtonsoft.Json;
using ExtensiveQuesting.QuestingItem.Quest;
using ExtensiveQuesting.EnumDescription;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// A list of all valid task IDs
  /// </summary>
  public enum TaskIDs {
    [Description("Kill Entity")]
    kill_mob,

    [Description("Collect Items")]
    collect_items,

    [Description("Walk to Region(s)")]
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
    /// Parent quest
    /// </summary>
    [JsonIgnore]
    public BaseQuest ParentQuest { get; internal protected set; }

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
    [JsonIgnore]
    public virtual bool IsDefined {
      get {
        return (
          ID != string.Empty &&
          Name != string.Empty
        );
      }
    }
  }
}

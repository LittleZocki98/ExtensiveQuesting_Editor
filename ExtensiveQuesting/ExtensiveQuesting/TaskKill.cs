using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// Killing Task
  /// The contractor has to kill an entity
  /// </summary>
  class TaskKill : BaseTask {

    /// <summary>
    /// How many entities shall be killed?
    /// </summary>
    [JsonProperty("amount")]
    public uint Amount { get; set; }

    /// <summary>
    /// Which entity should be killed?
    /// </summary>
    [JsonProperty("entity")]
    public string Entity { get; set; }

    /// <summary>
    /// Contructor
    /// </summary>
    public TaskKill() : base(TaskIDs.kill_mob.ToString()) {
      Amount = 0;
      Entity = string.Empty;
    }

    /// <summary>
    /// Is the task fully defined?
    /// </summary>
    /// <returns>Definedness of the task</returns>
    [JsonIgnore]
    public override bool IsDefined {
      get {
        return (
          (base.IsDefined) &&
          (Entity != string.Empty)
        );
      }
    }
  }
}

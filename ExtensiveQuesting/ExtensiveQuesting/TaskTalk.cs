using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// Talking Task
  /// The Contractor has to talk to a given NPC
  /// </summary>
  class TaskTalk : BaseTask {

    /// <summary>
    /// The ID of the NPC which should be talked to
    /// </summary>
    [JsonProperty("npc")]
    public string NPC_ID { get; set; }

    /// <summary>
    /// The message the talked to NPC should say when actually talked to
    /// </summary>
    [JsonProperty("npc_message")]
    public string NPC_Message { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public TaskTalk() : base(TaskIDs.talk_to.ToString()) {
      NPC_ID = string.Empty;
      NPC_Message = string.Empty;
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
          (NPC_ID != string.Empty)
        );
      }
    }

    /// <summary>
    /// Determine, if it's necessary to serialize the 'NPC_Message'-Member
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeNPC_Message() {
      return (NPC_Message != string.Empty);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
  }
}

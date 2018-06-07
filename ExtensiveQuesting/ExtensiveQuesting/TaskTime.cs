using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// Time-Limiter
  /// Limits the time for completing the Quest
  /// </summary>
  class TaskTime : BaseTask {

    /// <summary>
    /// Time in Seconds
    /// </summary>
    [JsonProperty("time")]
    public uint Time { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public TaskTime() : base(TaskIDs.time_limit.ToString()) {
      Time = 0;
    }
  }
}

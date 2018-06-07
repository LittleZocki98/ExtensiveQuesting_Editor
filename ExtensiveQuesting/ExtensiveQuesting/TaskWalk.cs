using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// Walking Task
  /// The contractor has to walk to specific regions
  /// </summary>
  class TaskWalk : BaseTask {

    /// <summary>
    /// Regions, which should be walked to
    /// </summary>
    [JsonProperty("regions")]
    public List<string> Regions { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public TaskWalk() : base(TaskIDs.walk.ToString()) {
      Regions = new List<string>();
    }
  }
}

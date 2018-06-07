using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensiveQuesting.QuestingItem.Item;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Task {
  /// <summary>
  /// Collection Task
  /// The contractor has to collect an specified item
  /// </summary>
  class TaskCollect : BaseTask {

    /// <summary>
    /// The item which should be collected
    /// </summary>
    [JsonProperty("item")]
    public QuestItem TaskItem { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public TaskCollect() : base(TaskIDs.collect_items.ToString()) {
      TaskItem = new QuestItem();
    }

    /// <summary>
    /// Is the task fully defined?
    /// </summary>
    /// <returns>Definedness of the task</returns>
    public override bool IsDefined() {
      return (
        (base.IsDefined()) &&
        (TaskItem.ID != string.Empty)
      );
    }
  }
}

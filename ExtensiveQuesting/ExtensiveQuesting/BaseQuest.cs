using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Quest {
  /// <summary>
  /// Universal quest-parent
  /// </summary>
  class BaseQuest : BaseItem {

    /// <summary>
    /// Name of the quest
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

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
    /// Create a base quest without an ID
    /// </summary>
    public BaseQuest() : base() {
      Name = string.Empty;
      Text = string.Empty;
      ShowWithoutCriteria = false;
    }

    /// <summary>
    /// Create a base quest with an ID
    /// </summary>
    /// <param name="ID">ID of the quest</param>
    public BaseQuest(string ID) : base(ID) {
      Name = string.Empty;
      Text = string.Empty;
      ShowWithoutCriteria = false;
    }

    /// <summary>
    /// Is the quest fully defined?
    /// </summary>
    /// <returns>Definedness of the quest</returns>
    public bool IsDefined() {
      return (
        ID != string.Empty &&
        Name != string.Empty
      );
    }

  }
}

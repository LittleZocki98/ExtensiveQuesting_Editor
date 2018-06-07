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
    /// Create a base quest without an ID
    /// </summary>
    public BaseQuest() : base() {
      Name = string.Empty;
    }

    /// <summary>
    /// Create a base quest with an ID
    /// </summary>
    /// <param name="ID">ID of the quest</param>
    public BaseQuest(string ID) : base(ID) {
      Name = string.Empty;
    }

    /// <summary>
    /// Is the quest fully defined?
    /// </summary>
    /// <returns>Definedness of the quest</returns>
    public virtual bool IsDefined() {
      return (
        ID != string.Empty &&
        Name != string.Empty
      );
    }

  }
}

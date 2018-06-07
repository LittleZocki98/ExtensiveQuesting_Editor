using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem {
  class BaseItem {
    /// <summary>
    /// ID of the item
    /// </summary>
    [JsonProperty("id")]
    public virtual string ID { get; set; }

    /// <summary>
    /// Create a base item without an ID
    /// </summary>
    public BaseItem() {
      ID = string.Empty;
    }

    /// <summary>
    /// Create a base item with an ID
    /// </summary>
    /// <param name="ID">ID of the item</param>
    public BaseItem(string ID) {
      this.ID = ID;
    }
  }
}

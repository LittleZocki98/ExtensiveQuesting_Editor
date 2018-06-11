using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Item {
  /// <summary>
  /// 
  /// </summary>
  class QuestItem : BaseItem {

    /// <summary>
    /// How many items?
    /// </summary>
    [JsonProperty("amount")]
    public uint Amount { get; set; }

    /// <summary>
    /// Metadata of the item
    /// </summary>
    [JsonProperty("metadata")]
    public uint Meta { get; set; }

    /// <summary>
    /// NBT-DAta of the item
    /// </summary>
    [JsonProperty("data")]
    public string Data { get; set; }

    /// <summary>
    /// ID of the item
    /// </summary>
    [JsonProperty("item")]
    public override string ID {
      get { return base.ID; }
      set { base.ID = value; }
    }

    /// <summary>
    /// Parent item
    /// </summary>
    [JsonIgnore]
    public BaseItem ParentItem { get; protected internal set; }

    /// <summary>
    /// 
    /// </summary>
    public QuestItem() : base() {
      Amount = 0;
      Meta = 0;
      Data = string.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Name"></param>
    public QuestItem(string Name) : base(Name) {
      Amount = 0;
      Meta = 0;
      Data = string.Empty;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeData() {
      return (Data != string.Empty);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeMeta() {
      return (Meta != 0);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [JsonIgnore]
    public bool IsDefined {
      get {
        return ID != string.Empty;
      }
    }
  }
}

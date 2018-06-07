using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Criterion {
  /// <summary>
  /// Statistic-Criterion
  /// The contructor has to have reached some specific statistic before he/she can accept the quest
  /// </summary>
  class CriterionStatistic : BaseCriterion {

    /// <summary>
    /// The name of the statistic
    /// </summary>
    [JsonProperty("statistic")]
    public string Statistic { get; set; }

    /// <summary>
    /// The value which sould be reached
    /// </summary>
    [JsonProperty("value")]
    public uint Value { get; set; }

    /// <summary>
    /// Specify entity if needed in the statistic
    /// </summary>
    [JsonProperty("entity")]
    public string Entity { get; set; }

    /// <summary>
    /// Specify item if needed in the statistic
    /// </summary>
    [JsonProperty("item")]
    public string Item { get; set; }
    
    /// <summary>
    /// Is the entity needed for this statistic?
    /// </summary>
    [JsonIgnore]
    public bool NeedEntity { get; set; }

    /// <summary>
    /// Is the item needed for this statistic?
    /// </summary>
    [JsonIgnore]
    public bool NeedItem { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CriterionStatistic() : base(CriteriaIDs.statistic.ToString()) {
      Statistic = string.Empty;
      Value = 0;
      Entity = string.Empty;
      Item = string.Empty;

      NeedEntity = false;
      NeedItem = false;
    }

    /// <summary>
    /// Is the criterion fully defined?
    /// </summary>
    /// <returns>Definedness of the criterion</returns>
    public override bool IsDefined() {
      return (
        (base.IsDefined()) &&
        (NeedEntity ? Entity != string.Empty : true) &&
        (NeedItem ? Item != string.Empty : true) &&
        (Statistic != string.Empty)
      );
    }

    public bool ShouldSerializeEntity() {
      return NeedEntity;
    }
    public bool ShouldSerializeItem() {
      return NeedItem;
    }
  }
}

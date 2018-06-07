using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Criterion {
  /// <summary>
  /// QuestComplete-Criterion
  /// The contractor has to have completed another quest in advance to accept this quest
  /// </summary>
  class CriterionQuest : BaseCriterion {

    /// <summary>
    /// ID of the quest which should be completed first
    /// </summary>
    [JsonProperty("quest")]
    public string QuestID { get; set; }

    /// <summary>
    /// Create a criterion without an ID
    /// </summary>
    public CriterionQuest() : base(CriteriaIDs.quest_completed.ToString()) {
      QuestID = string.Empty;
    }

    /// <summary>
    /// Is the criterion fully defined?
    /// </summary>
    /// <returns>Definedness of the criterion</returns>
    public override bool IsDefined() {
      return (
        (base.IsDefined()) &&
        (QuestID != string.Empty)
      );
    }
  }
}

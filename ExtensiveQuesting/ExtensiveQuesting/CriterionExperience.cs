using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Criterion {
  /// <summary>
  /// Experience-Criterion
  /// The contractor has to have the given amount of experience to accept the quest
  /// </summary>
  class CriterionExperience : BaseCriterion {

    /// <summary>
    /// The amount of experience which is required
    /// </summary>
    [JsonProperty("experience")]
    public uint Experience { get; set; }

    /// <summary>
    /// The amount of levels which are required
    /// </summary>
    [JsonProperty("level")]
    public uint Level { get; set; }

    /// <summary>
    /// Require levels or experience?
    /// </summary>
    [JsonIgnore]
    public bool IsLevel { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CriterionExperience() : base(CriteriaIDs.experience.ToString()) {
      Experience = 0;
      Level = 0;
      IsLevel = false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeExperience() {
      return !IsLevel;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeLevel() {
      return IsLevel;
    }

  }
}

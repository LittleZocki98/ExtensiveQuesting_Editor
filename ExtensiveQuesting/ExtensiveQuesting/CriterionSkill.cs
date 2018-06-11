using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Criterion {

  /// <summary>
  /// 
  /// </summary>
  class CriterionSkill : BaseCriterion {

    /// <summary>
    /// Skill which should be checked
    /// </summary>
    [JsonProperty("skill_type")]
    public string Skill { get; set; }

    /// <summary>
    /// Level which the user should possess or exceed
    /// </summary>
    [JsonProperty("level")]
    public uint Level { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CriterionSkill() : base(CriteriaIDs.skill.ToString()) {
      Skill = string.Empty;
      Level = 0;
    }

    /// <summary>
    /// Is the criterion fully defined?
    /// </summary>
    /// <returns>Definedness of the task</returns>
    [JsonIgnore]
    public override bool IsDefined {
      get {
        return (
          (base.IsDefined) &&
          (Skill != string.Empty)
        );
      }
    }
  }
}

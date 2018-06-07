using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Criterion {

  /// <summary>
  /// Permission-Criterion
  /// The contructor has to have a certain perission to accept this quest
  /// </summary>
  class CriterionPermission : BaseCriterion {

    /// <summary>
    /// The permission which the user should possess
    /// </summary>
    [JsonProperty("permission")]
    public string Permission { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public CriterionPermission() : base(CriteriaIDs.permission.ToString()) {
      Permission = string.Empty;
    }

    /// <summary>
    /// Is the criterion fully defined?
    /// </summary>
    /// <returns>Definedness of the criterion</returns>
    public override bool IsDefined() {
      return (
        (base.IsDefined()) &&
        (Permission != string.Empty)
      );
    }

  }
}

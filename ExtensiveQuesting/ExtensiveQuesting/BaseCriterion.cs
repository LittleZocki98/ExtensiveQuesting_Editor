using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensiveQuesting.QuestingItem;
using ExtensiveQuesting.QuestingItem.Quest;
using ExtensiveQuesting.EnumDescription;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Criterion {

  /// <summary>
  /// A list of all valid criterion IDs
  /// </summary>
  public enum CriteriaIDs {
    [Description("Complete Quest")]
    quest_completed,

    [Description("Reach Experience")]
    experience,

    [Description("Reach sStatistic")]
    statistic,

    [Description("Have Permission")]
    permission,

    [Description("Reach Skill")]
    skill
  };

  /// <summary>
  /// Universal criterion-parent
  /// </summary>
  class BaseCriterion : BaseItem {

    /// <summary>
    /// Name of the Criterion
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Parent quest
    /// </summary>
    [JsonIgnore]
    public BaseQuest ParentQuest { get; internal protected set; }

    /// <summary>
    /// Create a criterion without an ID
    /// </summary>
    public BaseCriterion() : base() {
      Name = string.Empty;
    }
    /// <summary>
    /// Create a criterion with an ID
    /// </summary>
    /// <param name="ID">The criterions ID</param>
    public BaseCriterion(string ID) : base(ID) {
      Name = string.Empty;
    }

    /// <summary>
    /// Is the criterion fully defined?
    /// </summary>
    /// <returns>Definedness of the task</returns>
    public virtual bool IsDefined() {
      return (
        ID != string.Empty &&
        Name != string.Empty
      );
    }
  }
}

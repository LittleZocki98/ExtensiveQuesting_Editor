using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Reward {
  /// <summary>
  /// Skill Reward
  /// The contractor will get skillpoints for a specific skill when this quest is completed
  /// </summary>
  class RewardSkill : BaseReward {

    /// <summary>
    /// This skill shall be affected
    /// </summary>
    [JsonProperty("skill_type")]
    public string Skill { get; set; }

    /// <summary>
    /// The amount of skillpoints which shall be rewarded
    /// </summary>
    [JsonProperty("amount")]
    public uint Amount { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public RewardSkill() : base(RewardIDs.skill.ToString()) {
      Skill = string.Empty;
      Amount = 0;
    }

    /// <summary>
    /// Is the reward fully defined?
    /// </summary>
    /// <returns>Definedness of the reward</returns>
    public override bool IsDefined() {
      return (
        (base.IsDefined()) &&
        (Skill != string.Empty)
      );
    }
  }
}

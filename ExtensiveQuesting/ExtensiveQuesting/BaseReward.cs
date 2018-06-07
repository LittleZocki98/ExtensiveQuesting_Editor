using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensiveQuesting.EnumDescription;
using ExtensiveQuesting.QuestingItem;
using ExtensiveQuesting.QuestingItem.Quest;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Reward {

  /// <summary>
  /// A list of all valid reward IDs
  /// </summary>
  public enum RewardIDs {
    [Description("Execute Command")]
    command,

    [Description("Give Items")]
    item,

    [Description("Give Experience")]
    experience,

    [Description("Level Skill")]
    skill
  };

  /// <summary>
  /// Universal reward-parent
  /// </summary>
  class BaseReward : BaseItem {

    /// <summary>
    /// Parent quest
    /// </summary>
    [JsonIgnore]
    public BaseQuest ParentQuest { get; internal protected set; }

    /// <summary>
    /// Create a reward without an ID
    /// </summary>
    public BaseReward() : base() { }

    /// <summary>
    /// Create an reward with an ID
    /// </summary>
    /// <param name="ID">The reward's ID</param>
    public BaseReward(string ID) : base(ID) { }

    /// <summary>
    /// Is the reward fully defined?
    /// </summary>
    /// <returns>Definedness of the reward</returns>
    public virtual bool IsDefined() {
      return ID != string.Empty;
    }
  }
}

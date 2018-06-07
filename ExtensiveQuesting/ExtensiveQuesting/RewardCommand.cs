using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Reward {

  /// <summary>
  /// Command Reward
  /// A command will be executed when the contractor finishes this quest
  /// </summary>
  class RewardCommand : BaseReward {

    /// <summary>
    /// The command which shall be executed
    /// </summary>
    [JsonProperty("command")]
    public string Command { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public RewardCommand() : base(RewardIDs.command.ToString()) {
      Command = string.Empty;
    }

    /// <summary>
    /// Is the reward fully defined?
    /// </summary>
    /// <returns>Definedness of the reward</returns>
    public override bool IsDefined() {
      return (
        (base.IsDefined()) &&
        (Command != string.Empty)
      );
    }
  }
}

﻿using Newtonsoft.Json;

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
    [JsonIgnore]
    public override bool IsDefined {
      get {
        return (
          (base.IsDefined) &&
          (Command != string.Empty)
        );
      }
    }
  }
}

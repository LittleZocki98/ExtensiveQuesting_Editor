using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Reward {
  /// <summary>
  /// Experience Reward
  /// The contructor gets some experience after finishing the quest
  /// </summary>
  class RewardExperience : BaseReward {

    /// <summary>
    /// The amount of Experience the user gets
    /// </summary>
    [JsonProperty("experience")]
    public uint Experience { get; set; }
    
    /// <summary>
    /// Constructor
    /// </summary>
    public RewardExperience() : base(RewardIDs.experience.ToString()) {
      Experience = 0;
    }
  }
}

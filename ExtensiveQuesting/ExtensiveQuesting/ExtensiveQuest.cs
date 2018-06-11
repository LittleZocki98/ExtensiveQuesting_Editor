using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ExtensiveQuesting.QuestingItem.Criterion;
using ExtensiveQuesting.QuestingItem.Task;
using ExtensiveQuesting.QuestingItem.Reward;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Quest {
  /// <summary>
  /// 
  /// </summary>
  class ExtensiveQuest : BaseQuest {

    /// <summary>
    /// Introduction text of the quest
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// Should the quest be visible when the criteria were not reached yet?
    /// </summary>
    [JsonProperty("show_without_criteria")]
    public bool ShowWithoutCriteria { get; set; }

    /// <summary>
    /// List of all criteria
    /// </summary>
    [JsonProperty("criteria")]
    public List<BaseCriterion> Criteria { get; } = new List<BaseCriterion>();

    /// <summary>
    /// List of all tasks
    /// </summary>
    [JsonProperty("tasks")]
    public List<BaseTask> Tasks { get; } = new List<BaseTask>();

    /// <summary>
    /// List of all rewards
    /// </summary>
    [JsonProperty("rewards")]
    public List<BaseReward> Rewards { get; } = new List<BaseReward>();

    /// <summary>
    /// List of all criteria, tasks and rewards combined
    /// </summary>
    [JsonIgnore]
    public ObservableCollection<BaseItem> Children {
      get {
        List<BaseItem> o = new List<BaseItem>();
        o.AddRange(Criteria);
        o.AddRange(Tasks);
        o.AddRange(Rewards);
        return new ObservableCollection<BaseItem>(o);
      }
    }

    /// <summary>
    /// Create a quest without an ID
    /// </summary>
    public ExtensiveQuest() : base() {
      Text = string.Empty;
      ShowWithoutCriteria = false;
    }

    /// <summary>
    /// Create a quest with an ID
    /// </summary>
    /// <param name="ID">ID of the quest</param>
    public ExtensiveQuest(string ID) : base(ID) {
      Text = string.Empty;
      ShowWithoutCriteria = false;
    }

    /// <summary>
    /// Check, if the quest is completely defined
    /// </summary>
    /// <returns>DEfinedness of the quest</returns>
    [JsonIgnore]
    public override bool IsDefined {
      get {
        foreach(BaseCriterion i in Criteria) {
          if (!i.IsDefined) {
            return false;
          }
        }

        foreach(BaseTask i in Tasks) {
          if(!i.IsDefined) {
            return false;
          }
        }

        foreach(BaseReward i in Rewards) {
          if(!i.IsDefined) {
            return false;
          }
        }

        return (
          (base.IsDefined) &&
          (Text != string.Empty)
        );
      }
    }

    /// <summary>
    /// Add a criterion to this quest
    /// </summary>
    /// <param name="Criterion">Criterion which should be added</param>
    public void AddCriterion(BaseCriterion Criterion) {
      foreach(BaseCriterion bc in Criteria) {
        if(bc.Name == Criterion.Name) {
          throw new Exception("Duplicate Criterion! Name <" + Criterion.Name + "> already used!");
        }
      }
      Criterion.ParentQuest = this;
      Criteria.Add(Criterion);
    }

    /// <summary>
    /// Remove a Criterion from this quest
    /// </summary>
    /// <param name="Criterion">Criterion which should be removed</param>
    public void RemoveCriterion(BaseCriterion Criterion) {
      if(Criteria.Contains(Criterion)) {
        Criteria.Remove(Criterion);
      }
    }

    /// <summary>
    /// Add a task to this quest
    /// </summary>
    /// <param name="Task">Task which should be added</param>
    public void AddTask(BaseTask Task) {
      foreach(BaseTask bt in Tasks) {
        if(bt.Name == Task.Name) {
          throw new Exception("Duplicate Task! Name <" + Task.Name + "> already used!");
        }
      }
      Task.ParentQuest = this;
      Tasks.Add(Task);
    }

    /// <summary>
    /// Remove a reward from this quest
    /// </summary>
    /// <param name="Task">Task which should be removed</param>
    public void RemoveTask(BaseTask Task) {
      if(Tasks.Contains(Task)) {
        Tasks.Remove(Task);
      }
    }

    /// <summary>
    /// Add a reward to this quest
    /// </summary>
    /// <param name="Reward">Reward which shuld be added</param>
    public void AddReward(BaseReward Reward) {
      Reward.ParentQuest = this;
      Rewards.Add(Reward);
    }

    /// <summary>
    /// Remove a reward from this quest
    /// </summary>
    /// <param name="Reward">Reward which should be removed</param>
    public void RemoveReward(BaseReward Reward) {
      if(Rewards.Contains(Reward)) {
        Rewards.Remove(Reward);
      }
    }

    /// <summary>
    /// Determine, if it's necessary to serialize the 'ShowWithoutCriteria'-Member
    /// </summary>
    /// <returns></returns>
    public bool ShouldSerializeShowWithoutCriteria() {
      return ShowWithoutCriteria;
    }
  }
}

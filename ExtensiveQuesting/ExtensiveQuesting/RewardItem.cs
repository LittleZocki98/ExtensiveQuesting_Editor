﻿using System.Collections.Generic;
using ExtensiveQuesting.QuestingItem.Item;
using Newtonsoft.Json;

namespace ExtensiveQuesting.QuestingItem.Reward {
  class RewardItem : BaseReward {

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("items")]
    public List<QuestItem> Items { get; } = new List<QuestItem>();

    /// <summary>
    /// 
    /// </summary>
    public RewardItem() : base(RewardIDs.item.ToString()) {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Item"></param>
    public void AddItem(QuestItem Item) {
      Item.ParentItem = this;
      Items.Add(Item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Item"></param>
    public void RemoveItem(QuestItem Item) {
      Items.Remove(Item);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [JsonIgnore]
    public override bool IsDefined {
      get {
        foreach(QuestItem i in Items) {
          if(!i.IsDefined) {
            return false;
          }
        }
        return base.IsDefined;
      }
    }
  }
}

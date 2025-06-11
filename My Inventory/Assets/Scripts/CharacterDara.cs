
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class CharacterData
{
   public int Attack { get; private set; }
   public int Defense { get; private set; }
   public int HP { get; private set; }
   public float Critical { get; private set; }

   public CharacterData(int attack, int defense, int hp, float critical)
   {
      Attack = attack;
      Defense = defense;
      HP = hp;
      Critical = critical;
   }
   public List<ItemData> Inventory { get; private set; } = new List<ItemData>();
   private List<ItemData> equippedItems = new List<ItemData>();
   //장착
   public void Equip(ItemData item)
   {
      if (equippedItems.Contains(item))
      {
         equippedItems.Remove(item);
         RemoveItem(item);
      }
      else
      {
         equippedItems.Add(item);
         AddItem(item);

      }
   }
   //장착시 능력치 증가
   private void AddItem(ItemData item) 
   {
      Attack += item.attackBonus;
      Defense += item.defenseBonus;
      HP += item.hpBonus;
      Critical += item.criticalBonus;
   }
   //장착 해제시 능력치 감소
   private void RemoveItem(ItemData item)
   {
      Attack -= item.attackBonus;
      Defense -= item.defenseBonus;
      HP -= item.hpBonus;
      Critical -= item.criticalBonus;
   }
   //장착 여부
   public bool IsEquipped(ItemData item)
   {
      return equippedItems.Contains(item);
   }

}

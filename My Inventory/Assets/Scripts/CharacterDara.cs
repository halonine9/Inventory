
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


}

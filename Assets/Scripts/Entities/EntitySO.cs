using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Entity", menuName = "Entity", order = 0)]
public class EntitySO : BasicInfoSO
{
    public Era era;

    // public SpriteHolders spriteHolders;

    public int health;
    [Range(0f, 1f)] public float healthRegeneration;
    public int defence;
    [Range(0f, 1f)] public float dodgeChance;

    public float movementSpeed;

    // public struct SpriteHolders {
    //     EntityState state;
    //     public List<Sprite> animation;
    // }
}
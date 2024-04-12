using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Entity/Character", order = 0)]
public class CharacterSO : EntitySO
{
    public float pickupRadius;
    [Range(0f, 1f)] public float prosperity;
    public List<SkillSO> skill = new List<SkillSO>();
}
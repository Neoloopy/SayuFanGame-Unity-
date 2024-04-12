using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDatabaseSO", menuName = "Items/Weapons/WeaponDatabase", order = 0)]
public class WeaponDatabaseSO : ScriptableObject {
    public List<WeaponSO> weapons;
}
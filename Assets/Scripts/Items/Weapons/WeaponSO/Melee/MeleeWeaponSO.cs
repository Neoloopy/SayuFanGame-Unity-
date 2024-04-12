using UnityEngine;

[CreateAssetMenu(fileName = "MeleeWeaponSO", menuName = "Items/Weapons/MeleeWeaponSO", order = 0)]
public class MeleeWeaponSO : WeaponSO {
    public WeaponType type = WeaponType.Melee;
}
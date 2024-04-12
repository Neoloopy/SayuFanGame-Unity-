using UnityEngine;

[CreateAssetMenu(fileName = "RangeWeaponSO", menuName = "Items/Weapons/RangeWeaponSO", order = 0)]
public class RangeWeaponSO : WeaponSO {
    public WeaponType type = WeaponType.Range;
    public GameObject projectilePrefab;
}
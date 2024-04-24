using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OrbiralWeaponSO", menuName = "Items/Weapons/OrbiralWeaponSO", order = 0)]
public class OrbitalWeaponSO : WeaponSO {
    public WeaponType type = WeaponType.Orbital;
    public GameObject projectilePrefab;
    public override void Attack(Transform point){
        var pointTransform = point.transform;
        GameObject projectile = Instantiate(projectilePrefab, pointTransform.position + Vector3.up, pointTransform.rotation, pointTransform);
        projectile.GetComponent<RotateAroundObject>().point = point;
    }
}
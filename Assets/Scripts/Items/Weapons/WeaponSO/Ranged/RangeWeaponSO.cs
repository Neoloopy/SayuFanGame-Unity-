using UnityEngine;

[CreateAssetMenu(fileName = "RangeWeaponSO", menuName = "Items/Weapons/RangeWeaponSO", order = 0)]
public class RangeWeaponSO : WeaponSO {
    public WeaponType type = WeaponType.Range;
    public GameObject projectilePrefab;
    public override void Attack(Transform point){
        GameObject projectile = Instantiate(projectilePrefab, point.transform.position, point.transform.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(projectile.transform.up * 10f, ForceMode2D.Impulse);
    }
}
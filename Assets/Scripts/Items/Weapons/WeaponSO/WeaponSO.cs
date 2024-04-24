using UnityEngine;
public class WeaponSO : ItemSO {
    public StatusEffects effect;
    
    public int damage;
    public float critRate;
    public int critDamage;
    public virtual void Attack(Transform point){}

    public float attackSpeed;
    public float attackDelay;

    public int hitLimit;
    public int hitCooldown;
    public int radius;

    public virtual void Cooldown(){}
}
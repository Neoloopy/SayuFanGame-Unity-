using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]
public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField] int finalDamage;
    [SerializeField] float cooldownTimer;
    // TODO: object pool the ammo
    void Start() {
        if(cooldownTimer > 0)
            Destroy(this.gameObject, cooldownTimer); 
    }
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="origin">The origin Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D origin)
    {
        if(origin.tag != "Enemy"){ return; }
        origin.gameObject.GetComponent<EntityHealth>().TakeDamage(finalDamage);
    }
}

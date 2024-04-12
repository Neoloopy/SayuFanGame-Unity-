using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRangeDisplay : MonoBehaviour
{
    [SerializeField] float attackRange;
    private void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(this.gameObject.transform.position, attackRange);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour
{
    [SerializeField] WeaponSO weapon;
    [SerializeField] Transform point;
    bool hasOrb = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AttackCycle());
    }

    IEnumerator AttackCycle()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            weapon.Attack(point);
            Debug.Log("attack cycled");
        }
    }
}

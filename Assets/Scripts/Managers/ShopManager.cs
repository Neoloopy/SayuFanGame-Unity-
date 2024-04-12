using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] ArtifactManager artifactManager;
    [SerializeField] WeaponManager weaponManager;
    void Awake()
    {
        if (artifactManager == null)
            artifactManager = gameObject.GetComponent<ArtifactManager>();
        if (weaponManager == null)
            weaponManager = gameObject.GetComponent<WeaponManager>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Handles the gacha system of weapons
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _pointer;
    [SerializeField] List<GameObject> weapons = new List<GameObject>();
}

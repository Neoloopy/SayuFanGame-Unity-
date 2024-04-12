using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactManager : MonoBehaviour
{
    // technically an inventory system for the player
    // the gacha manager handles the logic of which
    // objects to instantiate
    [SerializeField] GameObject _player;
    [SerializeField] List<ArtifactSO> artifacts = new List<ArtifactSO>();
}

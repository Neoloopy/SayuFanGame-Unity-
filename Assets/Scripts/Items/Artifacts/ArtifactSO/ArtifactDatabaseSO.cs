using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArtifactDatabaseSO", menuName = "Items/Artifacts/ArtifactDatabase", order = 0)]
public class ArtifactDatabaseSO : ScriptableObject {
    List<ArtifactSO> artifact;
}
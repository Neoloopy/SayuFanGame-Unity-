using UnityEngine;

[CreateAssetMenu(fileName = "Artifacts", menuName = "Items/Artifacts", order = 0)]
public class ArtifactSO : ItemSO {
    public ArtifactType type;

    public virtual void Modifier(){}
}
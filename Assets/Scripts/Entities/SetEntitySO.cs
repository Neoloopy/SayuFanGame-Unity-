using UnityEngine;

public class SetEntitySO : MonoBehaviour
{
    [SerializeField] EntitySO entity;
    public EntitySO SetEntity { set { entity = value; } }
    public EntitySO GetEntity { get { return entity; } }
}
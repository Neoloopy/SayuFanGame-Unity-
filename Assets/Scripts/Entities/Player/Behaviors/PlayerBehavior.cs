using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] EntityState state = EntityState.Idle;
    CharacterSO character;
    public CharacterSO GetCharacter { get { return character; } }
    PlayerControls controls;
    IMovement _movement;

    void Awake()
    {
        _movement = GetComponent<IMovement>();
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        OnEnable();
        controls.Player.Movement.performed += _ => _movement.Move(_.ReadValue<Vector2>());
        controls.Player.Movement.canceled += _ => _movement.Move(Vector2.zero);

        character = (CharacterSO)gameObject.GetComponent<SetEntitySO>().GetEntity;
    }
}

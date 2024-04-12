using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MovementControl : MonoBehaviour, IMovement
{
    Rigidbody2D _rb2d;
    public Vector2 getDirection { get; private set; }
    private float speed = 1;
    private float bonusSpeed = 1;
    private void Awake()
    {
        _rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        speed = gameObject.GetComponent<PlayerBehavior>().GetCharacter.movementSpeed;
    }
    public void Move(Vector2 direction)
    {
        getDirection = direction;

        var finalSpeed = speed * bonusSpeed;
        _rb2d.velocity = direction * finalSpeed;
    }
}

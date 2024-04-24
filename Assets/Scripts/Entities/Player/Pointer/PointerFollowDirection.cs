using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerFollowDirection : MonoBehaviour, IPointer
{
    MovementControl control;
    Transform playerPos;
    [SerializeField] bool isMouseControlling = false;
    Vector2 _direction;
    void Start()
    {
        control = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementControl>();
        playerPos = gameObject.transform.parent;
    }
    private void Update()
    {
        var mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _direction = isMouseControlling ? mousePos : control.GetDirection;
        _direction.Normalize();
        MoveToDirection(_direction);
    }
    public void ChangeMode()
    {
        isMouseControlling = isMouseControlling ? false : true;
    }
    private void MoveToDirection(Vector2 direction)
    {
        if (direction == Vector2.zero) return;
        transform.position = direction + (Vector2)playerPos.position;
        // change rotation
        var angle = (Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg);
        transform.rotation = Quaternion.Inverse(Quaternion.AngleAxis(angle, Vector3.forward));
    }
}

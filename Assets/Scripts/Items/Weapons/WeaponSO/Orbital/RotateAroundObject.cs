using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundObject : MonoBehaviour
{
    public Transform point;

    [SerializeField] float speed;
    private void Start() {
        
    }
    void Update()
    {
        this.transform.RotateAround(point.position, Vector3.forward + point.position, speed * Time.deltaTime);
    }
}

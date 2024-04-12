using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // TODO: rewrite all into their own modules
    [SerializeField] Vector2 target;
    [SerializeField] EnemySO entity;
    [SerializeField] Transform player;


    void Start()
    {
        // player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        // target = new Vector2(0,0);
        entity = (EnemySO)gameObject.GetComponent<SetEntitySO>().GetEntity;
    }
    // enemy movement
    void Update()
    {
        // !temporary fix until I instantiate using the entity spawner
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        else
            target = player.position;

        float step = entity.movementSpeed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
    // enemy base combat mechanics
    void OnTriggerEnter2D(Collider2D origin)
    {
        if (origin.tag == gameObject.tag) return;
        origin.gameObject.GetComponent<EntityHealth>().TakeDamage(10);
    }
}

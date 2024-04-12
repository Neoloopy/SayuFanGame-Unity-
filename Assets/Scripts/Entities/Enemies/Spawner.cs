using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _playerPosition;
    [SerializeField] int borderHeight = 0;
    [SerializeField] int borderWidth = 0;
    [SerializeField] int negativeBorderHeight = 0;
    [SerializeField] int negativeBorderWidth = 0;
    [SerializeField] float spawnRate = 0f;
    [SerializeField] List<Transform> spawnpoints = new List<Transform>();
    void Start()
    {
        Camera cam = Camera.main;
        _playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        borderHeight = (int)(2f * cam.orthographicSize);
        borderWidth = (int)(borderHeight * cam.aspect);
        negativeBorderHeight = -(borderHeight);
        negativeBorderWidth = -(borderWidth);

        Queue<int> borderHeightPositions = new Queue<int>();
        Queue<int> borderWidthPositions = new Queue<int>();
        // positive positive
        borderHeightPositions.Enqueue(borderHeight);
        borderWidthPositions.Enqueue(borderWidth);
        // negative positive
        borderWidthPositions.Enqueue(negativeBorderWidth);
        borderHeightPositions.Enqueue(borderHeight);
        // positive negative
        borderWidthPositions.Enqueue(borderWidth);
        borderHeightPositions.Enqueue(negativeBorderHeight);
        // negative negative
        borderHeightPositions.Enqueue(negativeBorderHeight);
        borderWidthPositions.Enqueue(negativeBorderWidth);

        foreach (Transform point in spawnpoints)
        {
            var xPos = borderWidthPositions.Dequeue();
            var yPos = borderHeightPositions.Dequeue();
            point.position = new Vector2(xPos, yPos);
        }

        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while(true){
            yield return new WaitForSeconds(spawnRate);
            this.transform.position = _playerPosition.position;
            foreach (Transform point in spawnpoints)
            {
                GameObject enemy = Instantiate(_prefab);
                enemy.transform.position = point.position;
            }
        }
    }
}

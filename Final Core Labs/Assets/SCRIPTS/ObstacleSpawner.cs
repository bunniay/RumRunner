using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 5f;

    private readonly float[] lanes = { 2f, 0f, -2f };

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnRate);
    }

    void SpawnObstacle()
    {
        float laneY = lanes[Random.Range(0, lanes.Length)];
        Vector3 spawnPos = new(transform.position.x, laneY, 0);

        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
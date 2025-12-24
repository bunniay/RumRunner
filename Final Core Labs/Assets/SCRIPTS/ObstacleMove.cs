using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * GameManager.instance.gameSpeed * Time.deltaTime);

        if (transform.position.x < -15f)
            Destroy(gameObject);
    }
}
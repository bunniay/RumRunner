using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5f;

    // Lane positions
    private float[] laneY = { 2f, 0f, -2f };
    private int currentLane = 1; // start in middle lane
    void Update()
    {
        // Up / Down lane switching
        if (Input.GetKeyDown(KeyCode.UpArrow))
            currentLane = Mathf.Clamp(currentLane + 1, 0, laneY.Length - 1);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            currentLane = Mathf.Clamp(currentLane - 1, 0, laneY.Length - 1);

        // Apply vertical position
        Vector3 pos = transform.position;
        pos.y = laneY[currentLane];
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.instance.GameOver();
        }
    }
}
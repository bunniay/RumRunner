using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5f;

    // Lane positions
    private float[] lanes = { 2f, 0f, -2f };
    private int currentLane = 1; // start in middle lane

    void Update()
    {
        // Constant forward movement
        transform.Translate(Vector2.right * forwardSpeed * Time.deltaTime);

        // Move up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentLane > 0)
                currentLane--;
        }

        // Move down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentLane < lanes.Length - 1)
                currentLane++;
        }

        // Move car to lane
        Vector3 pos = transform.position;
        pos.y = lanes[currentLane];
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
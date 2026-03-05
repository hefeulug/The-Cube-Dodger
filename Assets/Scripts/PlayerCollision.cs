using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public void stop()
    {
        movement.enabled = false;
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            stop();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

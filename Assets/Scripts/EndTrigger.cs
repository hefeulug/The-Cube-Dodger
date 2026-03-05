using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter() {
        gameManager.completeLevel();
        FindObjectOfType<PlayerCollision>().stop();
    }
}
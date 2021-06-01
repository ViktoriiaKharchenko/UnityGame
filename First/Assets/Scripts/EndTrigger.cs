using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement playerMovement;
    void OnTriggerEnter()
    {
        playerMovement.gravityForce = 5f;
        gameManager.CompleteLevel();
    }
}

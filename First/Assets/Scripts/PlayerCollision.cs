using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "End")
        {
            Debug.Log(">>>>>>gravity off");
            playerMovement.gravityForce = 10f;
            //playerMovement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
        }
    }
}

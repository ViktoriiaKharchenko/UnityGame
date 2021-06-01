
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Joystick joystick;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public float countdown = 4f;
    public float jumpForce = 1000f;
    public float gravityForce = -1000f;
    private bool isgrounded = false;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (countdown > 0f)
        {
            countdown -= Time.deltaTime;
            return;
        }        

        //add a forward force
        //rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
        float step = joystick.Horizontal;
        //float up = joystick.Vertical>0.7 && isOnGround()? joystick.Vertical:0;
        //Debug.Log(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" + step);
        
        rigidbody.AddForce(0, gravityForce* rigidbody.mass, forwardForce* rigidbody.mass * Time.deltaTime, ForceMode.Force);
        rigidbody.AddForce(step * sideForce* rigidbody.mass* Time.deltaTime, gravityForce, 0, ForceMode.Force);
        //rigidbody.velocity=new Vector3(step * sideForce * Time.deltaTime, 0, forwardForce * Time.deltaTime);
        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void Jump()
    {
        Debug.Log("gumped");
        if (isgrounded)
        {
            Debug.Log("isgrounded>>" + isgrounded);
            rigidbody.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "floor")
        {
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "floor")
        {
            isgrounded = false;
        }
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 2000f;
    public float sidewayForce = 400f;
    public Rigidbody rb;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        forwardForce += 0.02f;

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    [SerializeField] float forwardForce = 500f;
    [SerializeField] float sideForce = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardForce*Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rigidBody.position.y < 0.5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

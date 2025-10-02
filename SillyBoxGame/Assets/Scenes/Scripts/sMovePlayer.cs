using UnityEngine;

public class sMovePlayer : MonoBehaviour
{

    private int forwardMove = 1;
    private int backwardMove = 0;
    private int rightMove = 0;
    private int leftMove = 0;

    public float range = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKeyUp(KeyCode.D) )
        {
            transform.position += new Vector3(0, 0, 2);
            rightMove++;
        }

        if (Input.GetKeyUp(KeyCode.A) )
        {
            transform.position += new Vector3(0, 0, -2);
            transform.Rotate(0, 90, 0);
            leftMove++;
        }

        if (Input.GetKeyUp(KeyCode.W) )
        {
            transform.position += new Vector3(-2, 0, 0);
            forwardMove++;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += new Vector3(2, 0, 0);
            backwardMove++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Green")
        {
            print("Entered");
        }

        if (other.gameObject.tag == "Red")
        {
            print("Stopped");
        }
    }

    void RayCastCollision()
    {
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction*range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

        if (Physics.Raycast(theRay,out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Border")
            {
                print("The Border");
            }
        }

    }
}

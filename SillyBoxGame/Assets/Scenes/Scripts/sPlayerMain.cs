using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class sPlayerMain : MonoBehaviour
{
    public sMovePlayer movePlayer;
    public float range = 3;

    public int playerMoney = 100;
    public bool playerWin = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RayCastCollision();

        if ((Input.GetKeyUp(KeyCode.Escape)))
        {
            Application.Quit();
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
            playerMoney -= 10;
        }

        if (other.gameObject.tag == "WinToken")
        {
            playerMoney += 100;
            playerWin = true;
            
        }
    }

    void moneyManager()
    {
        
    }

    void RayCastCollision()
    {
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

        if (Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Border")
            {
                print("The Border");
                movePlayer.canMove = false;
            }

            else
            {
                movePlayer.canMove = true;
            }
        }



    }
}

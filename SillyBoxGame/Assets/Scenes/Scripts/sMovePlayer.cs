using UnityEngine;

public class sMovePlayer : MonoBehaviour
{
    public sPlayerMain playerMain;

    public bool canMove = true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMain.playerWin == false)
        {
            PlayerMovement();
        }
        else
        {
           
        }
        

    }

    void PlayerMovement()
    {
        if (Input.GetKeyUp(KeyCode.D) )
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            if (canMove == true)
            {
                transform.position += new Vector3(0, 0, 2);
            }
            
            

        }

        if (Input.GetKeyUp(KeyCode.A) )
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            if (canMove == true)
            {
                transform.position += new Vector3(0, 0, -2);
            }
                
            

        }

        if (Input.GetKeyUp(KeyCode.W) )
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            if (canMove == true)
            {
                transform.position += new Vector3(-2, 0, 0);
            }
            

        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            if (canMove == true)
            {
                transform.position += new Vector3(2, 0, 0);
            }
            

        }
    }

    
}

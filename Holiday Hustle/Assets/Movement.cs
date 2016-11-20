using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public Camera camera;
    private float speed = 0.1f;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        // Movement
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 newPos = new Vector3(
                transform.position.x,
                transform.position.y + speed,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 newPos = new Vector3(
                transform.position.x,
                transform.position.y - speed,
                transform.position.z);
            transform.position = newPos;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 newPos = new Vector3(
                transform.position.x - speed,
                transform.position.y,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 newPos = new Vector3(
                transform.position.x + speed, 
                transform.position.y, 
                transform.position.z);
            transform.position = newPos;
        }

        // Move to new position
        

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
            print("SHOOT");

        // Rotate
        FollowTarget(Input.mousePosition);

=======
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            print("UP");
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
            transform.position = newPos;
        }
            
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            print("Down");
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            transform.position = newPos;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            print("LEFT");
            Vector3 newPos = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            print("RIGHT");
            Vector3 newPos = new Vector3(transform.position.x + 0.5F, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
>>>>>>> refs/remotes/origin/master
    }

    void FollowTarget(Vector3 targetPos)
    {
        Vector3 mousePosition = camera.ScreenToWorldPoint(new Vector3(targetPos.x, targetPos.y, targetPos.z - camera.transform.position.z));
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg);
    }

}

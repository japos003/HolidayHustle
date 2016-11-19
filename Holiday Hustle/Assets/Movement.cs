using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    float speed = 6.0f;
    float cameraDistance = 10f;
    Vector3 moveDirection = Vector3.zero;
    public Camera camera;

    public Transform target;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        // Movement
        
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Vector3 newPos = new Vector3(
                transform.position.x,
                transform.position.y + 1,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Vector3 newPos = new Vector3(
                transform.position.x,
                transform.position.y - 1,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Vector3 newPos = new Vector3(
                transform.position.x - 1,
                transform.position.y,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Vector3 newPos = new Vector3(
                transform.position.x + 1, 
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

    }

    void FollowTarget(Vector3 targetPos)
    {
        Vector3 mousePosition = camera.ScreenToWorldPoint(new Vector3(targetPos.x, targetPos.y, targetPos.z - camera.transform.position.z));
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg);
    }

}

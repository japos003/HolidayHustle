using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Camera camera;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        // Movement

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 newPos = new Vector3(
                transform.position.x,
                transform.position.y + 0.1f,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 newPos = new Vector3(
                transform.position.x,
                transform.position.y - 0.1f,
                transform.position.z);
            transform.position = newPos;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 newPos = new Vector3(
                transform.position.x - 0.1f,
                transform.position.y,
                transform.position.z);
            transform.position = newPos;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 newPos = new Vector3(
                transform.position.x + 0.1f,
                transform.position.y,
                transform.position.z);
            transform.position = newPos;
        }

        // Move to new position


        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
            print("SHOOT");

        // Rotate
        FollowMouse(Input.mousePosition);

    }

    void FollowMouse(Vector3 targetPos)
    {
        Vector3 mousePosition = camera.ScreenToWorldPoint(new Vector3(targetPos.x, targetPos.y, targetPos.z - camera.transform.position.z));
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}


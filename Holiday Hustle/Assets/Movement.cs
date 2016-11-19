using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
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
    }
}

using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    //Enemy Health
    //int health = 0;
    public GameObject player;

	// Use this for initialization
	void Start () {
        //health = 100;
        //player = 
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Moving object");
        if(player)
        {
            //Must face the player, and will shoot at a specific time
            Vector3 newPos;
            if (player.transform.position.x < transform.position.x)
            {
                Debug.Log("Right of player");
                newPos = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
                transform.position = newPos;
            }
            else if (player.transform.position.x > transform.position.x)
            {
                Debug.Log("Left of player");
                newPos = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
                transform.position = newPos;
            }
            if (player.transform.position.y < transform.position.y)
            {
                Debug.Log("Above Player");
                newPos = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z);
                transform.position = newPos;
            }
            else if (player.transform.position.y > transform.position.y)
            {
                Debug.Log("Below Player");
                newPos = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
                transform.position = newPos;
            }
        }
    }
}

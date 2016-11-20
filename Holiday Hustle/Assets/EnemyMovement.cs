using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    //Enemy Health
    //int health = 0;
    public GameObject player;
    public Camera camera;


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

            //Right of Player
            if (player.transform.position.x < transform.position.x)
            {
                newPos = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
                transform.position = newPos;
            }

            //Left of Player
            else if (player.transform.position.x > transform.position.x)
            {
                newPos = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
                transform.position = newPos;
            }

            //Above Player
            if (player.transform.position.y < transform.position.y)
            {
                newPos = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z);
                transform.position = newPos;
            }

            //Below Player
            else if (player.transform.position.y > transform.position.y)
            {
                newPos = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
                transform.position = newPos;
            }

            //Shoots a ballastic object at player
            FollowTarget(new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        }
    }


    //Makes the enemy to face player
    void FollowTarget(Vector3 targetPos)
    {
        Vector3 targetPosition = new Vector3(targetPos.x, targetPos.y, targetPos.z);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((targetPosition.y - transform.position.y), (targetPosition.x - transform.position.x)) * Mathf.Rad2Deg);
    }
}

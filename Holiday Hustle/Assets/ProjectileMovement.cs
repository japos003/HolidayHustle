using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    public Transform targetPosition;

    private int timer;

	// Use this for initialization
	void Start () {
        Debug.Log("Projectile Beginning Position - x: " + transform.position.x + " y: " + transform.position.y + " z: " + transform.position.z);
        timer = 100;
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((targetPosition.position.y - transform.position.y), (targetPosition.position.x - transform.position.x)) * Mathf.Rad2Deg);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Projectile Current Position - x: " + transform.position.x + " y: " + transform.position.y + " z: " + transform.position.z);
        timer--;
        var movement = transform.TransformDirection(Vector3.right);
        Debug.Log("movement - x: " + movement.x + " y: " + movement.y);
        transform.position += movement * 2 * Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(this);
        }
	}

    void OnBecomeInvisible()
    {
        Destroy(this);
    }
}

using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {
    //public Camera camera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnBecomeInvisible()
    {
        Destroy(this);
    }
}

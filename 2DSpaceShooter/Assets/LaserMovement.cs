using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour {
    public float laserSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, laserSpeed * Time.deltaTime);

        if (transform.position.z > 5.6)
        {
            Destroy(gameObject);
        }
	}
}

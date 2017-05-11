using UnityEngine;
using System.Collections;

public class Enemy1Collision : MonoBehaviour {
    public GameObject explosion;
    public GameObject explosionSound;
	void Start () {
	
	}

	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Laser")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Instantiate(explosionSound, transform.position, transform.rotation);

            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
    public GameObject explosion;
    public GameObject explosionSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "EnemyLaser"|| col.gameObject.tag == "Mine")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Instantiate(explosionSound, transform.position, transform.rotation);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}

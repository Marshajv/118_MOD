using UnityEngine;
using System.Collections;

public class PowerUpCollision : MonoBehaviour {
    //public AudioClip powerUpSound;
    public GameObject powerUpSound;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<FireScript>().PowerUpLaser();
            Instantiate(powerUpSound, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}

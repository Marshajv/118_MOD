using UnityEngine;
using System.Collections;

public class Enemy1fire : MonoBehaviour {
    public float fireFreq;
    public float lastShot;

    public GameObject enemyLaser;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time >lastShot + fireFreq)
        {
            Fire();
        }
	}

    void Fire()
    {
        lastShot = Time.time;
        Instantiate(enemyLaser, transform.position, transform.rotation);
    }
}

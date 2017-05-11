using UnityEngine;
using System.Collections;

public class FireScript : MonoBehaviour {
    public float fireFreq;
    public float lastShot;

    public GameObject laser;

    public int laserType;

    private float laserTimer;

    void Start () {
	
	}

    void Update() {
        if (Input.GetButtonDown("Fire1")&& (Time.time > lastShot+ fireFreq))
        {
            Fire();
        }

        laserTimer -= 1 * Time.deltaTime;
        if (laserTimer < 0)
        {
            laserType = 0;
        }
    }
    public void Fire(){
        lastShot = Time.time;
        if (laserType == 0)
        {
            Instantiate(laser, transform.position, transform.rotation);
        } else if (laserType == 1)
        {
            Instantiate(laser, transform.position, Quaternion.Euler(0, -20, 0));
            WaitTime();
            Instantiate(laser, transform.position, transform.rotation);
            WaitTime();
            Instantiate(laser, transform.position, Quaternion.Euler(0, 20, 0));
        }
        else if (laserType == 2)
        {
            Instantiate(laser, transform.position, Quaternion.Euler(0, -30, 0));
            WaitTime();
            Instantiate(laser, transform.position, Quaternion.Euler(0, -15, 0));
            WaitTime();
            Instantiate(laser, transform.position, transform.rotation);
            WaitTime();
            Instantiate(laser, transform.position, Quaternion.Euler(0, 15, 0));
            WaitTime();
            Instantiate(laser, transform.position, Quaternion.Euler(0, 30, 0));
        }
    }

    public void PowerUpLaser()
    {
        laserType += 1;
        laserTimer = 3;
        laserType = Mathf.Clamp(laserType, 0, 2);
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.1f);
    }
}

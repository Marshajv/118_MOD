using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour {
    public float laserSpeed;
    public GameObject destroyBullet;

    void Start()
    {
        Destroy(this.gameObject, 8);
    }
	void Update () {
        transform.Translate(0, 0, laserSpeed * Time.deltaTime);
        //if ((transform.position.z > 5.6)||(transform.position.z <-3.6))
        //{
        //    Destroy(gameObject);
        //}
	}

   void OnTriggerEnter(Collider col)
    {
        if (col.tag == "DestroyBul")
        {
            Destroy(gameObject);
        }
    }
}

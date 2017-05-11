using UnityEngine;
using System.Collections;

public class MineScript : MonoBehaviour {
    public float mineSpeed;

    public GameObject explosion;
    public GameObject explosionSound;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, -mineSpeed * Time.deltaTime);
    }

    void Respawn()
    {
        transform.position = new Vector3(Random.Range(-6, 6), 0.68f, Random.Range(-50, -35));
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

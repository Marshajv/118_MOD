using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float playerSpeed;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxisRaw("Horizontal")*Time.deltaTime*playerSpeed, 0, Input.GetAxisRaw("Vertical")*Time.deltaTime*playerSpeed);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.1f, 4.1f), 0, Mathf.Clamp(transform.position.z,-1.7f, 1.7f));
        //for mod remove the clamp along the y axis this will make you have four directions of movement
        
    }
}

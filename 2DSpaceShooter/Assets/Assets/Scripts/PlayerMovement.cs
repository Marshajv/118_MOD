using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float playerSpeed;
    public float incSpeed;
    private bool isSpeedy=false;

    void Start()
    {

    }

    void Update()
    {
        if (isSpeedy == false)
        {
            transform.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * playerSpeed, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * playerSpeed);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -11f, 11f), 0, Mathf.Clamp(transform.position.z, -10f, 5f));
        }else if (isSpeedy == true)
        {
            //playerSpeed * incSpeed;
        }
        //for mod remove the clamp along the y axis this will make you have four directions of movement

    }

    
}
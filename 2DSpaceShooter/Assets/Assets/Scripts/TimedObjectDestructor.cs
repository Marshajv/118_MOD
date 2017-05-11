using UnityEngine;
using System.Collections;

public class TimedObjectDestructor : MonoBehaviour {
    public float destroyTime;
	void Update () {
        Destroy(gameObject,destroyTime);
    }
}

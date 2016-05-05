using UnityEngine;
using System.Collections;

public class UpperArmController : MonoBehaviour {
	
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	public float zRotation = 5.0F;
    void Update ()
    {
		float val = zRotation + Input.GetAxis("Horizontal");
		if(!(val >= 40 || val <= -40)){
			zRotation = val;
		}
        transform.eulerAngles = new Vector3(zRotation,0,0);
    }
}

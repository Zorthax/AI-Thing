using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float _walkSpeed;

	// Update is called once per frame
	void Update ()
    {
        //Input
        float horizontal = Input.GetAxis("Horizontal") * _walkSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * _walkSpeed * Time.deltaTime * 500;

        //Movement
        transform.position += new Vector3(horizontal, 0, vertical);
	}
}

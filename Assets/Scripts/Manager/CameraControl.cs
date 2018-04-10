using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    Transform tf;
    float newX, newY;

	// Use this for initialization
	void Start () {
        tf = GetComponent<Transform>();
        newX = tf.position.x;
        newY = tf.position.y;
	}

    void Update()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        newX += move.x * 0.5f;
        newY += move.y * 0.5f;

        if(Input.GetButton("ResetCamera"))
        {
            Debug.Log("Space pressed");
            newX = 85;
            newY = 11;
        }

        tf.position = new Vector3(newX, newY, -10);
    }
}

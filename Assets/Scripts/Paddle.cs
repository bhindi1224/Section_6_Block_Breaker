using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float leftMax= 0f;
    [SerializeField] float rightMax = Screen.width;
	
	// Update is called once per frame
	void Update () {
        float screenSpace = screenWidthInUnits / Screen.width;
        Vector2 paddlePosition = transform.position;
        paddlePosition.x = Mathf.Clamp(Input.mousePosition.x, leftMax, rightMax) * screenSpace;
        transform.position = paddlePosition;
	}
}

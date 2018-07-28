using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 16f;
	
	// Update is called once per frame
	void Update () {
        Vector2 paddlePosition = new Vector2((Input.mousePosition.x / Screen.width * screenWidthInUnits), transform.position.y);
        transform.position = paddlePosition;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
	public double maxX = 2.45;
	public double minX = -2.45;

	private Vector3 touchPos;
	private Rigidbody2D rb;
	private Vector3 direction;
	private float moveSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){ // mark position when we touch screen, creating touch variable
        	Touch touch = Input.GetTouch(0);
        	touchPos = Camera.main.ScreenToWorldPoint(touch.position);
        	touchPos.z = 0;
        	direction = (touchPos - transform.position); // direction from rocket pos to touch pos is calculated
        	rb.velocity = new Vector2(direction.x, 0) * moveSpeed;

        	if(touch.phase == TouchPhase.Ended){ // if we release a finger, then rocket stops
        		rb.velocity = Vector2.zero;
        	}
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccerBall : MonoBehaviour
{
    bool collided = false;
	public Rigidbody2D	rb;
    private CircleCollider2D cc;

    private Camera cam;
    private Vector2 screenBounds;

	Vector2 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-3, 3), 3);
        screenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("test collision");
        rb.velocity = rb.velocity * -1;
        collided = true;
    }

    // Update is called once per frame
    void Update()
    {
    	if(transform.position.y > 4.7 || transform.position.y < -4.7){
            if(transform.position.y < -4.7){
                scorescript.scoreValue += 10;
                print("test score increase");
            }
    		Destroy(this.gameObject);
    	}

    	if(transform.position.x > 2.45 || transform.position.x < -2.45 ){
    		rb.velocity = new Vector2(rb.velocity.x * -1, rb.velocity.y);
    	}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPatrol : MonoBehaviour
{
	public float maxX = 2.45f;
	//public float maxY;

	public float minX = -2.45f;
	//public float minY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetRandomPosition() {
    	float randomX = Random.Range(minX, maxX);
    	
    }
}

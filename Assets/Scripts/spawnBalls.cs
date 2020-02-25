﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBalls : MonoBehaviour
{
	public GameObject soccerballPrefab;
	public float respawnTime = 1.0f;
	private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ballWave());
    }

    private void spawnBall(){
    	GameObject a = Instantiate(soccerballPrefab) as GameObject;
    	a.transform.position = new Vector2(Random.Range(0,2), -4); 	
    }

    IEnumerator ballWave(){
    	while(true){
    		yield return new WaitForSeconds(respawnTime);
    		spawnBall();
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

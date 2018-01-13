﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrobeLight : MonoBehaviour {

    private Light light;
    public float flashFrequency = 0.75f;
    public float flashLength = 0.05f;
    private float timeElapsed;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        light.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= flashFrequency) {
            timeElapsed = 0f;
            StartCoroutine(Flash());
        }
	}

    IEnumerator Flash() {
        light.enabled = true;
        transform.rotation = Quaternion.Euler(new Vector3(Random.Range(20,160), Random.Range(0, 360), 0));
        //transform.rotation = ;
        yield return new WaitForSeconds(flashLength);
        light.enabled = false;
    }
}

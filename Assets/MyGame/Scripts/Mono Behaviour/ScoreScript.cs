﻿using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private TextMeshProUGUI watch;
    private float timer;

	// Use this for initialization
	void Start ()
	{
        watch = gameObject.GetComponent<TextMeshProUGUI>();
        watch.text = "00:00:00";
	}
	
	// Update is called once per frame
	void Update () 
	{
        timer += Time.deltaTime;

        watch.text = string.Format("{0:00}:{1:00}:{2:00}",
            Mathf.Floor(timer / 60),
            Mathf.Floor(timer) % 60,
            Mathf.Floor((timer * 100) % 100));
	}
       /*  if(timer > interval)
        {
            GlobalVariables.speed = GlobalVariables.speed + 1f;
            interval = interval + 10;
        } */
}
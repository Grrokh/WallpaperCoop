using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_logick : MonoBehaviour {

    int numb = 0;
    Vector3 start_pos;
	// Use this for initialization
	void Start () {
        start_pos=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        start_pos.x += Random.Range(0.1f, 0.3f);
        transform.position=start_pos;
        numb++;
        Debug.Log(numb+" X:" + start_pos.x);
        Debug.Log(numb+" Y:" + start_pos.y);
    }
}

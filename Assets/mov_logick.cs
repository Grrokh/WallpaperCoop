using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_logick : MonoBehaviour {
    public int hp;
    public bool Naprav;
    public  string enemy_name;
    public  GameObject enemy;
    int numb = 0;
    Vector3 start_pos;
    Vector3 end_pos;
	// Use this for initialization
	void Start () {
        enemy_name = "";
        start_pos = transform.position;
        end_pos.x = 60;
        end_pos.y = start_pos.y;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
        start_pos = transform.position;
        if (enemy != null)
        {

        }
        else
        {
            if (Naprav)
            {
                start_pos.x += Random.Range(0.05f, 0.1f);
            }
            else
            {
                start_pos.x += Random.Range(-0.05f, -0.1f);
            }
            transform.position = start_pos;
        }

       
        numb++;
    }
     void OnTriggerEnter2D(BoxCollider2D col)
    {
        if (Naprav)
        {
            if (col.gameObject.tag == "Team2")
            {
                enemy = col.gameObject;

            }
        }
        else
        {
            if (col.gameObject.tag == "Team1")
            {
                enemy = col.gameObject;

            }
        }

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        
    }

}

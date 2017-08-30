using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig_left : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        /*if(col.gameObject.tag == "Team1")
        {
            Destroy(col.gameObject);
        }*/
    }
    private void OnTriggerExit2D(Collider2D col)
    {
       
            Destroy(col.gameObject);
        
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        
    }
}

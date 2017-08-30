using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLogic : MonoBehaviour
{
	Vector3 start_pos;
	Vector3 end_pos;

	int Race = 0;

	void Start()
	{
		switch(tag)
		{
			case "LeftSide":
				Race = 1;
				break;
			case "RightSide":
				Race = -1;
				GetComponent<SpriteRenderer>().flipX = true;
				break;
		}


		start_pos = transform.position;
		end_pos.x = 60*Race;
		end_pos.y = start_pos.y;
	}

	void FixedUpdate()
	{
		start_pos = transform.position;
		start_pos.x += Random.Range(0.05f, 0.1f) * Race;
		start_pos.y += Random.Range(-0.1f, 0.1f);
		transform.position = start_pos;
	}
}


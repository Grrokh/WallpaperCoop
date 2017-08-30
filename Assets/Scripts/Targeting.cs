using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
	[SerializeField]
	GameObject Target;

	void OnTriggerEnter2D(Collider2D collision)
	{
		if(Target==null && collision.tag!=tag && collision.name=="Unit(Clone)")
		{
			Target = collision.gameObject;
		}
	}
}

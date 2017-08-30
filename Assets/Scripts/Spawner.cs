using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField]
	GameObject Unit;

	void Start ()
	{
		GameObject x;

		x = Instantiate(Unit, transform.position,Quaternion.identity);
		foreach (Transform t in x.transform)
			t.gameObject.tag = gameObject.tag;
		x.gameObject.tag = gameObject.tag;
	}
}

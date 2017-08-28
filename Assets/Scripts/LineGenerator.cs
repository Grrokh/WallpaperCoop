using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour {

	[SerializeField]
	GameObject WaterTile;
	[SerializeField]
	GameObject GrassTile;
	[SerializeField]
	GameObject SkyTile;

	[SerializeField]
	GameObject WaterParent;
	[SerializeField]
	GameObject GrassParent;
	[SerializeField]
	GameObject SkyParent;

	[SerializeField]
	int Step;

	int YSize;
	int XSize;
	int YSizeInt;
	int XSizeInt;


	void Start ()
	{
		YSize = Screen.height / Step / 2;
		XSize = Screen.width / Step / 2;
		YSizeInt = (int)Math.Ceiling((double)YSize);
		XSizeInt = (int)Math.Ceiling((double)XSize);
		for (int i = YSizeInt; i > YSizeInt / 2 - 1; i--)
		{
			for (int j = -XSizeInt; j < XSizeInt + 1; j++)
			{
				Instantiate(SkyTile, new Vector3(j, i), Quaternion.identity, SkyParent.transform);
			}
		}
		for (int i = YSizeInt /2 ; i > -YSizeInt / 2 - 1; i--)
		{
			for (int j = -XSizeInt; j < XSizeInt + 1; j++)
			{
				Instantiate(GrassTile, new Vector3(j, i), Quaternion.identity, GrassParent.transform);
			}
		}
		for (int i = -YSizeInt / 2; i > -YSizeInt - 1; i--)
		{
			for (int j = -XSizeInt; j < XSizeInt + 1; j++)
			{
				Instantiate(WaterTile, new Vector3(j, i), Quaternion.identity, WaterParent.transform);
			}
		}
	}
}

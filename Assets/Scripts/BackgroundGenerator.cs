using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

	[SerializeField]
	GameObject WaterTile;
	[SerializeField]
	GameObject WaterTopTile;
	[SerializeField]
	GameObject GrassTile;
	[SerializeField]
	GameObject GrassTopTile;
	[SerializeField]
	GameObject GrassBottomTile;
	[SerializeField]
	GameObject SkyTile;

	[SerializeField]
	GameObject WaterParent;
	[SerializeField]
	GameObject GrassParent;
	[SerializeField]
	GameObject SkyParent;

	[SerializeField]
	GameObject Border;

	int Step;

	int YSize;
	int XSize;
	int YSizeInt;
	int XSizeInt;


	void Start ()
	{
		Step = GameScale.Step;
		YSize = Screen.height / Step / 2;
		XSize = Screen.width / Step / 2;
		YSizeInt = (int)Math.Ceiling((double)YSize);
		XSizeInt = (int)Math.Ceiling((double)XSize);

		int border = 512 / Step / 2;

		for (int i = YSizeInt; i > border - 1; i--)
		{
			for (int j = -XSizeInt; j < XSizeInt + 1; j++)
			{
				Instantiate(SkyTile, new Vector3(j, i), Quaternion.identity, SkyParent.transform);
			}
		}

		for (int j = -XSizeInt; j < XSizeInt + 1; j++)
		{
			Instantiate(GrassTopTile, new Vector3(j, border), Quaternion.identity, GrassParent.transform);
		}

		for (int i = border - 1; i > -border; i--)
		{
			for (int j = -XSizeInt; j < XSizeInt + 1; j++)
			{
				Instantiate(GrassTile, new Vector3(j, i), Quaternion.identity, GrassParent.transform);
			}

		}

		for (int j = -XSizeInt; j < XSizeInt + 1; j++)
		{
			Instantiate(GrassBottomTile, new Vector3(j, -border), Quaternion.identity, GrassParent.transform);
		}

		for (int j = -XSizeInt; j < XSizeInt + 1; j++)
		{
			Instantiate(WaterTopTile, new Vector3(j, -border-1), Quaternion.identity, WaterParent.transform);
		}

		for (int i = -border - 2; i > -YSizeInt - 1; i--)
		{
			for (int j = -XSizeInt; j < XSizeInt + 1; j++)
			{
				Instantiate(WaterTile, new Vector3(j, i), Quaternion.identity, WaterParent.transform);
			}
		}

		GameObject x;

		x = Instantiate(Border, new Vector3(-XSize-3, 0), Quaternion.identity, GrassParent.transform);
		x.transform.localScale = new Vector3(1, border * 2);
		foreach(Transform t in x.transform)
			t.gameObject.tag = "LeftSide";
		x.gameObject.tag = "LeftSide";

		x = Instantiate(Border, new Vector3(XSize+3, 0), Quaternion.identity, GrassParent.transform);
		x.transform.localScale = new Vector3(1, border * 2);
		foreach (Transform t in x.transform)
			t.gameObject.tag = "RightSide";
		x.gameObject.tag = "RightSide";

	}
}

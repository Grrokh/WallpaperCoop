using UnityEngine;

public class GameScale : MonoBehaviour {

	[SerializeField]
	int Step = 16;

	void Start ()
	{
		Camera Cam = GetComponent<Camera>();
		Cam.orthographicSize = Screen.height / Step / 2;
	}
}

using UnityEngine;

public class GameScale : MonoBehaviour {

	[SerializeField]
	int Stepp;
	public static int Step;

	void Start ()
	{
		Step = Stepp;
		Camera Cam = GetComponent<Camera>();
		Cam.orthographicSize = Screen.height / Step / 2;
	}
}

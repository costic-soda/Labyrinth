using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public GameObject dollyTrack;

	private Vector3 offset;
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void Update ()
	{
		//dollyTrack.transform.position - player.transform.position;
		transform.position = player.transform.position + offset;
	}
}

//position: 0  9.5  -10
//rotation: 45  0  0

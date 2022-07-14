using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyTrackController : MonoBehaviour
{
	public GameObject player;

	private Vector3 offset;
	private Vector3 value;
	void Start()
	{
		value = new Vector3(transform.position.x, transform.position.y);
		offset.z = transform.position.z - player.transform.position.z;
	}

	void Update()
    {
        value.z = player.transform.position.z + offset.z;
		transform.position = value;
	}
}

//position: 0  9.5  -10
//rotation: 45  0  0

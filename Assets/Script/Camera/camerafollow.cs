using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using TreeEditor;
using UnityEngine.UI;

public class camerafollow : MonoBehaviour
{


	public float followSpeed = 2f;
	public Transform target;
	public bool needText;
	public string placeName;
	public GameObject text;
	public Text placeText;

	void Update()
	{
		Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
		transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);

	}
}

    


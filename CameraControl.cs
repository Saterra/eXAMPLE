using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour 
{
	public float sens = 600f;
	public Transform player;

	private float xRot = 0f;

	void Start () 
	{
		Cursor.lockState = CursorLockMode.Locked;	
	}
	
	void Update () 
	{
		float nX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
		float nY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

		xRot -= nY;
		xRot = Mathf.Clamp(xRot, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
		player.Rotate(Vector3.up * nX);
	}
}

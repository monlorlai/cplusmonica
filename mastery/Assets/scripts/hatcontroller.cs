using UnityEngine;
using System.Collections;

public class hatcontroller : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}

	}

	// Update is called once per physics timestep
	void FixedUpdate () {
			Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
			Vector3 targetPosition = new Vector3 (rawPosition.x, 0.0f, 0.0f);
			GetComponent<Rigidbody2D>().MovePosition (targetPosition);
		}
	}


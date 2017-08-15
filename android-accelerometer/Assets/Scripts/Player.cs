using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private float horizontal;
	private float vertical;
	public float speed;
	public float speedUp;
	private Rigidbody rb;
	private Text text;
	private Slider x_axis;
	private Slider y_axis;

	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		rb = GetComponent<Rigidbody> ();
		text = GameObject.FindGameObjectWithTag ("Text").GetComponent<Text> ();
		x_axis = GameObject.FindGameObjectWithTag ("X-Axis").GetComponent<Slider> ();
		y_axis = GameObject.FindGameObjectWithTag ("Y-Axis").GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5)
			replay ();
	}

	void FixedUpdate(){
		if (Application.platform == RuntimePlatform.Android) {
			horizontal = Input.acceleration.x;
			vertical = Input.acceleration.y;
		} else {
			horizontal = Input.GetAxis ("Horizontal");
			vertical = Input.GetAxis ("Vertical");
		}
		text.text = "X: "+horizontal.ToString("F3")+" Y: "+ vertical.ToString("F3");
		x_axis.value = horizontal;
		y_axis.value = vertical;
		Vector3 moviment = new Vector3 (horizontal, 0.0f, vertical);
		rb.AddForce (moviment * speed);
	}

	public void replay(){
		gameObject.transform.position = new Vector3 (9, 6f, 6);
		rb.isKinematic = true;
		rb.isKinematic = false;
	}
}

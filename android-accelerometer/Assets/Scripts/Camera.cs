using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	private GameObject player;
	private Vector3 offset;

//	private float x_tmp_min_left = 0;
//	private float x_tmp_max_left = 1;
//
//	private float x_tmp_min_rigth = 0;
//	private float x_tmp_max_rigth = 1;
//
//	private float y_tmp_min = 0;
//	private float y_tmp_max = 1;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () {
		if (player.transform.position.z > 1 && player.transform.position.z < 17 && player.transform.position.x > 3 && player.transform.position.x < 15) {
			transform.position = player.transform.position + offset;
		} else {
			if (player.transform.position.z > 17 && player.transform.position.x < 3) {
				transform.position = new Vector3 (3, player.transform.position.y, 17) + new Vector3(0, offset.y, offset.z);
				return;
			}

			if (player.transform.position.z < 1 && player.transform.position.x > 15) {
				transform.position = new Vector3 (15, player.transform.position.y, 1) + new Vector3(0, offset.y, offset.z);
				return;
			}

			if (player.transform.position.z < 1 && player.transform.position.x < 3) {
				transform.position = new Vector3 (3, player.transform.position.y, 1) + new Vector3(0, offset.y, offset.z);
				return;
			}else if(player.transform.position.z < 1){
				transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, 1) + new Vector3(0, offset.y, offset.z);
				return;
			} else if (player.transform.position.x < 3) {
				transform.position = new Vector3 (3, player.transform.position.y, player.transform.position.z) + new Vector3(0, offset.y, offset.z);
				return;
			} 

			if (player.transform.position.z > 17 && player.transform.position.x > 15) {
				transform.position = new Vector3 (15, player.transform.position.y, 17) + new Vector3 (0, offset.y, offset.z);
				return;
			} else if (player.transform.position.z > 17) {
				transform.position = new Vector3 ( player.transform.position.x, player.transform.position.y, 17) + new Vector3 (0, offset.y, offset.z);
				return;
			} else if (player.transform.position.x > 15) {
				transform.position = new Vector3 (15, player.transform.position.y, player.transform.position.z) + new Vector3(0, offset.y, offset.z);
				return;
			}
		}

//		if (player.transform.position.x < 2.5) {
//			x_tmp_min_left += Time.deltaTime;
//			float tmp = x_tmp_min_left / 1;
//			tmp = Mathf.Clamp01 (tmp);
//			transform.position = player.transform.position + offset + new Vector3 (2.5f * tmp, 0, 0);
//			x_tmp_max_left = 1;
//		} else if (player.transform.position.x >= 2.5 && player.transform.position.x <= 7.5) {
//			x_tmp_max_left -= Time.deltaTime;
//			float tmp = x_tmp_max_left / 1;
//			tmp = Mathf.Clamp01 (tmp);
//			transform.position = player.transform.position + offset + new Vector3 (2.5f * tmp, 0, 0);
//			x_tmp_min_left = 0;
//		} else if (player.transform.position.x > 17) {
//			x_tmp_min_rigth += Time.deltaTime;
//			float tmp = x_tmp_min_rigth / 1;
//			tmp = Mathf.Clamp01 (tmp);
//			transform.position = player.transform.position + offset - new Vector3 (2.5f * tmp, 0, 0);
//			x_tmp_max_rigth = 1;
//		} else if(player.transform.position.x <= 17 && player.transform.position.x >= 12 ){
//			x_tmp_max_rigth -= Time.deltaTime;
//			float tmp = x_tmp_max_rigth / 1;
//			tmp = Mathf.Clamp01 (tmp);
//			transform.position = player.transform.position + offset - new Vector3 (2.5f * tmp, 0, 0);
//			x_tmp_min_rigth = 0;
//		} 

	}

	// Update is called once per frame
	void Update () {
		
	}
		
}

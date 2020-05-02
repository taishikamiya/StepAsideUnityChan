using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	//Unitychan取得
	private GameObject unityChan;


	// Use this for initialization
	void Start () {

		this.unityChan = GameObject.Find("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {

		//unityちゃんがcar objectを通過して5m過ぎたらdestroy
		if (this.transform.position.z + 5 < this.unityChan.transform.position.z )
		{
				Destroy(this.gameObject);
        }
	}
}

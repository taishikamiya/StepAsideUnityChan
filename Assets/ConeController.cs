using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeController : MonoBehaviour {

    //unitychanゲームオブジェクト
	private GameObject unityChan;


	// Use this for initialization
	void Start () {

        //unityちゃん取得
		this.unityChan = GameObject.Find("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {

        //unityちゃんがconeを5m通貨したらdestroy
        if(this.transform.position.z + 5 < unityChan.GetComponent<Transform>().position.z)
        {
			Destroy(this.gameObject);
        }
		
	}
}

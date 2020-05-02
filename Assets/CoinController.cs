using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	//unitychangを取得
	private GameObject unityChan;

	// Use this for initialization
	void Start () {
		//回転を開始する角度を設定
		this.transform.Rotate(0, Random.Range(0, 360), 0);

		//unity chan のgameobjectを取得
		this.unityChan = GameObject.Find("unitychan");

	}
	
	// Update is called once per frame
	void Update () {
		//回転
		this.transform.Rotate(0, 3, 0);

		//unityちゃんのz座標を読み取ってunityちゃんが5m通過したらdestroy
        if(this.transform.position.z + 5 < this.unityChan.GetComponent<Transform>().position.z)
        {
			Destroy(this.gameObject);

        }

		
	}
}

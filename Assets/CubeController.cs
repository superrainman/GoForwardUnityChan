using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour 
{
	private float speed = -12;
	private float deadLine = -10;

	//AudioSourceの取得。
	private AudioSource sound;

	// Use this for initialization
	void Start () 
	{
		sound = GetComponent<AudioSource>();		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (this.speed * Time.deltaTime, 0, 0);

		if (transform.position.x <this.deadLine)
		{
			Destroy (gameObject);
		}
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//接触相手にunityちゃんタグが付いていない時、効果音を鳴らす。
		if (other.gameObject.tag != "UnityChanTag")
		{
		sound.PlayOneShot(sound.clip);
		}
	}
}

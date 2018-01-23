#pragma warning disable 0414
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mori : MonoBehaviour 
{

    public int speed = 10;
    private GameObject player;
	private Main mainscript;

    void Start () 
	{
        player = GameObject.FindWithTag("Player");
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
		//メインルート
		GameObject GameControl = GameObject.Find ("GameControl");
		mainscript = GameControl.GetComponent<Main> ();
    }
	    
	void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
			mainscript.GameOver ();
        }

		if (coll.gameObject.tag == "DeleteEnemyWeapon")
		{
			Destroy (gameObject);
		}
    }
}

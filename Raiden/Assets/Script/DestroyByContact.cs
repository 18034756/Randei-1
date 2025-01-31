using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	//Score when destroy
	public int score;
	private GameController game;

	void Start()
	{
		GameObject go = GameObject.FindGameObjectWithTag("GameController");
		game = go.GetComponent<GameController>();

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy" )//for enemy
		{
			return;
		}
		//enemy exp
		if(explosion!= null)
        {
			Instantiate(explosion, transform.position, transform.rotation);
		}

		//player exp
		if (other.tag == "Player" )//for player
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			game.GameOver();
		}

		game.AddScore(score);

		//destroy animation
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public GameObject deathEffect;

	void OnCollisionEnter (Collision col)
	{
		if (col.collider.tag == "Meteor")
		{

            Debug.Log("Meteriors Collided"+ col.collider.transform.position.ToString());
			Instantiate(deathEffect, transform.position, transform.rotation);
			GameManager.instance.EndGame();

			AudioManager.instance.Play("PlayerDeath");

			Destroy(gameObject);
		}
	}

}

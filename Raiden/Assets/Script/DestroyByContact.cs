using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;

	//��������ײ�����뵱ǰGameObject�Ĵ�����ʱ�����ٸ���ײ����Ӧ����Ϸ����ͬʱ���ٸ�GameObject
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
		}

		//destroy animation
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}

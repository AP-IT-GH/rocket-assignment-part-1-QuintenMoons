using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketCollide : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<starsIncrease>().ApplyStar(1);
		}
	}
}

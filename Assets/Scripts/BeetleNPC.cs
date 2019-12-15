using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleNPC : MonoBehaviour
{
	Animator animator;
	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Collision Detection Test
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			animator.Play("Die on ground");
		}
	}
}

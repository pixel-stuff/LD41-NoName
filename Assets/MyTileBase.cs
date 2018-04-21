﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyTileBase : TypedObject
{
	public MyType TileType = MyType.Undefined;
	[SerializeField] UnityEvent OnPlayerCollisionEnter;
	[SerializeField] UnityEvent OnPlayerCollisionExit;

	public override MyType GetType()
	{
		return TileType;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Collision with basic Tile");
		if (collision.gameObject.tag == "player") {
			OnPlayerCollisionEnter.Invoke ();
		}
	}

	void OnCollisionExit(Collision collision)
	{
		Debug.Log("Collision with basic Tile");
		if (collision.gameObject.tag == "player") {
			OnPlayerCollisionExit.Invoke ();
		}
	}
}

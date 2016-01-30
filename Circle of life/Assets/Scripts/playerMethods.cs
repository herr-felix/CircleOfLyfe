using UnityEngine;
using System.Collections.Generic;

public class CollectibleItem : MonoBehaviour
{

}

public class playerMethods : MonoBehaviour {


	public static int collectibleCount = 0;

	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

	}

	public bool IsEarthRitualDone ()
	{
		return collectibleCount == 10;
	}

	public bool IsWaterRitualDone ()
	{
		return collectibleCount == 20;
	}

	public bool IsAirRitualDone ()
	{
		return collectibleCount == 30;
	}

	public bool IsFireRitualDone ()
	{
		return collectibleCount == 40;
	}
}



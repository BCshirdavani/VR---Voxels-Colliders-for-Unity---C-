using UnityEngine;
using System.Collections;

public class DestroyCubes : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
//		if(col.gameObject.name.Substring(0,4) == "cube")
//		{
			Destroy(col.gameObject);
			Debug.Log ("crash");
//		}
	}
}
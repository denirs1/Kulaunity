using UnityEngine;
using System.Collections;

public class dontdestroy : MonoBehaviour {

	
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
}

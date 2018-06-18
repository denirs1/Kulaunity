using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {
    public GameObject okey;
  
	// Use this for initialization
    
	void OnMouseDown (GameObject okey) {
        if (okey.gameObject.CompareTag("okey"))
            Destroy(okey);
        //PlayerPrefs.DeleteAll;
        
    }
	
	// Update is called once per frame
	
   
}
  
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EscapeToExit : MonoBehaviour {
    
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
             

        


	}
}

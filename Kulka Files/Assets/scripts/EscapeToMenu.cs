using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EscapeToMenu : MonoBehaviour {
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menuv2");


        }


	}
}

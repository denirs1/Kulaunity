using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class gameovertrigger : MonoBehaviour {

	void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "sphere")
        {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);

        }

    }
	
	
}

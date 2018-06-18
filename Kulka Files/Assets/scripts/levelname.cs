using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class levelname : MonoBehaviour {

    public TextMesh textmesh;
	void Start () {
        string levelName = SceneManager.GetActiveScene().name;
        textmesh.text = levelName;
	}
	
}

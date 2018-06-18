using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelItem : MonoBehaviour {
    public TextMesh textmesh;
    public GameObject okey;
    public string LevelName;
   private int Point;
    void Start()
    {
        textmesh.text = LevelName;

        if (PlayerPrefs.GetInt(LevelName+"_finished",0 ) == 0)
        {
            Destroy(okey);

        }
    }
    void OnMouseDown()
    {
       SceneManager.LoadScene(LevelName);

    }
}

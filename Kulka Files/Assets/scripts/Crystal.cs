using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Crystal : MonoBehaviour 
{
    public GameObject particle;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name != "sphere")
        {
            return;
        }

        int points = PlayerPrefs.GetInt("points");
        points += 1;
        PlayerPrefs.SetInt("points", points);

        if (leaveCrystals() == 1)
        {
            string levelName = Application.loadedLevelName;
            PlayerPrefs.SetInt(levelName+"_finished", 1);

            SceneManager.LoadScene("menuv2");
        }
        else
        {
            GameObject.Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    int leaveCrystals()
    {
        Crystal[] crystals = Component.FindObjectsOfType<Crystal>();
        return crystals.Length;
    }
}

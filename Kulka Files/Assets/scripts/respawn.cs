using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class respawn : MonoBehaviour {

    public GameObject ballPrefab;
    public Camera cameraprefab;
    public Light lightprefab;

    public GameObject gameOverBase;
    public GameObject levelName;
	void Start () {
        GameObject ball = GameObject.Instantiate(ballPrefab);
        ball.name = "sphere";
        ball.transform.position = transform.position + Vector3.up*2f;

        Camera camera = GameObject.Instantiate(cameraprefab);
        kamera kamera = camera.GetComponent<kamera>();
        kamera.spheree = ball.transform;

        Light light = GameObject.Instantiate(lightprefab);

        light.color = Color.white;
        light.intensity = 0.5f;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.7f;

        GameObject gameOverBase;
     GameObject levelName;
}
	
	
	
}

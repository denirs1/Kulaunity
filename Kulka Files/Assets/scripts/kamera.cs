using UnityEngine;
using System.Collections;

public class kamera : MonoBehaviour {

    public Transform spheree;
	
	
	void Update () {
        
        Rigidbody rigidbody = spheree.GetComponent<Rigidbody>();
        Vector3 vector = new Vector3(5f, 5f, -0f);
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (0.5f + velocity/128);

        Vector3 newposition = spheree.position + vector;
        
        transform.position = Vector3.Lerp(transform.position, newposition, Time.deltaTime*2f);
        transform.LookAt(spheree);
	}
}

using UnityEngine;
using System.Collections;

public class kularusza : MonoBehaviour {

    int layer = 0;
    Rigidbody rigidbody;
    private object color;

    void Start() {

       rigidbody = transform.GetComponent<Rigidbody>();

    }

	void Update () {

         
     
        changelayer();
        changePosition();
        
    }
    void changelayer()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f);
            if (!isSomething)
            {
                layer = 1;
            }
                

            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bool isSomething = Physics.Raycast(transform.position, Vector3.back, 2f);
            if (!isSomething)
            {
                layer = 0;
            }


        }
        float delta = (layer * 2f - 2f) -  rigidbody.position.z ;
        Vector3 velocity = rigidbody.velocity;
        velocity.z = delta * 3f;
        rigidbody.velocity = velocity;
        
    }
    void changePosition()
    {
        Vector3 direction = Vector3.zero;



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector3.forward;


        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.back;
           

        }
        rigidbody.AddTorque(direction * 25f);   

    }
}

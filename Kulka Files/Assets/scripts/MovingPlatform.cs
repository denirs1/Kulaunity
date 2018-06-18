﻿using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    public Vector3 delta;
    Vector3 startPosition;
	void Start () {
        startPosition = transform.position;
	}
	
	
	void Update () {
        float velocity = 50f / delta.sqrMagnitude;
        float change =( Mathf.Sin(Time.timeSinceLevelLoad*velocity)+1f)/2f;
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        rigidbody.position = Vector3.Lerp(startPosition, startPosition+delta, change);
	}

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;

        if(UnityEditor.Selection.activeTransform == transform)
        {
            Gizmos.color = Color.yellow;

        }
        Vector3 ghostPosition = transform.position + delta;
        Vector3 ghostSize = transform.rotation * transform.localScale * 2f;

        Gizmos.DrawWireCube(ghostPosition, Vector3.one);

    }
#endif
}

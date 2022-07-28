using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public GameObject Unit;
    public Vector3 MouseTouchPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Camera.main.ScreenPointToRay(MouseTouchPoint);
            Unit.transform.position = MouseTouchPoint;
        }
	}
}

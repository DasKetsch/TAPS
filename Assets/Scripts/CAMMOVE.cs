using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CAMMOVE : MonoBehaviour {
    public GameObject obj;
    public float speed = 2;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newpos = obj.transform.position;
            newpos.x += speed;
            obj.transform.position = newpos;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 newpos = obj.transform.position;
            newpos.x -= speed;
            obj.transform.position = newpos;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 newpos = obj.transform.position;
            newpos.y += speed;
            obj.transform.position = newpos;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 newpos = obj.transform.position;
            newpos.y -= speed;
            obj.transform.position = newpos;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            Vector3 newpos = obj.transform.position;
            newpos.x += speed/2;
            newpos.y += speed/2;
            obj.transform.position = newpos;
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            Vector3 newpos = obj.transform.position;
            newpos.x -= speed/2;
            newpos.y += speed/2;
            obj.transform.position = newpos;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            Vector3 newpos = obj.transform.position;
            newpos.y -= speed/2;
            newpos.x += speed/2;
            obj.transform.position = newpos;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            Vector3 newpos = obj.transform.position;
            newpos.y -= speed/2;
            newpos.x -= speed/2;
            obj.transform.position = newpos;
        }
    }
}

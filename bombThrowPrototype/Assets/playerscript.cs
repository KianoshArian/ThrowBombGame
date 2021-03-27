using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {
	// Use this for initialization
	[SerializeField] GameObject rightneigh, leftneigh;
	public string whichPlayer;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
		collision.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		//Debug.Log("hi");
    }
}

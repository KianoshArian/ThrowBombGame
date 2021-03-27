using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombControl : MonoBehaviour {
    GameObject controllingPlayer;
    public GameObject arrow;
    public bool isInHand;
    Rigidbody2D rb;
    [SerializeField] string whichTurn;
    // Use this for initialization
    void Start ()
    {
        whichTurn = "p1";
        rb = GetComponent<Rigidbody2D>();
        isInHand = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (whichTurn == "p1") {
            if (Input.GetKey("up"))
            {
                transform.Rotate(0, 0, 2f);
            }
            if (Input.GetKey("down"))
            {
                transform.Rotate(0, 0, -2f);
            }
            if (Input.GetKey(KeyCode.Return))
            {
                shoot();
            }
        }
        else
        {
            if (Input.GetKey("w"))
            {
                transform.Rotate(0, 0, 2f);
            }
            if (Input.GetKey("s"))
            {
                transform.Rotate(0, 0, -2f);
            }
            if (Input.GetKey("space"))
            {
                shoot();
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        playerscript playertype = collision.gameObject.GetComponent<playerscript>();
        if(playertype.whichPlayer!=whichTurn)
        {
            if (whichTurn == "p1")
            {
                whichTurn = "p2";
            }
            else
            {
                whichTurn = "p1";
            }
        }
        isInHand = true;
        rb.velocity = new Vector2(0, 0);
        arrow.GetComponent<Renderer>().enabled = true;
        
    }
    void shoot()
    {
        rb.velocity = new Vector2(5f * Mathf.Cos(transform.rotation.eulerAngles.z*Mathf.PI/180f), 5f * Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.PI / 180f));
        isInHand = false;
        arrow.GetComponent<Renderer>().enabled = false;
    }
}

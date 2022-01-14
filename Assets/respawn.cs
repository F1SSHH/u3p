using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private Vector3 respawnPoint;
    public GameObject falld;
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        falld.transform.position = new Vector2(transform.position.x, falld.transform.position.y);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "fall")
        {
            transform.position = respawnPoint;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 offset = Vector3.forward*-10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3 (target.transform.position.x,this.transform.position.y) + offset;
    }
}

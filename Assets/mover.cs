using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{   
    //variable 
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*speed,0,Input.GetAxis("Vertical")*Time.deltaTime*speed);
    }
}

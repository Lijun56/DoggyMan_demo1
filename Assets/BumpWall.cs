using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("the player hit the wall");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

}

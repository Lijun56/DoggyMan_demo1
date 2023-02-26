using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hit_num = 0;
    private void OnCollisionEnter(Collision other) {
        hit_num++;
        Debug.Log("you have hit this number of times"+hit_num);
    }
}

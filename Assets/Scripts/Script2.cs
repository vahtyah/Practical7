using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public Vector3 speed;

    private void Update()
    {
        GetComponent<Rigidbody>().velocity = speed * Time.deltaTime;
    }
}

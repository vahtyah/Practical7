using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
    }
}

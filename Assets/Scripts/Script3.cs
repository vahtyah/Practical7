using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public GameObject prefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}

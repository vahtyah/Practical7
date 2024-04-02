using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorController : MonoBehaviour
{
    [SerializeField] private float speedRotate = 20;
    [SerializeField] private Transform door;
    [SerializeField] private TextMeshProUGUI text;
    
    
    
    [SerializeField] private bool isOpening;
    [SerializeField] private bool isClosing;

    private void Start()
    {
        text.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (isOpening)
        {
            door.Rotate(Vector3.forward, speedRotate * Time.deltaTime);
            // Debug.Log(transform.localEulerAngles.z + " " + transform.eulerAngles.z);
            if (door.localEulerAngles.y >= 120)
                isOpening = false;
        }

        if (isClosing)
        {
            door.Rotate(Vector3.forward, -speedRotate * Time.deltaTime);
            if (door.localEulerAngles.y <= 5)
                isClosing = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (door.eulerAngles.y >= 120) isClosing = true;
            else if (door.eulerAngles.y <= 10) isOpening = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    [Header("Player Camera")]
    public Transform camera;

    [Header("Ray Distance")]
    public float rayDistance = 4f;

    [Header("Interactable Layer")]
    public LayerMask interactableLayer;

    void Start()
    {
    }

    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

        // PRESS DOWN E BUTTON
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, interactableLayer))
            {
                Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Interactable>().Interact();
            }
        }
    }
}

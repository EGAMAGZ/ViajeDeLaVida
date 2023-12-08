using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : Interactable
{
    private bool isInfoDisplayed = false;
    private bool isPlayerNear = false;

    private const float playerDistance = 5f;

    private GameObject meaningCanvas;
    private GameObject interactCanvas;
    private GameObject player;

    void Start()
    {
        meaningCanvas = transform.Find("MeaningPaintCanvas").gameObject;
        interactCanvas = transform.Find("InteractPaintCanvas").gameObject;
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distance = Vector3.Distance(
            player.transform.position,
            transform.position
            );
        isPlayerNear = distance < playerDistance;
        if (isPlayerNear)
        {
            meaningCanvas.SetActive(isInfoDisplayed);
            interactCanvas.SetActive(!isInfoDisplayed);
        }
        else
        {
            meaningCanvas.SetActive(false);
            interactCanvas.SetActive(false);
            isInfoDisplayed = false;
        }
    }

    public override void Interact()
    {
        base.Interact();


        isInfoDisplayed = !isInfoDisplayed;

        meaningCanvas.SetActive(isInfoDisplayed);
        interactCanvas.SetActive(!isInfoDisplayed);
    }
}
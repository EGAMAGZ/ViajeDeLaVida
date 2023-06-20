using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : Interactable
{
    private bool isInfoDisplayed = false;

    private GameObject meaningCanvas;
    private GameObject interactCanvas;

    // Start is called before the first frame update
    void Start()
    {
        meaningCanvas = transform.Find("MeaningPaintCanvas").gameObject;
        interactCanvas = transform.Find("InteractPaintCanvas").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact(){
        base.Interact();


        isInfoDisplayed = !isInfoDisplayed;

        meaningCanvas.SetActive(isInfoDisplayed);
        interactCanvas.SetActive(!isInfoDisplayed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : Interactable
{

    public Cloth cloth;

    // Start is called before the first frame update
    void Start()
    {
        cloth = transform.GetComponentInChildren<Cloth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact(){
        base.Interact();

        cloth.ClearTransformMotion();
        Debug.Log("CLEARED");
    }
}

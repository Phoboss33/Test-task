using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PropInteract : Interactable {
    public PropObj propObj;
    public static Action<PropObj> takeProp;
    public override void Interact() {
        TakeProp();
    }

    private void TakeProp() {
        if(!SpawnObjInhand.instance.inHand) {
            takeProp?.Invoke(propObj);
            Destroy(gameObject);
        }
        else {
            print("руки заняты");
        }
    }
}

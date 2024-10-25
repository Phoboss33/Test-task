using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : Interactable {
    private bool doorIsOpen = false;

    private void Start() {
        doorIsOpen = false;
    }

    public override void Interact() {
        OpenCloseDoor();
    }
    
    private void OpenCloseDoor() {
        doorIsOpen = !doorIsOpen;
    }
}

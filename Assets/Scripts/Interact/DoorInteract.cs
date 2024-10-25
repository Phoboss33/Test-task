using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : Interactable {
    private Animator _animator;

    protected override void Start() {
        base.Start();

        _animator = GetComponent<Animator>();
    }

    public override void Interact() {
        OpenDoor();
    }
    
    private void OpenDoor() {
        _animator.Play("OpenDoorAnim");
    }
}

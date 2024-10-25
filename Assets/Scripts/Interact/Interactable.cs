using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Outline))]
public abstract class Interactable : MonoBehaviour
{
    public string message;

    private Outline _outline;

    protected virtual void Start()
    {
        _outline = GetComponent<Outline>();
        _outline.enabled = false;
    }

    public void EnableOutline() {
        _outline.enabled = true;
    }
    public void DisableOutline() {
        _outline.enabled = false;
    }

    public abstract void Interact();

    

}

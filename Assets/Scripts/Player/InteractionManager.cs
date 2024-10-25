using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public float rayDistance = 5f; 
    public LayerMask layerMask;    

    private Interactable currentInteractable; 
    private GameObject curBoxInHand; 

    private Camera _camera;

    void Start() {
        _camera = Camera.main;
    }

    private void Update() {
        CheckInteraction();

        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null) {
            currentInteractable.Interact(); 
        }
    }

    private void CheckInteraction() {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, rayDistance, layerMask)) {
            Interactable newInteractable = hit.collider.GetComponent<Interactable>();
            if (currentInteractable && newInteractable != currentInteractable) {
                currentInteractable.DisableOutline();
            }

            if (newInteractable != null && newInteractable.enabled) {
                SetNewCurrentInteractable(newInteractable);
            }
            else {
                DisableCurrentInteractable();
            }
        }
        else {
            DisableCurrentInteractable();
        }
    }

    private void SetNewCurrentInteractable(Interactable newInteractable) {
        currentInteractable = newInteractable;
        currentInteractable.EnableOutline(); 
        HUDController.instance.EnableText(currentInteractable.message); 
    }

    private void DisableCurrentInteractable() {
        HUDController.instance.DisableText(); 

        if (currentInteractable) {
            currentInteractable.DisableOutline(); 
            currentInteractable = null;
        }
    }



}

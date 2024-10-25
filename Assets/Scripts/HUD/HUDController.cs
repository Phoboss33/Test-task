using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public static HUDController instance;

    [SerializeField] private TMP_Text _interactionText;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    private void Start() {
        _interactionText.gameObject.SetActive(false);
    }



    public void EnableText(string text) {
        _interactionText.text = text + " (E)";
        _interactionText.gameObject.SetActive(true);
    }

    public void DisableText() {
        _interactionText.gameObject.SetActive(false);
    }
}

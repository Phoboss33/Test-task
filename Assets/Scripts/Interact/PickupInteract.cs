using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInteract : Interactable {
    [SerializeField] private Transform SpawnPointObj;

    public override void Interact() {
        PutObject();
    }

    private void PutObject() {
        if (!SpawnObjInhand.instance.inHand) {
            print("твои руки пусты");
        }
        else {


            Destroy(SpawnObjInhand.instance.currentObjInHand);

            SpawnObjInhand.instance.currentObjInHand = null;
            SpawnObjInhand.instance.currentObjToSpawn = null;
            SpawnObjInhand.instance.inHand = false;
        }
    }

    private void SpawnObjInPickup() {

    }
}

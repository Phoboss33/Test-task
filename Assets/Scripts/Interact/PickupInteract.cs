using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInteract : Interactable {
    [SerializeField] private Transform[] _spawnPointObj;

    private int _currentSpawnPos = 0;

    public override void Interact() {
        PutObject();
    }

    // ћожно еще доработать, чтобы когда берешь предметы из пикапа, то _currentSpawnPos уменьшаетс€, иначе предметы будет невозможно положить.
    private void PutObject() {
        if (!SpawnObjInhand.instance.inHand) {
            print("твои руки пусты");
        }
        else if(_currentSpawnPos < _spawnPointObj.Length) {
            Destroy(SpawnObjInhand.instance.currentObjInHand);
            Instantiate(SpawnObjInhand.instance.currentObjToSpawn, _spawnPointObj[_currentSpawnPos++].position, Quaternion.identity);

            SpawnObjInhand.instance.currentObjInHand = null;
            SpawnObjInhand.instance.currentObjToSpawn = null;
            SpawnObjInhand.instance.inHand = false;
        }
        else if (_currentSpawnPos >= _spawnPointObj.Length) {
            print("ѕикап полон");
        }
    }
}

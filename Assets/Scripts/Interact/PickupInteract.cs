using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInteract : Interactable {
    [SerializeField] private Transform[] _spawnPointObj;

    private int _currentSpawnPos = 0;

    public override void Interact() {
        PutObject();
    }

    // ����� ��� ����������, ����� ����� ������ �������� �� ������, �� _currentSpawnPos �����������, ����� �������� ����� ���������� ��������.
    private void PutObject() {
        if (!SpawnObjInhand.instance.inHand) {
            print("���� ���� �����");
        }
        else if(_currentSpawnPos < _spawnPointObj.Length) {
            Destroy(SpawnObjInhand.instance.currentObjInHand);
            Instantiate(SpawnObjInhand.instance.currentObjToSpawn, _spawnPointObj[_currentSpawnPos++].position, Quaternion.identity);

            SpawnObjInhand.instance.currentObjInHand = null;
            SpawnObjInhand.instance.currentObjToSpawn = null;
            SpawnObjInhand.instance.inHand = false;
        }
        else if (_currentSpawnPos >= _spawnPointObj.Length) {
            print("����� �����");
        }
    }
}

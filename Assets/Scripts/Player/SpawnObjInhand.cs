using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjInhand : MonoBehaviour
{
    public static SpawnObjInhand instance;
    public bool inHand;

    [SerializeField] private GameObject _spawnPos;

    public GameObject currentObjInHand;
    public GameObject currentObjToSpawn;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(gameObject); 
            return;
        }

        instance = this; 
    }

    private void Start() {
        PropInteract.takeProp += SpawnObj;
        inHand = false;
    }

    private void OnDestroy() {
        PropInteract.takeProp -= SpawnObj;

        if (instance == this) {
            instance = null;
        }
    }

    private void SpawnObj(PropObj prop) {
        currentObjToSpawn = prop.prefabToSpawn;
        currentObjInHand = Instantiate(prop.prefabInHand, _spawnPos.transform.position, Quaternion.identity, _spawnPos.transform);
        inHand = true;
    }
}

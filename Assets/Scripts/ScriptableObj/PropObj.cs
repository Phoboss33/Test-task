using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "object")]
public class PropObj : ScriptableObject
{
    public GameObject prefabToSpawn;
    public GameObject prefabInHand;
}

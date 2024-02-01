using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject canvasPrefab;

    private void Start()
    {
        Instantiate(canvasPrefab, Vector3.zero, Quaternion.identity);
    }
}

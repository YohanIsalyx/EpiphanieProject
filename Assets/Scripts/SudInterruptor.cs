using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudInterruptor : MonoBehaviour
{
    public GameObject CubeToDisappeared;

    private void OnTriggerEnter(Collider other)
    {
        CubeToDisappeared.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        CubeToDisappeared.SetActive(true);
    }
}

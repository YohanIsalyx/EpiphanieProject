using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public GameObject CubeToDestroy;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(CubeToDestroy);
        }
    }
}

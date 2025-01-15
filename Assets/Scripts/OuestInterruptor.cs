using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuestInterruptor : MonoBehaviour
{
    public GameObject SphereToCreate; // PREFAB
    public Transform SpawnPosition;

    private GameObject SphereCreated;

    private bool IsOnZone;

    private void Update()
    {
        if(IsOnZone)
        {
            if (Input.GetKeyDown(KeyCode.E) && SphereCreated == null)
            {
                SphereCreated = Instantiate(SphereToCreate, SpawnPosition.position, Quaternion.identity); // SPHERE CREE
            }

            if(SphereCreated != null)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    //float r = Random.Range(0f, 1f);
                    //float g = Random.Range(0f, 1f);
                    //float b = Random.Range(0f, 1f);
                    SphereCreated.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();


                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsOnZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsOnZone = false;
        Destroy(SphereCreated);
    }
}

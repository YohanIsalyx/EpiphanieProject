using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class NordInterruptor : MonoBehaviour
{
    public GameObject CubeToCreate;
    public Transform SpawnPosition;

    private bool m_isOnZone;
    public float SpawnTime;
    private float m_currentTime;

    private void OnTriggerEnter(Collider other)
    {
        InstantiateCube();
        m_isOnZone = true;
        // SIMILAIRE
        //Destroy(Instantiate(CubeToCreate, SpawnPosition.position, Quaternion.identity), 5f);
    }

    private void OnTriggerExit(Collider other)
    {
        m_isOnZone = false;
        m_currentTime = 0;
    }

    private void Update()
    {
        if(m_isOnZone)
        {
            m_currentTime += Time.deltaTime;
            if (m_currentTime > SpawnTime)
            {
                m_currentTime = 0;
                InstantiateCube();
            }
        }
    }

    private void InstantiateCube()
    {
        GameObject go = Instantiate(CubeToCreate, SpawnPosition.position, Quaternion.identity);
        Destroy(go, 5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoScript : MonoBehaviour
{
    private bool m_isWaitingPlayerAction;

    private void Update()
    {
        if(m_isWaitingPlayerAction && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            m_isWaitingPlayerAction = false;
        }
    }

    private void LateUpdate()
    {
       
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        m_isWaitingPlayerAction = true;
        Debug.Log("Appuies sur la touche espace");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontalMove, 0, verticalMove) * Time.deltaTime * Speed;
        // SIMILAIRE
        //transform.Translate(new Vector3(horizontalMove, 0, verticalMove) * Time.deltaTime * Speed);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   float speed = 10.0f;// 속도
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true) 
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime); 
        }
    }
}

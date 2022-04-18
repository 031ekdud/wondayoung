using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController02 : MonoBehaviour
{
    private Rigidbody playerRd; // Rigidbody 컴포넌트 지정
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody> ();// Rigidbody 컴포넌트를 찾아서 지정
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRd.AddForce(0f, speed, 0f);
        }
    }
}
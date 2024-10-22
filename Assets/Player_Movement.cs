using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMove(InputValue value){
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 10;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AnimalController : MonoBehaviour
{
    [SerializeField] protected bool movingRight = true;
    [SerializeField] protected Rigidbody2D animalRb;
    [SerializeField] public float jumpForce;
    [SerializeField] public int runSpeed;
    public float jumpLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAnimal();
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y < jumpLevel)
            {
                Jump();
            }
            
        }
    }

    protected virtual void Jump()
    {
        animalRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
    }

    void MoveAnimal()
    {
        if (transform.position.x > 5)
        {
            movingRight = false;
        }
        if (transform.position.x < -5)
        {
            movingRight = true;
        }
        
        if (movingRight)
        {
            animalRb.AddForce(Vector2.right * Math.Max(0,(runSpeed - Math.Abs(animalRb.velocity.x))));
        }
        else
        {
            animalRb.AddForce(Vector2.left * Math.Max(0, (runSpeed - Math.Abs(animalRb.velocity.x))));
        }

        
    }
}

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
            if (transform.position.y < -1.2)
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
            animalRb.transform.Translate(Vector2.right * runSpeed * Time.deltaTime);
        }
        else
        {
            animalRb.transform.Translate(Vector2.left * runSpeed * Time.deltaTime);
        }
    }
}

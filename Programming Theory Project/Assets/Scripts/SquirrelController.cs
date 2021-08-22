using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelController : AnimalController
{
    protected override void Jump()
    {
        animalRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}

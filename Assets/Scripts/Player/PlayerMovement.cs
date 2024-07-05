using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float leftRightSpeed = 5;
    static public bool canMove=false;


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                if (this.gameObject.transform.position.x > LevelBoundaries.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                if (this.gameObject.transform.position.x < LevelBoundaries.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
        }
    }
}

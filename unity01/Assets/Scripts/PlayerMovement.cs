using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 10;
    private Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(MoveSpeed * -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(MoveSpeed, 0);
        }

        myRigidbody.MovePosition(myRigidbody.position + force * Time.fixedDeltaTime);
    }
}

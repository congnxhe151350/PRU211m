using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;
    public bool armor = false;
    public float timeSpawn = 0;
    public float timeDlay = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;
        if (moveSpeed > 10)
        {
            // timer.arlarmTime = 5;
            // timer.StartTime();
            // if(timer.isFinish){
            //     this.moveSpeed=10;
            // }

            this.timeSpawn += Time.deltaTime;
            if (this.timeSpawn < this.timeDlay) return;
            else
            {
                // this.timeSpawn = 0;
                Debug.Log(this.timeSpawn);
                // moveSpeed=10;
                this.setSpeed(10);
            }
        }   
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
        if (rb.transform.position.x > 8 && move.x > 0)
        {
            move.x = 0;
            move.y = 0;
            return;
        }
    }
    public float getSpeed()
    {
        return moveSpeed;
    }
    public float setSpeed(float value)
    {
        moveSpeed = value;
        return moveSpeed;
    }

    public bool getArmor()
    {
        return armor;
    }
    public bool setArmor(bool value)
    {
        armor = value;
        return armor;
    }
}

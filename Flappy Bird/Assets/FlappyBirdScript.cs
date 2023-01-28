using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public UserInfoScript info;
    public bool keepPlaying = true;
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindGameObjectWithTag("Info").GetComponent<UserInfoScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && keepPlaying == true)
        {
            rigidBody2D.velocity = Vector2.up * 12;
        }
        if (transform.position.y >= 9 || transform.position.y <= -9)
        {
            keepPlaying = false;
            info.youLost();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        keepPlaying = false;
        info.youLost();
    }
}

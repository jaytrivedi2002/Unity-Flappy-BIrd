using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughScript : MonoBehaviour
{
    public UserInfoScript info;
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindGameObjectWithTag("Info").GetComponent<UserInfoScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            info.updateScore();
        }
    }
}

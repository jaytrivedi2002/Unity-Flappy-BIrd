using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBarrier : MonoBehaviour
{
    public float velocity = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * velocity) * Time.deltaTime;

        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }
    }
}

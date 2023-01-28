using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierGeneratorScript : MonoBehaviour
{

    public GameObject barrier;
    public float spawnRate = 2;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        newBarrier();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            newBarrier();
            timer = 0;
        }
    }


    void newBarrier()
    {
        float minheight = transform.position.y - 6;
        float maxheight = transform.position.y + 6;
        Instantiate(barrier, new Vector3(transform.position.x, Random.Range(minheight, maxheight), 0), transform.rotation);
    }
}

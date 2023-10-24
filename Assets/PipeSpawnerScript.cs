using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 4;
    private float timer = 0;
    public float heightPoint = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
             timer = 0;
        }

    }

    private void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightPoint;
        float hightsPoint = transform.position.y + heightPoint;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint, hightsPoint)), transform.rotation);

    }
}

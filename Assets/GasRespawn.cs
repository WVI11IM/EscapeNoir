using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasRespawn : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform[] checkpoints;
    public int nextCheckpoint;
    public bool follow = true;
    public float dist;
    public int speed;
    public int checkpointIndex;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        checkpointIndex = nextCheckpoint - 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (follow == true)
        {
            dist = Vector2.Distance(transform.position, checkpoints[nextCheckpoint].position);

            if (dist <= 2) 
            {
                if (checkpointIndex == checkpoints.Length)
                {
                    follow = false;
                }
                    IncreaseIndex();
            }

            Move();


        }
    }

    public void IncreaseIndex()
    {
        nextCheckpoint++;
        checkpointIndex++;
    }

    public void Move()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    public void Respawn()
    {
        follow = false;
        gameObject.transform.position = checkpoints[checkpointIndex].position;
        follow = true;
    }
}

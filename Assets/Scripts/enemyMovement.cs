using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{
    public int movementType;
    public Transform[] points;
    //public Vector3 direction;
    public float patroTime = 3f;
    public float radius;
    public float speed;
    public float speadMultiplier;
    public float chasingTime;
    public float chasingDistence;
    public float detectRange;
    public float detectRangeMultiplier;
    private float timer = 0;
    private float waitTime;
    private int nextPoint = 0;

    void Start()
    {
        waitTime = patroTime;
    }

    void Update()
    {
        if (movementType == 0) { GoBackAndForth(); }
    }
    private void GoBackAndForth()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[nextPoint].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, points[nextPoint].position) < 0.2f)
        {
            nextPoint++;
            if (nextPoint == points.Length)
            {
                nextPoint = 0;
            }
            else if (waitTime <= 0)
            { 
                waitTime = patroTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        
    }
    private void GoARound()
    {

    }
    private void GoChasing()
    {

    }
}

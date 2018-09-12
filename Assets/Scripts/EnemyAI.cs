using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

    States currentState;
    
    enum States
    {
        Patrol,
        Chase,
        Wait
    }

	// Use this for initialization
	void Start ()
    {
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		switch (currentState)
        {
            case States.Patrol:
                Patrol();
                break;
            case States.Chase:
                Chase();
                break;
            case States.Wait:
                Wait();
                break;
        }
	}

    void ChangeToPatrol()
    {

    }

    void Patrol()
    {

    }

    void ChnageToChase()
    {

    }

    void Chase()
    {

    }

    void ChangeToWait()
    {

    }

    void Wait()
    {

    }


    /*
    
    public Transform[] patrolPoints;
    public Transform player;
    public float waitTime;

    NavMeshAgent navAgent;
    int currentPoint = 0;
    float waitTimer;

    navAgent = GetComponent<NavMeshAgent>();
        ChangeToPatrol();

    void ChangeToPatrol()
    {
        navAgent.SetDestination(patrolPoints[currentPoint].position);
        navAgent.isStopped = false;
        currentState = States.Patrol;
    }

    void Patrol()
    {

        if (Vector3.Distance(transform.position, patrolPoints[currentPoint].position) < 1)
        {
            currentPoint++;
            if (currentPoint >= patrolPoints.Length)
                currentPoint = 0;
            navAgent.SetDestination(patrolPoints[currentPoint].position);
        }

        if (Vector3.Distance(player.position, transform.position) < 10)
        {
            ChangeToChase();
        }

    }

    void ChangeToChase()
    {
        navAgent.isStopped = false;
        currentState = States.Chase;
    }

    void Chase()
    {
        navAgent.isStopped = false;
        navAgent.SetDestination(player.position);

        if (Vector3.Distance(player.position, transform.position) > 30)
        {
            ChangeToWait();
        }
    }

    void ChangeToWait()
    {
        currentState = States.Wait;
        waitTimer = waitTime;
    }

    void Wait()
    {
        waitTimer -= Time.deltaTime;
        navAgent.isStopped = true;

        if (waitTimer <= 0)
        {
            ChangeToPatrol();
        }
    }
    */
}

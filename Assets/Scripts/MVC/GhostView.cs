using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System;

public class GhostView : MonoBehaviour
{
    
    public NavMeshAgent navMeshAgent;
    public Vector3 walkPoint;
    public float walkPointRange;
    public bool walkPointSet;
    public float sightRange;
    public float attackrange;
    public bool playerInSightRange;
    public bool playerInAttackRange;
    public bool isAttacked;
    public GhostController ghostController;
   
    [SerializeField]
    private AiStateId activeState;
    public AiIdleState IdleState;
    public AiChaseStatePlayer chasingState;
    private object currentState;

    void Start()
    {
        ChangeState(activeState);
        GetPlayerTransform();

    }

    private void ChangeState(AiStateId activeState)
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        GhostController.GhostRange();
    }

    public void DestroyEnemyTank()
    {

        Destroy(gameObject);
    }

    //getting tnakplayer transform value
    public void GetPlayerTransform()
    {
        if (GhostService.Instance.ghostView)
            ghostPlayer = GhostService.Instance.tankController.TankView.transform;

        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    
    //using to change state in State machine
    public void ChangeState(AiStateId newState)
    {
        if (currentState != null)
        {
            currentState.OnExitState();
        }
        currentState = newState;
        currentState.OnEnterState();
    }

}


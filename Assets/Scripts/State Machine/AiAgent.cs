using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiAgent : MonoBehaviour
{
    public AiStateMachine stateMachine;
    public AiStateId initialState;
    public NavMeshAgent navMeshAgent;
    public AiAgentConfig config;
    public Transform playerTransform;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectsWithTag("Player").transform;
        stateMachine = new AiStateMachine(this);
        stateMachine.RegisterState(new AiChaseStatePlayer());
        stateMachine.RegisterState(new AiIdleState());
        stateMachine.ChangeState(initialState);
           
    }

    void Update()
    {
        stateMachine.Update();
    }
}

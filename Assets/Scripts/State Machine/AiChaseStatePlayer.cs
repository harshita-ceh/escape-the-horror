using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiChaseStatePlayer : AiState
{
    
    float timer = 0.0f;
    public AiAgentConfig config;
      
    public void Enter(AiAgent agent)
    {
       
    }

    public void Exit(AiAgent agent)
    {
       
    }

    public AiStateId GetId()
    {
        return AiStateId.ChasePlayer;
    }

    public void Update(AiAgent agent)
    {
        if (!agent.enabled)
        {
            return;
        }
        timer -= Time.deltaTime;
        if (!agent.navMeshAgent.hasPath)
        {
            agent.navMeshAgent.destination =agent.playerTransform.position;
        }
        if(timer < 0.0f)
        {
            Vector3 direction = (agent.playerTransform.position - agent.navMeshAgent.destination);
            direction.y = 0;
            if(direction.sqrMagnitude >agent.config.maxDistance * agent.config.maxDistance)
            {
                if(agent.navMeshAgent.pathStatus != NavMeshPathStatus.PathPartial)
                {
                    agent.navMeshAgent.destination = agent.playerTransform.position;

                }

            }
            timer = agent.config.maxTime;
        }
    }

    
}

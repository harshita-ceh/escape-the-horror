using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostModel
{
    public int Distance { get; }
    public float Time { get;  }
    


    public GhostModel(AiAgentConfig aiAgentConfig)
    {
        
        Distance = (int)aiAgentConfig.maxDistance;
        Time = aiAgentConfig.maxTime;

    }
}

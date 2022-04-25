using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTankService : MonoBehaviour
{
    public GhostView ghostView;
    
    
    public GhostController ghostController;
    public Transform[] points;

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            ghostController = CreateGhost();
        }

    }


    private GhostController CreateGhost()
    {
  
        GhostController tank = new GhostController(CreateGhost);
       
    }


}

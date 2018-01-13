using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName =  "PluggableAI/Actions/Patrol")]
public class PatrolAction : TankAction 
{
    public override void Act(StateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(StateController controller)
    {
        controller.navMeshAgent.destination = controller.wayPointList[controller.nextWayPoint].position;
        //controller.navMeshAgent.Resume();
        controller.navMeshAgent.isStopped = false; // Note: this was Resume() but that was obsolete

        if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance && !controller.navMeshAgent.pathPending)
        {
            controller.nextWayPoint = (controller.nextWayPoint + 1) % controller.wayPointList.Count;
        }
    }
}

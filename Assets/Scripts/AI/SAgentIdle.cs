
using GSFE.Utilities;
using UnityEngine;

namespace GSFE.AI
{
    public class SAgentIdle : AgentBaseState
    {
        GSFETimer idleTimer; 
        public override void EnterState(Brain agentBrain)
        {
            agentBrain.AgentMover.StopMovement();
            idleTimer = new GSFETimer(5f);
        }

        public override void ExitState(Brain agentBrain)
        {
            agentBrain.GoToCupboard();
        }

        public override void UpdateState(Brain agentBrain)
        {
            idleTimer.CountDown(Time.deltaTime);
            if (idleTimer.Finished())
            {
                ExitState(agentBrain);
            }
        }

        public override string ToString()
        {
            return "Agent is Idle";
        }
    }
}

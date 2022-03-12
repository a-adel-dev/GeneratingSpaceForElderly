using GSFE.Utilities;
using UnityEngine;

namespace GSFE.AI
{
    public class SAgentSitting : AgentBaseState
    {
        GSFETimer sittingTimer;
        public override void EnterState(Brain agentBrain)
        {
            sittingTimer = new GSFETimer(5f);
        }

        public override void ExitState(Brain agentBrain)
        {
            agentBrain.Exit();
        }

        public override void UpdateState(Brain agentBrain)
        {
            sittingTimer.CountDown(Time.deltaTime);
            Debug.Log(sittingTimer.TimerValue);
            if (sittingTimer.Finished())
            {
                ExitState(agentBrain);
            }
        }

        public override string ToString()
        {
            return "Agent is Sitting";
        }
    }
}

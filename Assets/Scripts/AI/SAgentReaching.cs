using GSFE.Utilities;
using UnityEngine;

namespace GSFE.AI
{
    public class SAgentReaching : AgentBaseState
    {
        GSFETimer cupboardTimer;
        public override void EnterState(Brain agentBrain)
        {
            cupboardTimer = new GSFETimer(5f);
        }

        public override void ExitState(Brain agentBrain)
        {
            agentBrain.GoToChair();
        }

        public override void UpdateState(Brain agentBrain)
        {
            cupboardTimer.CountDown(Time.deltaTime);
            if (cupboardTimer.Finished())
            {
                ExitState(agentBrain);
            }
        }

        public override string ToString()
        {
            return "Agent is Reaching";
        }
    }
}

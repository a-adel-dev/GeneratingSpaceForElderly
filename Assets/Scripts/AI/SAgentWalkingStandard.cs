namespace GSFE.AI
{
    public class SAgentWalkingStandard : AgentBaseState
    {
        bool reachedDestination;
        public override void EnterState(Brain agentBrain)
        {
            agentBrain.MoveTo(agentBrain.Destination);
        }

        public override void ExitState(Brain agentBrain)
        {
            if (agentBrain.Destination == agentBrain.Cupboard)
            {
                agentBrain.ReachCupboard();
            }

            if (agentBrain.Destination == agentBrain.Chair)
            {
                agentBrain.SitDown();
            }
        }

        public override void UpdateState(Brain agentBrain)
        {
            if (agentBrain.AgentMover.ReachedDestination())
            {
                ExitState(agentBrain);
            }

        }

        public override string ToString()
        {
            return "Agent is Walking";
        }
    }
}
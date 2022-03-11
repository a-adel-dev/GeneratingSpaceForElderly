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
            //throw new System.NotImplementedException();
        }

        public override void UpdateState(Brain agentBrain)
        {
            if (agentBrain.AgentMover.ReachedDestination())
            {
                reachedDestination = true;
            }
        }
    }
}
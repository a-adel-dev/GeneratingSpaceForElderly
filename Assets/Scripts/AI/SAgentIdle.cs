
namespace GSFE.AI
{
    public class SAgentIdle : AgentBaseState
    {
        public override void EnterState(Brain agentBrain)
        {
            agentBrain.StopMovement();
        }

        public override void ExitState(Brain agentBrain)
        {
            //throw new System.NotImplementedException();
        }

        public override void UpdateState(Brain agentBrain)
        {
            //throw new System.NotImplementedException();
        }
    }
}

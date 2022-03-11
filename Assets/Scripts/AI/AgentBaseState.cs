namespace GSFE.AI
{
    public abstract class AgentBaseState
    {
        public abstract void EnterState(Brain agentBrain);
        public abstract void UpdateState(Brain agentBrain);
        public abstract void ExitState(Brain agentBrain);
    }
}

using GSFE.AI;
using GSFE.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GSFE 
{ 
    public class Brain : MonoBehaviour
    {
        [SerializeField] Transform chair;
        [SerializeField] Transform bedLandingRight;
        [SerializeField] Transform bedLandingLeft;
        [SerializeField] Transform exit;
        [SerializeField] Transform cupboard;

        public Transform Destination { get; private set; }

        public Mover AgentMover { get; private set; }

        public AgentBaseState CurrentState { get; set; }
        Timer idleTimer = new Timer();

        private void Start()
        {
            AgentMover = GetComponent<Mover>();
            CurrentState = new SAgentIdle();
            CurrentState.EnterState(this);
            idleTimer.SetTimer(5f);

        }

        private void Update()
        {
            CurrentState.UpdateState(this);
            idleTimer.CountDown(Time.deltaTime);
            if (idleTimer.Finished())
            {
                Destination = cupboard;
                CurrentState = new SAgentWalkingStandard();
                CurrentState.EnterState(this);
            }
        }

        public void StopMovement()
        {
            AgentMover.StopMovement();
        }

        public void MoveTo(Transform destination)
        {
            AgentMover.MoveTo(destination);
        }

    }
}

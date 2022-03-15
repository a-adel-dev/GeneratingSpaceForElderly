using GSFE.AI;
using GSFE.Utilities;
using System;
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

        public Transform Chair { get => chair; private set => chair = value; }
        public Transform BedLandingRight { get => bedLandingRight; private set => bedLandingRight = value; }
        public Transform BedLandingLeft { get => bedLandingLeft; private set => bedLandingLeft = value; }
        public Transform RoomExit { get => exit; private set => exit = value; }
        public Transform Cupboard { get => cupboard; private set => cupboard = value; }

        public Transform Destination { get; private set; }

        public Mover AgentMover { get; private set; }

        public AgentBaseState CurrentState { get; set; }

        private void Start()
        {
            AgentMover = GetComponent<Mover>();
            CurrentState = new SAgentIdle();
            CurrentState.EnterState(this);
        }

        private void Update()
        {
            CurrentState.UpdateState(this);
        }


        public void GoToCupboard()
        {
            Destination = Cupboard;
            CurrentState = new SAgentWalkingStandard();
            CurrentState.EnterState(this);
        }

        public void ReachCupboard()
        {
            CurrentState = new SAgentReaching();
            CurrentState.EnterState(this);
        }

        public void GoToChair()
        {
            Destination = Chair;
            CurrentState = new SAgentWalkingStandard();
            CurrentState.EnterState(this);
        }

        public void SitDown()
        {
            CurrentState = new SAgentSitting();
            CurrentState.EnterState(this);
        }

        public void Exit()
        {
            Destination = RoomExit;
            CurrentState = new SAgentWalkingStandard();
            CurrentState.EnterState(this);
        }

        public void MoveTo(Transform destination)
        {
            AgentMover.MoveTo(destination);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace GSFE
{
    public class Mover : MonoBehaviour
    {
        NavMeshAgent navMeshAgent;
        Animator animator;
        [SerializeField] float distanceThreshold;
        [SerializeField] GameObject character;

        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            animator = character.GetComponent<Animator>();
        }

        private void Update()
        {
            UpdateAnimator();
        }

        private void UpdateAnimator()
        {
            Vector3 velocity = navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            animator.SetFloat("forwardSpeed", localVelocity.z);
            animator.SetFloat("lateralSpeed", localVelocity.x);
        }

        public void MoveTo(Transform _distination)
        {
            navMeshAgent.destination = _distination.position;
        }

        public bool ReachedDestination()
        {
            return Vector3.Distance(transform.position, navMeshAgent.destination) <= distanceThreshold;
        }

        public void StopMovement()
        {
            navMeshAgent.destination = transform.position;
        }
    }
}

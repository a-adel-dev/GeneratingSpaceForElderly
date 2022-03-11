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
            animator.SetBool("idle", true);
        }
    }
}

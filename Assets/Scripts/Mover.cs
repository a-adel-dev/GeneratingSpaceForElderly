using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    [SerializeField] float distanceThreshold;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Transform _distination)
    {
        navMeshAgent.destination = _distination.position;
    }

    public bool ReachedDestination()
    {
        return Vector3.Distance(transform.position, navMeshAgent.destination) <= distanceThreshold;
    }

}

using UnityEngine;
using UnityEngine.AI;

public class Moveable : MonoBehaviour
{
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void ChangeDestination(Vector3 destination)
    {
        agent.destination = destination;
    }
}
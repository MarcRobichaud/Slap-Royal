using UnityEngine;
using FSM;

public class Unit : MonoBehaviour, IAttacker, IHitable
{
    private Moveable moveable;
    private StateMachine fsm;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    private void Start()
    {
        fsm = new StateMachine();
    }

    public void OnHit(int damage)
    {
    }
}
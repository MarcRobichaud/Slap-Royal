using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public HashSet<Unit> Mobs;
    public HashSet<Tower> Towers;

    private void Start()
    {
        Towers = new HashSet<Tower>(GetComponentsInChildren<Tower>());
        Mobs = new HashSet<Unit>(GetComponentsInChildren<Unit>());
    }
}
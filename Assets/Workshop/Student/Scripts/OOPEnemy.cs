using Solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPEnemy : Character
{
    public void Start()
    {
        GetRemainEnergy();
    }

    public void Attack(OOPPlayer _player)
    {
        _player.energy -= attackPoint;
        Debug.Log("player is energy " + _player.energy);
    }
}
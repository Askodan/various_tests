using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOn : MonoBehaviour
{
    private ParticleSystem p_system;
    private bool fireOn = true;

    void Awake()
    {
        p_system = GetComponentInChildren<ParticleSystem>();
    }

    public void ChangeFireState()
    {
        fireOn = !fireOn;
        if (fireOn)
        {
            p_system?.Play(true);
        }
        else
        {
            p_system?.Stop(true);
        }
    }
}

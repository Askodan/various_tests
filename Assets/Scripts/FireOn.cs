using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOn : MonoBehaviour
{
    private ParticleSystem p_system;
    void Awake()
    {
        p_system = GetComponentInChildren<ParticleSystem>();
    }

    public void ChangeFireState()
    {
        if (p_system.isPlaying)
        {
            p_system?.Stop(true);
        }
        else
        {
            p_system?.Play(true);
        }
    }
}

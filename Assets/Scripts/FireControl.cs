using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public FireOn[] ControlledFires;

    private void OnFire()
    {
        foreach (var fire in ControlledFires)
        {
            fire.ChangeFireState();
        }
    }
}

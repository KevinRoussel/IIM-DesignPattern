using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyToggle : MonoBehaviour
{
    // Je veux ouvrir un �v�nement pour les designers pour qu'ils puissent set la couleur du sprite eux m�me



    public bool IsActive { get; private set; }


    public void Toggle()
    {
        IsActive = !IsActive;
    }

}

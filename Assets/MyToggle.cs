using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyToggle : MonoBehaviour
{
    // Je veux ouvrir un évènement pour les designers pour qu'ils puissent set la couleur du sprite eux même



    public bool IsActive { get; private set; }


    public void Toggle()
    {
        IsActive = !IsActive;
    }

}

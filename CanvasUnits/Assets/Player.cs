using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Disable()
    {
        this.gameObject.SetActive(false);
    }

    public void Enable()
    {
        this.gameObject.SetActive(true);
    }
}

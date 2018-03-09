using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Recource : MonoBehaviour
{
    public int Quantity;
    public UnityEvent OnQuantityChange = new UnityEvent();
    public bool Warning = false;

    public void AddAmount(int value)
    {
        Warning = false;
        Quantity += value;
        OnQuantityChange.Invoke();
    }

    public void SubstractAmount(int value)
    {
        if (Quantity < value)
        {
            Warning = true;
        }
        else
        {
            Warning = false;
            Quantity -= value;
        }
        OnQuantityChange.Invoke();
    }
}

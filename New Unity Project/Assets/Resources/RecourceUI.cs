using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecourceUI : MonoBehaviour
{
    public Recource recource;

    public Text WarningText;
    public float WarningDuration;

	void Start()
    {
        recource = GetComponent<Recource>();
	}
	public void ShowWarning()
    {
        StartCoroutine(ShowWarningForDuration(WarningDuration));
    }

    // Research Unity Coroutines
    IEnumerator ShowWarningForDuration(float duration)
    {
        WarningText.enabled = true;
        yield return new WaitForSeconds(duration);
        WarningText.enabled = false;
    }

    public void UpdateUI()
    {
        if (recource.Warning)
        {
            ShowWarning();
        }
        GetComponent<Text>().text = recource.Quantity.ToString();
	}
}

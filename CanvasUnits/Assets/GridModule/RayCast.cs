using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public TurnManager turnManager;
    public LayerMask unitMask;
    public Map map;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    public void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity, unitMask))
        {
            if (raycastHit.transform.GetComponentInParent<Unit>().Owner == turnManager.GetCurrentPlayer())
            {
                int X = (int)raycastHit.transform.parent.position.x;
                int Y = (int)raycastHit.transform.parent.position.y;
                SelectUnit(raycastHit.transform.parent.gameObject, X, Y);
            }
            else
            {
                print("Unit is not yours");
            }
        }
        else
        {
            DeselectUnit();
        }
    }

    public void SelectUnit(GameObject selectedObject, int x, int y)
    {
        selectedObject.SetActive(false);
        //Cell cell = map.GetCell((x + 1), (y + 1));
        //selectedObject.transform.position = cell.transform.position;
        //selectedObject.transform.SetParent(cell.transform, false);
    }

    public void DeselectUnit()
    {

    }
}

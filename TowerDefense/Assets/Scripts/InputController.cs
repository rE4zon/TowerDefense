using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public event Action<GameObject> Clicked;

    [SerializeField] private LayerMask layerMaskClickable;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {

            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);

            RaycastHit hit;
            bool isHit = Physics.Raycast(ray, out hit, 100, layerMaskClickable);
            if (isHit)
                Debug.Log(hit.collider.gameObject.name);
        }
    }
}

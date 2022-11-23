using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BackgroundDrop : MonoBehaviour, IDropHandler
{
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Please?");
        eventData.pointerDrag.transform.SetParent(tray.transform);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrayDrop : MonoBehaviour, IDropHandler
{
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.SetParent(tray.transform);
            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}

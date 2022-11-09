using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cab3Drop : MonoBehaviour, IDropHandler
{
    public GameObject cab3;
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.name == "Cupcakes")
            {
                cab3.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(cab3.transform);
                Destroy(eventData.pointerDrag.gameObject.GetComponent<Drag>());
                GameObject.Find("Minigame1Manager").GetComponent<Minigame1Manager>().cupcakeCounter++;
            }
            else if (eventData.pointerDrag.name == "Croissant" || eventData.pointerDrag.name == "Cookie")
            {
                cab3.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

        }
    }
}

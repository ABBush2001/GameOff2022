using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cab2Drop : MonoBehaviour, IDropHandler
{
    public GameObject cab2;
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.name == "Croissant")
            {
                cab2.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(cab2.transform);
                Destroy(eventData.pointerDrag.gameObject.GetComponent<Drag>());
                GameObject.Find("Minigame1Manager").GetComponent<Minigame1Manager>().croissantCounter++;
            }
            else if (eventData.pointerDrag.name == "Cookie" || eventData.pointerDrag.name == "Cupcakes")
            {
                cab2.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

        }
    }
}

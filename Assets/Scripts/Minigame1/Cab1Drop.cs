using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cab1Drop : MonoBehaviour, IDropHandler
{
    public GameObject cab1;
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.tag == "Cookie")
            {
                cab1.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(cab1.transform);
                Destroy(eventData.pointerDrag.gameObject.GetComponent<Drag>());
                GameObject.Find("Minigame1Manager").GetComponent<Minigame1Manager>().cookieCounter++;
            }
            else if(eventData.pointerDrag.tag == "Croissant" || eventData.pointerDrag.tag == "Cupcakes")
            {
                cab1.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shelf1Drop : MonoBehaviour, IDropHandler
{
    public GameObject shelf1;
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "compost")
            {
                Destroy(eventData.pointerDrag.gameObject);
                GameObject.Find("Minigame3Manager").GetComponent<Minigame3Manager>().plateCounter++;
            }
            else if (eventData.pointerDrag.tag == "recycle" || eventData.pointerDrag.tag == "trash")
            {
                shelf1.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}

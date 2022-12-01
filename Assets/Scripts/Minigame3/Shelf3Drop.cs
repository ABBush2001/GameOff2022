using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shelf3Drop : MonoBehaviour, IDropHandler
{
    public GameObject shelf3;
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "trash")
            {
                Destroy(eventData.pointerDrag.gameObject);
                GameObject.Find("Minigame3Manager").GetComponent<Minigame3Manager>().cupCounter++;
            }
            else if (eventData.pointerDrag.tag == "recycle" || eventData.pointerDrag.tag == "compost")
            {
                shelf3.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}

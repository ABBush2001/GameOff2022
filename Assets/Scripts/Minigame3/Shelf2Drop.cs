using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shelf2Drop : MonoBehaviour, IDropHandler
{
    public GameObject shelf2;
    public GameObject tray;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "recycle")
            {
                Destroy(eventData.pointerDrag.gameObject);
                GameObject.Find("Minigame3Manager").GetComponent<Minigame3Manager>().forkCounter++;
            }
            else if (eventData.pointerDrag.tag == "trash" || eventData.pointerDrag.tag == "compost")
            {
                shelf2.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}

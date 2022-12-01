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
            if (eventData.pointerDrag.name == "Plate")
            {
                shelf1.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(shelf1.transform);
                Destroy(eventData.pointerDrag.gameObject.GetComponent<Drag>());
                GameObject.Find("Minigame3Manager").GetComponent<Minigame3Manager>().plateCounter++;
            }
            else if (eventData.pointerDrag.name == "Fork" || eventData.pointerDrag.name == "Cup")
            {
                shelf1.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}

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
            if (eventData.pointerDrag.name == "Cup")
            {
                shelf3.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(shelf3.transform);
                Destroy(eventData.pointerDrag.gameObject.GetComponent<Drag>());
                GameObject.Find("Minigame3Manager").GetComponent<Minigame3Manager>().cupCounter++;
            }
            else if (eventData.pointerDrag.name == "Fork" || eventData.pointerDrag.name == "Plate")
            {
                shelf3.GetComponent<HorizontalLayoutGroup>().enabled = true;
                eventData.pointerDrag.transform.SetParent(tray.transform);
            }

            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GameObject.Find("MasterCanvas").GetComponent<Canvas>();

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        /*For Minigame 1*/
        if(eventData.pointerDrag.name == "Cookie")
        {
            GameObject.Find("Shelf1").GetComponent<HorizontalLayoutGroup>().enabled = false;
            this.transform.SetParent(GameObject.Find("Minigame1Canvas").transform);
        }
        else if(eventData.pointerDrag.name == "Croissant")
        {
            GameObject.Find("Shelf2").GetComponent<HorizontalLayoutGroup>().enabled = false;
            this.transform.SetParent(GameObject.Find("Minigame1Canvas").transform);
        }
        else if (eventData.pointerDrag.name == "Cupcakes")
        {
            GameObject.Find("Shelf3").GetComponent<HorizontalLayoutGroup>().enabled = false;
            this.transform.SetParent(GameObject.Find("Minigame1Canvas").transform);
        }
        /*For Minigame 1*/

        /*For Minigame 3*/
        if (eventData.pointerDrag.name == "Plate")
        {
            GameObject.Find("Shelf1").GetComponent<HorizontalLayoutGroup>().enabled = false;
            this.transform.SetParent(GameObject.Find("Minigame3Canvas").transform);
        }
        else if (eventData.pointerDrag.name == "Fork")
        {
            GameObject.Find("Shelf2").GetComponent<HorizontalLayoutGroup>().enabled = false;
            this.transform.SetParent(GameObject.Find("Minigame3Canvas").transform);
        }
        else if (eventData.pointerDrag.name == "Cup")
        {
            GameObject.Find("Shelf3").GetComponent<HorizontalLayoutGroup>().enabled = false;
            this.transform.SetParent(GameObject.Find("Minigame3Canvas").transform);
        }
        /*For Minigame 3*/


        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        /*if (isDraggable)
        {
            //canvasGroup.blocksRaycasts = false;

            //trying to fix drag/drop
            parentToReturnTo = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent);
        }*/

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //
        //this.transform.SetParent(parentToReturnTo);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}

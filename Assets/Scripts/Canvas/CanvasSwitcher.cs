using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CanvasSwitcher : MonoBehaviour
{
    public CanvasType desiredCanvasType;

    CanvasManager canvasManager;
    Button menuButton;

    private void Start()
    {
        //menuButton = GetComponent<Button>();
        //menuButton.onClick.AddListener(OnButtonClicked);        //This OnButtonClicked Function will trigger everytime the Button is clicked
        canvasManager = CanvasManager.GetInstance();
    }

    public void SwitchCanvas()
    {
        Debug.Log("Canvas Switching");

        //switch from explain to minigame 1
        if(GameObject.Find("MasterCanvas").GetComponent<CanvasManager>().mini1 == false && GameObject.Find("ExplainCanvas"))
        {
            desiredCanvasType = CanvasType.Minigame1Canvas;
            GameObject.Find("MasterCanvas").GetComponent<CanvasManager>().mini1 = true;
            canvasManager.SwitchCanvas(desiredCanvasType);
        }
        //switch from explain to minigame 2
        else if(GameObject.Find("MasterCanvas").GetComponent<CanvasManager>().mini2 == false && GameObject.Find("ExplainCanvas"))
        {
            desiredCanvasType = CanvasType.Minigame2Canvas;
            GameObject.Find("MasterCanvas").GetComponent<CanvasManager>().mini2 = true;
            canvasManager.SwitchCanvas(desiredCanvasType);
            
        }
        //switch from explain to minigame 3
        else if(GameObject.Find("MasterCanvas").GetComponent<CanvasManager>().mini3 == false && GameObject.Find("ExplainCanvas"))
        {
            desiredCanvasType = CanvasType.Minigame3Canvas;
            GameObject.Find("MasterCanvas").GetComponent<CanvasManager>().mini3 = true;
            canvasManager.SwitchCanvas(desiredCanvasType);
        }
        //else go to default
        else
        {
            canvasManager.SwitchCanvas(desiredCanvasType);
        }
        
    }

}

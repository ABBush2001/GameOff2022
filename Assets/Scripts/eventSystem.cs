using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class eventSystem : MonoBehaviour
{
    public TextMeshProUGUI objectives;
    public Toothbrush toothBrush;
    public Coffee coffee;
    public int level;
    public int trashGrab;

    // Start is called before the first frame update
    void Start()
    {
        objectives.text = "";
        level = 1;
        trashGrab = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(level == 1){
            if(!toothBrush.eTooth)
            {
                objectives.text = "Brush your teeth";
            }
            else if(!coffee.eCoffee)
            {
                objectives.text = "go make some coffee";
            }
            else objectives.text = "go to your computer";
        }
    }
}

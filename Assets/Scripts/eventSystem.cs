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
        if(level == 2){
            if(trashGrab < 3)
            {
                objectives.text = "clean up your mess! pickup some trashbags";
            }
            else objectives.text = "go back to your computer";
        }
        if(level == 3){
            objectives.text = "well... time for bed I guess";

        }
    }
}

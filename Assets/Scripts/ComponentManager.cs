using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentManager : MonoBehaviour
{
    private static ComponentManager instance;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}

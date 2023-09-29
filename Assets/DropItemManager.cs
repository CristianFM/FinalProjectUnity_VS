using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemManager : MonoBehaviour
{
    public static DropItemManager staticDropManager;

    public List<GameObject> dropItems;
    public GameObject DropContainer;

    // Start is called before the first frame update
    void Start()
    {
        if(staticDropManager == null)
        {
            staticDropManager = this;
        }

        DropContainer = GameObject.FindGameObjectWithTag("DropContainer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject getRandomDrop()
    {
        int random = Random.Range(0, dropItems.Count - 1);
        return dropItems[random];
    }
}

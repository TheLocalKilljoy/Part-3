using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

    public GameObject button;

    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int s = 0; s < inventory.items.Length; s = s + 1)
            {
                if (inventory.items[s] == 0)
                { 
                    inventory.items[s] = 1; 
                    Instantiate(button, inventory.slots[s].transform, false); 
                    Destroy(gameObject);
                    break;
                }
            }
        }

    }
}
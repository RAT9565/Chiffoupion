using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;   

public class Bouton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Select()
    {
        transform.Find("Text").GetComponent<TextMeshProUGUI>().text = "X";
        GetComponent<Button>().interactable = false;
        Debug.Log("clique"); 
        int index = int.Parse(gameObject.name);   
        GameObject.Find("Canva").GetComponent<GameManager>().matrix[index] = "X";   
    }


}

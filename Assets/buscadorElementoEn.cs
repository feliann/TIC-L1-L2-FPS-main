using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buscadorElementoEn : MonoBehaviour
{
    [SerializeField] GameObject[] arrayDeMesas;
    [SerializeField] string tagDeMesa;
    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag(tagDeMesa);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void BuscarElementoEnArray()
    {
        //para buscar elemento usamos un while
        bool isFound = false;
        int i = 0;
        while (i < arrayDeMesas.Length && !isFound)
        {
            if (arrayDeMesas[i].GetComponent<mesa>().owner=="felipe")
            {
                Destroy(arrayDeMesas[i]);
                return;
            }
            i++;
        }
    }    
   
}

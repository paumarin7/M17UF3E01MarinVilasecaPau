using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearNota : MonoBehaviour
{
    [SerializeField]
    private GameObject nota;
    [SerializeField]
    private float min;
    [SerializeField]
    private float max;

    public bool crear = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if(!crear)
        {
            Debug.Log("h");
            StartCoroutine(  crearNota());
            crear = true;
        }

    }

    public IEnumerator crearNota()
    {
        Instantiate(nota, transform);
        yield return new WaitForSeconds(Random.Range(min, max));
        crear= false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limite : MonoBehaviour
{

    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gm.GetComponent<GameManager>().puntos--;
        Destroy(other.gameObject);
    }
}

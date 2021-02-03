using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Nota n;
    public int puntos;
    public float speed;
    public Text puntosText;
    public bool hola=false;

    public AudioSource sonidoj;

    public AudioClip fallo;
    public AudioClip bien;
    // Start is called before the first frame update
    void Start()
    {
        hola = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (puntos >= 3)
        {
            if (!hola)
            {
                StartCoroutine(subirVelocidad());
                hola = true;
            }
        }

        puntosText.text = "Puntos: " + puntos;
    }

    public IEnumerator subirVelocidad()
    {

        Debug.Log("sb");
        speed += 0.001f;
        yield return new WaitForSeconds(10);
        hola = false;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableLetter : MonoBehaviour
{
    public char letter;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 5, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (ScoreAndWordCompletion.checkLetter(letter))
        {
            Destroy(gameObject);
        }
    }
}

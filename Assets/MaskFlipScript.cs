using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskFlipScript : MonoBehaviour
{
    void Update()
    {
        Vector3 characterScale = transform.localScale;
        if (Input.GetKey(KeyCode.D) && characterScale.x < 0 && Input.GetKey(KeyCode.A) == false)
        {
                characterScale.x = -1 * characterScale.x;
        }
        if (Input.GetKey(KeyCode.A) && characterScale.x > 0 && Input.GetKey(KeyCode.D) == false)
        {
                characterScale.x = -1 * characterScale.x;
        }
        transform.localScale = characterScale;
    }
}

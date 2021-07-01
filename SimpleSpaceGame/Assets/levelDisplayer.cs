using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class levelDisplayer : MonoBehaviour
{
    TMPro.TMP_Text levelTextMesh;

    [SerializeField] string levelText;
    [SerializeField] float displayForSeconds;

    private void Start()
    {

        levelTextMesh = gameObject.GetComponentInChildren<TMPro.TMP_Text>();

        StartCoroutine("displayText");


    }

  


    IEnumerator displayText()
    {
        levelTextMesh.text = levelText;
        yield return new WaitForSeconds(displayForSeconds);
        levelTextMesh.text = "";
    }




}

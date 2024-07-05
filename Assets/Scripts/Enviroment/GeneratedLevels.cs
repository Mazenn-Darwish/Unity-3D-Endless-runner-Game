using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedLevels : MonoBehaviour
{
    public GameObject[] section;
    public int zPos =50 ;
    public bool creatingSection = false;
    public int SecNum;
     void Update()
    { if( creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
        
    }
    IEnumerator GenerateSection()
    {
        SecNum = Random.Range(0, 4);
        Instantiate(section[SecNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(2);
        creatingSection= false;
    }
}
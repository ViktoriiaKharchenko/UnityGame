using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileOptions : MonoBehaviour
{
    public Color[] colors;
    public Image imagePrefab;
    public VerticalLayoutGroup container;

    void Start()
    {
        for(int i = 0; i < colors.Length; i++)
        {
            
        }
    }
    public void ChangeColor()
    {
        Color c = imagePrefab.color;
    }
}

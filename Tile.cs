using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Tile : MonoBehaviour
{
    public string value = "A";
    public int size = 50;
    public Color fontcolor;
    public Color outlineColor;
    public float outlineWidth = .15f;
    public TMP_FontAsset Font;
    public ABC ABC;


    private TextMeshProUGUI letter;
    private GameObject Letter;
    void Start()
    {
        Letter = new GameObject("Letter");
        Letter.transform.parent = gameObject.transform;

        letter = Letter.AddComponent(typeof(TextMeshProUGUI)) as TextMeshProUGUI;
        

        RectTransform rt = letter.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(100, 100); ;
        rt.transform.position = new Vector3(0, 0, 0);
        rt.transform.localPosition = new Vector2(0, 0);
        rt.transform.localScale = new Vector2(1, 1);

        letter.font = Font;
        letter.text = value;
        letter.color = fontcolor;
        letter.fontSize = size;
        letter.fontMaterial.color = fontcolor;
        letter.alignment = TextAlignmentOptions.Center;
        letter.fontStyle = FontStyles.Bold;
        //letter.outline = true;
        letter.outlineColor = outlineColor;
        letter.outlineWidth = outlineWidth;

        changeLetter();
       
    }

    public int starting = 250;
    private int x;
    void Update()
    {
        if (x < starting)
        {
            changeLetter();
            x++;
        }
        
    }

    public void changeLetter()
    {          
        value = ABC.abcRand[Random.Range(0,ABC.abcRand.Length)];
        letter.text = value;
    }
}

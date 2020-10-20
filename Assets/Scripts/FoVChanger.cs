using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoVChanger : MonoBehaviour
{
    [SerializeField]
    private Slider foVSlider;

    [SerializeField]
    private TextMeshProUGUI foVValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FoVChange()
    {
        Camera.main.fieldOfView = foVSlider.value;
        foVValue.text = foVSlider.value.ToString();
    }
}

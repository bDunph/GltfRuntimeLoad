using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchText : MonoBehaviour
{
    public TMPro.TMP_InputField modelPath;
    public TMPro.TMP_Text modelPathEntered;

    string s_path;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GetPaths()
    {
        s_path = modelPath.text;
        modelPathEntered.text = s_path;
    }
}

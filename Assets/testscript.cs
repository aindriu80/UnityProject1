using UnityEngine;
using UnityEngine.UI;

public class testscript : MonoBehaviour
{

    // Use this for initialization
    public string name;
    public Text text;

    void Start()
    {
        text.text = name;
        //boxCol = GetComponent<BoxCollider>();
        //boxCol.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(name);

    }
}

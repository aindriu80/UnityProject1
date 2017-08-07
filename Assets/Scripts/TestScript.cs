using System;
using UnityEngine;
using UnityEngine.UI;


public class TestScript : MonoBehaviour {
        
        public Text text;
        string hour;
        string minute;
        string second;

        // Use this for initialization
        void Start ()
        {
        }
	
        // Update is called once per frame
        void Update ()
        {
        CreateClock();
        }

        void CreateClock()
        {
            DateTime currentTime = DateTime.Now;
            hour = currentTime.Hour.ToString();
            minute = currentTime.Minute.ToString();
            second = currentTime.Second.ToString();
            text.text = hour + ":" + minute + ":" + second;
        }
    }


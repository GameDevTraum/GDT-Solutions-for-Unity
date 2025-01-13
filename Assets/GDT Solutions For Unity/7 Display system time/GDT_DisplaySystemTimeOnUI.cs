namespace GDTSolutions
{
    namespace DisplaySystemTimeOnUI
    {

        using UnityEngine;
        using TMPro; //We declare the TMPro namespace
        using System;//We declare the System namespace

        public class GDT_DisplaySystemTimeOnUI : MonoBehaviour
        {

            public TMP_Text text_currentTime;//We declare a TMP_Text variable
            DateTime currentTime;
            
            void Start()
            {

            }


            void Update()
            {
                currentTime = DateTime.Now;
                int hour = currentTime.Hour;
                int minute = currentTime.Minute;
                int second = currentTime.Second;
                text_currentTime.text = hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");
            }

        }

    }
}


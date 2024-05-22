using BepInEx;
using BepInEx.Unity.IL2CPP;
using System;
using UnityEngine;

namespace Basse
{
    [BepInPlugin("BlazeBBestPortedByBiscuit", "FlipScreen", "1.0.1")]
    public class Main : BasePlugin
    {
        public override void Load()
        {
            AddComponent<FlipScreen>();
        }

        public class FlipScreen : MonoBehaviour
        {
            void Start()
            {
                Console.WriteLine("FlipScreen Loaded !");
            }
            void Update()
            {
                if (!Input.GetKey(KeyCode.LeftControl)) return;

                Camera camera = Camera.main;
                if (camera == null) return;

                float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
                if (mouseWheel > 0.1)
                {
                    Quaternion quaternion = camera.transform.rotation;
                    Vector3 euler = quaternion.eulerAngles;
                    euler -= Vector3.forward;
                    camera.transform.rotation = Quaternion.Euler(euler);
                }
                else if (mouseWheel < -0.1)
                {
                    Quaternion quaternion = camera.transform.rotation;
                    Vector3 euler = quaternion.eulerAngles;
                    euler += Vector3.forward;
                    camera.transform.rotation = Quaternion.Euler(euler);
                }
            }
        }
    }
}

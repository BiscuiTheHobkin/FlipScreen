using MelonLoader;
using UnityEngine;
using System;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Flip
{
    public static class BuildInfo
    {
        public const string Name = "FlipScreen";
        public const string Description = "Ported version of the FScreen made by BlazeBest.";
        public const string Author = "BlazeBest | Ported by Biscuit";
        public const string Company = null;
        public const string Version = "1.0";
        public const string DownloadLink = null;
    }

    public class FlipScreen : MelonMod
    {
        public override void OnInitializeMelon() 
        {
         MelonLogger.Msg("FlipScreen Loaded !");
         MelonLogger.Msg("Use your left control key + Mouse ScrollWheel");
        }

        public void Update()
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
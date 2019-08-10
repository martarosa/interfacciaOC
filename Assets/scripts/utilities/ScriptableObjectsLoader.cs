using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace INTOC
{
    public static class ScriptableObjectsLoader
    {
        public static T[] GetAllInstances<T>(string path) where T : ScriptableObject
        {
            return Resources.LoadAll<T>(path);
        }

        public static T GetInstance<T>(string path) where T : ScriptableObject
        {
            return Resources.Load<T>(path);
        }
    }

}


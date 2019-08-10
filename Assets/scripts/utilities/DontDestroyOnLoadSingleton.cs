using UnityEngine;

namespace INTOC {
    public class DontDestroyOnLoadSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        void Awake()
        {
            if (_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
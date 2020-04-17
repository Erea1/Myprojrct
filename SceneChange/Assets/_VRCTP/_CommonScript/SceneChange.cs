using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRCTP.CommonScript {
    public class SceneChange : MonoBehaviour
    {
        [SerializeField]
        private string m_NextScene;

        public void FR_ChangeScene()
        {
            if (m_NextScene == "Quit")
            {
                Application.Quit();
            }
            else if (m_NextScene != "")
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(m_NextScene);
            }
        }

        public void FR_ChangeScene(string _scene)
        {
            m_NextScene = _scene;
            FR_ChangeScene();
        }
    }
}


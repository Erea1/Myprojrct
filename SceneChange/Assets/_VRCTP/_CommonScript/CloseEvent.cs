using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRCTP.CommonScript {
    public class CloseEvent : MonoBehaviour
    {
        [SerializeField]
        private Button mBtn_Close;

        [SerializeField]
        private GameObject[] mObjs_DeActive;
        [SerializeField]
        private GameObject[] mObjs_Destory;

        // Use this for initialization
        void Start()
        {
            if (mBtn_Close != null) {
                mBtn_Close.onClick.AddListener(FC_CloseEvent);
            }
        }

        private void FC_CloseEvent() {
            foreach (GameObject _daobj in mObjs_DeActive) {
                _daobj.SetActive(false);
            }

            foreach (GameObject _dsobj in mObjs_Destory) {
                _dsobj.SetActive(false);
            }
        }
    }

}

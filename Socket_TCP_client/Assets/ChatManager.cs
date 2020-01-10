using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour {
    public string ipaddress= "192.168.124.9";
    public int port = 7788;
    private Socket clientScocket;
    public Text ChatLable;
    public InputField textInput;
    public Thread t;
    private byte[] data = new byte[1024];
    private string message = "";//消息容器
    // Use this for initialization
	void Start () {
        ConnectedToServer();

    }
	
	// Update is called once per frame
	void Update () {
        if (message!=null&&message!="")
        {
            ChatLable.text += "\n" + message;
            message = "";
        }
	}
     void ConnectedToServer()
    {
        clientScocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //发起连接
        clientScocket.Connect(new IPEndPoint(IPAddress.Parse(ipaddress), port));

        //创建一个线程接受消息
        t = new Thread(ReceiveMessage);
        t.Start();


    }
    void ReceiveMessage()
    {
        while (true)
        {
            if (clientScocket.Connected ==false)
            {
                break;
            }
            int Length = clientScocket.Receive(data);
            message = Encoding.UTF8.GetString(data, 0, Length);
            //ChatLable.text += "\n" + message;
            
        }
        
    }
    void SendMessage(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        clientScocket.Send(data);
    }
    public void OnsendBtnClick()
    {
        string value = textInput.text;
        SendMessage(value);
    }
    private void OnDestroy()
    {
        clientScocket.Shutdown(SocketShutdown.Both);
        clientScocket.Close();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.Events;

public class Arduino : MonoBehaviour
{

    public static string portName = "COM7"; //change this to arduino port
    public static int portSpeed = 9600;
    private SerialPort sp = new SerialPort(portName, portSpeed);
    private bool state;
    private string byteValue;

    [SerializeField] private List<string> _TextFromArduino;
    public UnityEvent OnArduinoTextred = new UnityEvent();
    public UnityEvent OnArduinoTextorange = new UnityEvent(); //duplicate this line if you want more than 2 text
    public UnityEvent OnArduinoTextyellow = new UnityEvent();
    public UnityEvent OnArduinoTextgreen = new UnityEvent();
    public UnityEvent OnArduinoTextcyan = new UnityEvent();
    public UnityEvent OnArduinoTextblue = new UnityEvent();
    public UnityEvent OnArduinoTextmagenta = new UnityEvent();


    void Awake()
    {
        _TextFromArduino = new List<string> { "Text0", "Text1", "Text2" }; // Change the default values to match your requirements
        OpenConnection();
    }
    void Update()
    {
       
        if (sp.IsOpen)
        {
            string value = ReadSerialPort();
         
         if (value != null)
         {
       

                if (value.Contains("R"))
                {
                  
                   Debug.Log("Red received");
                   OnArduinoTextred.Invoke();
                }
                else if (value.Contains("O"))
                {
                    
                    Debug.Log("Orange received");
                    OnArduinoTextorange.Invoke();
                }
                else if (value.Contains("Y"))
                {
                    
                    Debug.Log("Yellow received");
                    OnArduinoTextyellow.Invoke();
                }
               else if (value.Contains("G"))
                {
                    
                    Debug.Log("Green received");
                    OnArduinoTextgreen.Invoke();
                }
                else if (value.Contains("C"))
                {
                   
                    Debug.Log("Cyan received");
                    OnArduinoTextcyan.Invoke();
                }
               else if (value.Contains("B"))
                {
                    
                    Debug.Log("Blue received");
                   OnArduinoTextblue.Invoke();
                }
               else if (value.Contains("M"))
               {
                   
                   Debug.Log("Magenta received");
                   OnArduinoTextmagenta.Invoke();
                }
               
            }

        }
        
    }
    
    
    public void OpenConnection()
    {
        if (sp != null)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                Debug.Log("Closing port, because it's already open");
            }
            else
            {
                sp.Open();
                sp.ReadTimeout = 1;
                Debug.Log("port open at" + portName + portSpeed);
            }
        }
        else
        {
            if (sp.IsOpen)
            {
                Debug.Log("port is already open");
            }
            else
            {
                Debug.Log("port == null");
            }
        }
    }

    public void CloseConnection()
    {
        if (sp != null)
        {
            sp.Close();
            Debug.Log("closing port at" + portName + portSpeed);
        }
    }



    public string ReadSerialPort(int timeout = 10)
    {
        string readByte;
        sp.ReadTimeout = timeout;
        
        
        try
        {
            readByte = sp.ReadLine();
            return readByte;
        }
        catch(TimeoutException)
        {
            return null;
        }
    }
    
    public void WriteSerialPort(string text)
    {
       sp.Write(text);
      
    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduGarenderServer
{
     
    public class SerialPortManager
    {
        // A delegate type for hooking up change notifications.
        

        SerialPort serialPort = new SerialPort();
        public SerialPortSettings Settings = new SerialPortSettings();
 
        Exception lastException = new Exception();

        public SerialPortManager()
        { 

        }

        public bool Connect()
        {
            try
            {
                serialPort.PortName = Settings.PortName;
                serialPort.Open();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception thisException)
            {
                lastException = thisException;
                return false;
            }

            return true;
        }

        public bool Connect(String PortName)
        {
            Settings.PortName = PortName;
            return Connect();
        }

        public bool Disconnect()
        {
            try
            {
                serialPort.Close();
                serialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception thisException)
            {
                lastException = thisException;
                return false;
            }
            return true;
        }

        public bool SetConfig(string PortName, int BaudRate, string Parity, string StopBits, int DataBits )
        {
            try {
                Settings.PortName = PortName;
                Settings.BaudRate = BaudRate;
                Settings.Parity = Settings.ParseParityFromString(Parity);
                Settings.StopBits = Settings.ParseStopBitsFromString(StopBits);
                Settings.DataBits = DataBits;
                //handshake = Handshake;
                 
            }
            catch (Exception thisException)
            {
                lastException = thisException;
                return false;
            }
            return true;

        }

        public Exception LastException()
        {
            return lastException;
        }

        public string Status()
        {
            return serialPort.IsOpen ? "Connected" : "Disconnected";
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //Debug.Print("Data Received:");
            Debug.Print(indata);
        }

       

        
    }
}

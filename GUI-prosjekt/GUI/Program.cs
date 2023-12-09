using System;
using System.Collections;
using System.IO.Ports;
using System.Reflection.PortableExecutable;

namespace GUI
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of Form1
            Form1 form1 = new Form1();


            //double volt;
            //int percentVolt = 0;

            // get voltage

            //SD = MessageType + CastType + Direction + Length


            // setting voltage, 30V

            // remember to turn on remote control first




            // Remember the dataframe setup, SD, DN,   OBJ, DATA [hex1, hex2] checksum1, checksum2
            //OBJ 0x36 = 54
            /*
            byte[] bytesToSendToTurnOnRC = new byte[] { 0xF1, 0x00, 0x36, 0x10, 0x10, 0x01, 0x47 }; // Turn on remote control
            List<byte> RCresponse;
            using (SerialPort port = new SerialPort("Com9", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSendToTurnOnRC, 0, bytesToSendToTurnOnRC.Length);
                Thread.Sleep(50);
                RCresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        RCresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
                if (RCresponse[3] == 0)
                {
                    Console.WriteLine("Remote Control is turned on");
                    form1.remoteControl = string.Format("Remote Control is turned on");
                }
                else
                {
                    Console.WriteLine(String.Format("Remote control is not turned on due to error: {0}", RCresponse[3].ToString()));
                    form1.remoteControl = string.Format("Remote control is not turned on due to error: {0}", RCresponse[3].ToString());
                }
            }

            // 
            float setVolt = 60;
            int percentSetValue = (int)Math.Round((25600 * setVolt) / 84);

            string hexValue = percentSetValue.ToString("X");
            string hexValue1 = "";
            string hexValue2 = "";

            if (hexValue.Length == 4)
            {
                hexValue1 = hexValue.Substring(0, hexValue.Length / 2);
                hexValue2 = hexValue.Substring(hexValue.Length / 2);
            }
            else if (hexValue.Length == 3)
            {
                hexValue1 = hexValue.Substring(0, 1);
                hexValue2 = hexValue.Substring(1);
            }
            else if ((hexValue.Length is 2) || (hexValue.Length is 1))
            {
                hexValue1 = "0";
                hexValue2 = hexValue;
            }
            byte[] newbytesWithoutChecksum = { 0xF2, 0x00, 0x32, Convert.ToByte(hexValue1, 16), Convert.ToByte(hexValue2, 16), 0x0, 0x0 };

            int newsum = 0;
            int newarrayLength = newbytesWithoutChecksum.Length;
            for (int i = 0; i < newarrayLength; i++)
            {
                newsum += newbytesWithoutChecksum[i];
            }

            string newhexSum = newsum.ToString("X");
            string newcs1 = "";
            string newcs2 = "";
            if (hexSum.Length == 4)
            {
                newcs1 = newhexSum.Substring(0, newhexSum.Length / 2);
                newcs2 = newhexSum.Substring(newhexSum.Length / 2);
            }
            else if (newhexSum.Length == 3)
            {
                newcs1 = newhexSum.Substring(0, 1);
                newcs2 = newhexSum.Substring(1);
            }
            else if ((newhexSum.Length is 2) || (newhexSum.Length is 1))
            {
                newcs1 = "0";
                newcs2 = newhexSum;
            }

            if (newcs1 != "")
            {


                newbytesWithoutChecksum[newarrayLength - 2] = Convert.ToByte(newcs1, 16);
                newbytesWithoutChecksum[newarrayLength - 1] = Convert.ToByte(newcs2, 16);
            }

            List<byte> newResponseTelegram;
            using (SerialPort port = new SerialPort("Com9", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(newbytesWithoutChecksum, 0, newbytesWithoutChecksum.Length);
                Thread.Sleep(500);

                newResponseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        newResponseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            if (newResponseTelegram[3] == 0)
            {
                Console.WriteLine("New voltage was set");
            }
            else
            {
                Console.WriteLine(newResponseTelegram[3].ToString());
            }


            // reading serial number
            List<byte> Serialresponse;
            // Remember the dataframe setup, SD, DN,   OBJ, DATA checksum1, checksum2
            // OBJ = 0x01 = 1
            byte[] serialBytesToSend = { 0x7F, 0x00, 0x01, 0x00, 0x80 };
            using (SerialPort port = new SerialPort("Com9", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(serialBytesToSend, 0, serialBytesToSend.Length);
                Thread.Sleep(500);

                Serialresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        Serialresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);

                string binary = Convert.ToString(Serialresponse[0], 2);
                string payloadLengtBinaryString = binary.Substring(4);
                int payloadLength = Convert.ToInt32(payloadLengtBinaryString, 2);

                string serialNumberString = "";

                if (Serialresponse[2] == 1) // means that I got a response on obj, which is refers to the object list.
                {
                    for (var i = 0; i < payloadLength; i++)
                    {
                        serialNumberString += Convert.ToChar(Serialresponse[3 + i]);
                    }
                }

                Console.WriteLine(string.Format("serialNumberString:{0}", serialNumberString));
                form1.serialNumberString = string.Format("Serial number: {0}", serialNumberString);

            }
            
            byte[] comBytesToSend = { 0x7F, 0x00, 0x00, 0x00, 0x80 };
            using (SerialPort port = new SerialPort("Com9", 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(comBytesToSend, 0, comBytesToSend.Length);
                Thread.Sleep(500);
                Serialresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        Serialresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);

                string binary = Convert.ToString(Serialresponse[0], 2);
                string payloadLengtBinaryString = binary.Substring(4);
                int payloadLength = Convert.ToInt32(payloadLengtBinaryString, 2);

                string articleNumberString = "";

                if (Serialresponse[2] == 1) // means that I got a response on obj, which is refers to the object list.
                {
                    for (var i = 0; i < payloadLength; i++)
                    {
                        articleNumberString += Convert.ToChar(Serialresponse[3 + i]);
                    }
                }

                Console.WriteLine(string.Format("Article number:{0}", articleNumberString));
                form1.articleNumber = string.Format("Article number: {0}", articleNumberString);

            }
            */
            // Show the form
            Application.Run(form1);
        }

    }
}
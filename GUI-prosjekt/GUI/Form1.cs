using PS2000GUI;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Text;

namespace GUI
{


    public partial class Form1 : Form
    {
        /*
        private Class1 class1 = new Class1();
           
        public string voltage { get; set; }
        public string remoteControl { get; set; }
        public string serialNumberString { get; set; }
        public string articleNumber { get; set; }

        private string comport = "";
        */

        MqttClient m_Client;
        string clientID;
        string m_PSUID;
        string SNR;

        private IPSU psuInstance;
        public Form1()
        {
            InitializeComponent();
            psuInstance = PSUFactory.CreatePSU();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //display();
            psuInstance.comport = txtBoxComport.Text;

            // Get and display the current voltage
            txtBox_GetVolt.Text = psuInstance.GetVoltage().ToString();

            txtBox_SerialNumber.Text = psuInstance.GetSerialNumber();

            txtBox_Current.Text = psuInstance.GetCurrent().ToString();

            //Get and display the updated voltage
            // txtBox_SetVolt.Text = psuInstance.GetVoltage().ToString();

        }




        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = txtConnectionString.Text;
            m_Client = new MqttClient(connectionString);
            clientID = Guid.NewGuid().ToString();

            m_Client.MqttMsgPublishReceived += M_Client_MqttMsgPublishReceived;

            m_Client.Connect(clientID);

        }

        private void M_Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string receivedMsg = e.Topic.ToString();
            this.Invoke((MethodInvoker)delegate () { SetText(receivedMsg); });


        }


        private void SetText(string text)
        {
            this.txtSubscription.Text = text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_Client != null)
            {
                m_Client.Disconnect();
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (m_Client != null)
            {
                if (txtSubscibe.Text != "")
                {
                    // Subscribe to the GetVoltage topic
                    m_PSUID = txtSubscibe.Text;
                    SNR = psuInstance.GetSerialNumber();
                    string getVoltagetopic = string.Format("/PSU/PSU2000/{0}/{1}/#", SNR, m_PSUID);
                    m_Client.Subscribe(new string[] { getVoltagetopic }, new byte[] { 2 });
                }
            }

        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string txtPubTextValue = txtPubText.Text.Trim().ToLower();
            double voltageValue = psuInstance.GetVoltage();

            if (txtPubTextValue == "setvoltage")
            {
                // Assuming txtBox_SetVolt contains the new voltage value
                if (float.TryParse(txtBox_SetVolt.Text, out float newVoltage))
                {
                    psuInstance.SetVoltage(newVoltage);

                    // Now publish the "setvoltage" message
                    string setVoltageTopic = String.Format("/PSU/PSU2000/{0}/{1}/{2}/{3}", SNR, m_PSUID, txtPubText.Text, newVoltage);
                    m_Client.Publish(setVoltageTopic, Encoding.UTF8.GetBytes(setVoltageTopic), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);

                    txtBox_GetVolt.Text = newVoltage.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number for SetVoltage.");
                }
            }
            else if (txtPubTextValue == "getvoltage")
            {
                // Assuming you are subscribed to "/PSU/PSU2000/{SNR}/{m_PSUID}/GetVoltage"

                string topic = String.Format("/PSU/PSU2000/{0}/{1}/{2}/{3}", SNR, m_PSUID, txtPubText.Text, voltageValue);
                m_Client.Publish(topic, Encoding.UTF8.GetBytes(topic), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
            else
            {
                MessageBox.Show("Invalid command. Please enter 'SetVoltage' or 'GetVoltage' in txtPubText.");
            }
        }

        private void btn_Remote_Click(object sender, EventArgs e)
        {
            psuInstance.GetRemote();
        }
    }
}

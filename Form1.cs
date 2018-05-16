using SerialPortListener.Serial;
using System.IO.Ports;
using System.Linq;


namespace serialcom
{

    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        SerialPortManager _spManager;


#if Defined
#else
        int count;
        bool Defined = true;
#endif

       // int count = 0;


        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            UserInitialization();

        }
        string lat;
        string lon;

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            cmbSerialPorts.DataSource = mySerialSettings.PortNameCollection;
            baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }


        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e )
        {
            int flag=0;

            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

          
            string str1 = Encoding.ASCII.GetString(e.Data);
            RXWINDOW.AppendText(str1);
            RXWINDOW.ScrollToCaret();

          

            if (RXWINDOW.Text.Contains(','))
                RXWINDOW.Clear();
        
         
            if (RXWINDOW.Text.Contains('p'))
            {  
                
                flag = 1;
                
            }
            else if (RXWINDOW.Text.Contains ('t'))
            {

               

                flag = 2;
                

            }
            else if (RXWINDOW.Text.Contains('e'))
            {
              

                flag = 3;

            }
            else if (RXWINDOW.Text.Contains('h'))
            {
              
                flag = 4;

            }
            else if (RXWINDOW.Text.Contains('a'))
            {
                
                flag = 5;

            }
            else if (RXWINDOW.Text.Contains('o'))
            {
              
                flag = 6;

            }

            else if (RXWINDOW.Text.Contains('B'))
            {

                flag = 7;

            }
            else if (RXWINDOW.Text.Contains('Y'))
            {

                flag = 8;

            }
            else if (RXWINDOW.Text.Contains('R'))
            {

                flag = 9;

            }

            if (Defined ==false)
            { MessageBox.Show("error"); }

          //  int count = 0;

            CheckSerial(sender,e,flag);
              
        }

        void Form1_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            cmbSerialPorts.DataSource = ports;
           // int count = 0;

        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (cmbSerialPorts.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("You selected port '{0}'", cmbSerialPorts.SelectedItem));
                //CONNECT_Click(cmbSerialPorts.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
        }


        private void CONNECT_Click(object sender, EventArgs e)
        {
              _spManager.StartListening();
        }

        private void DISCONNECT_Click(object sender, EventArgs e)
        {
            _spManager.StopListening();
        }

       

     void CheckSerial(object sender , SerialDataEventArgs e , int flag)
    {

       switch (flag)
       {
           case 1:
               {


                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "p")
                   {
                       PressureBox.AppendText("\n"+d+"-->");
                   }
                   PressureBox.AppendText(str);
                   PressureBox.ScrollToCaret();
                   
                   lon = longitude.Text;
                   if (lon.StartsWith("o"))
                   {
                       lon = lon.Substring(1);
                   }
                   ///////////////////////////////////////////////////////////////////////
                   double lat_temp;
                   double lat_deg;
                   double lat_m;
                   double lat_final;
                   double lon_temp;
                   double lon_deg;
                   double lon_m;
                   double lon_final;
                   if (str == "p")
                   {
                       webBrowser1.Refresh();
                   }

                       if (lat == string.Empty || lon == string.Empty)
                       {
                           lat = "a3112.631494";

                           if (lat.StartsWith("a"))
                           {
                               lat = lat.Substring(1);
                           }
                           lon = "o2954.511475";
                           if (lon.StartsWith("o"))
                           {
                               lon = lon.Substring(1);
                           }
                       }

                       lat_temp = Convert.ToDouble(lat);
                       lat_deg = lat_temp / 100;
                       lat_m = lat_temp % 100;////miniuts double
                       lat_deg = Math.Floor(lat_deg);
                       //int lat_d = Convert.ToInt16(lat_deg);////degrees integer
                       // lat_deg = Convert.ToDouble(lat_d);///Degrees double
                       lat_m = lat_m / 60;
                       lat_final = lat_m + lat_deg;
                       lat = Convert.ToString(lat_final);
                       /////////////////////////////////////////////////


                       lon_temp = Convert.ToDouble(lon);
                       lon_deg = lon_temp / 100;
                       lon_m = lon_temp % 100;////miniuts double
                       // int lon_d = Convert.ToInt16(lon_deg);////degrees integer
                       // lon_deg = Convert.ToDouble(lon_d);///Degrees double
                       lon_deg = Math.Floor(lon_deg);
                       lon_m = lon_m / 60;
                       lon_final = lon_m + lon_deg;
                       lon = Convert.ToString(lon_final);


                       StringBuilder queryAddress = new StringBuilder();
                       queryAddress.Append("http://www.bing.com/maps/?v=2&cp=");

                       if (lat != string.Empty)
                       {
                           queryAddress.Append(lat + "~");
                       }

                       if (lon != string.Empty)
                       {
                           queryAddress.Append(lon + "&lvl=18&style=a&dir=180&sp=point." + lat + "_" + lon + "_Cansat%203");

                       }
                       if (str == "p" )
                       {
                           
                           webBrowser1.Navigate(queryAddress.ToString());
                       }
                       
                       //////////////////////////////////////////////////////////////////////
                       break;

                   
               }
           case 2:
            {
                string str = Encoding.ASCII.GetString(e.Data);
                string d;
                d = DateTime.Now.ToString("h:mm:ss tt");
                if (str == "t")
                {
                    TempBox.AppendText("\n");
                    TempBox.AppendText( d+"-->");
                }
                TempBox.AppendText(str);
                TempBox.ScrollToCaret();
                

                break;
            }
           case 3:
            {

               
                string str = Encoding.ASCII.GetString(e.Data);
                string d;
                d = DateTime.Now.ToString("h:mm:ss tt");
                if (str == "e")
                {
                    ELEVATION.AppendText("\n");
                    ELEVATION.AppendText(d+"-->");
                }
                ELEVATION.AppendText(str);
                ELEVATION.ScrollToCaret();
                break;
            }
           
           case 4:
            {
                latitude.Clear();
                string str = Encoding.ASCII.GetString(e.Data);
                string d;
                d = DateTime.Now.ToString("h:mm:ss tt");
                if (str == "h")
                {
                    HumidityBox.AppendText("\n");
                    HumidityBox.AppendText(d+"-->");
                }
                HumidityBox.AppendText(str);
                HumidityBox.ScrollToCaret();
                break;
            }

           case 5:
            {
                longitude.Clear();
                string str = Encoding.ASCII.GetString(e.Data);
                latitude.AppendText(str);
                latitude.ScrollToCaret();
                
                break;
            }

           case 6:
               {
                string str = Encoding.ASCII.GetString(e.Data);
                longitude.AppendText(str);
                longitude.ScrollToCaret();
         
                lat = latitude.Text;
                if (lat.StartsWith("a"))
                {
                    lat = lat.Substring(1);
                } 
                
                break;
            }
           case 7:
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "B")
                   {
                       Bitch.AppendText("\n");
                       Bitch.AppendText(d + "-->");
                   }
                   Bitch.AppendText(str);
                   Bitch.ScrollToCaret();
                   break;
               }
           case 8:
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "Y")
                   {
                       YAW.AppendText("\n");
                       YAW.AppendText(d + "-->");
                   }
                   YAW.AppendText(str);
                   YAW.ScrollToCaret();
                   break;
               }
           case 9:
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "R")
                   {
                       Roll.AppendText("\n");
                       Roll.AppendText(d + "-->");
                   }
                   Roll.AppendText(str);
                   Roll.ScrollToCaret();
                   break;
               }
    }
     }

     private void webBrowser1_load()
     {
         throw new NotImplementedException();
     }

      public void webBrowser1_Load(object sender, EventArgs e)
            {
                ///latitude.Text = "3112.529785";
                //longitude.Text = "2954.508301";
               
                
               /*     webBrowser1.Refresh();
                
            string lat = latitude.Text;
            
            if (lat.StartsWith("a"))
            {
                lat = lat.Substring(1);
            } 

              string lon = longitude.Text;

            if (lon.StartsWith("o"))
            {
                lon = lon.Substring(1);
            }
          
                if (lat == string.Empty || lon == string.Empty)
                {
                     lat = "a3112.631494";

                    if (lat.StartsWith("a"))
                    {
                        lat = lat.Substring(1);
                    }
                    lon = "o2954.511475";
                    if (lon.StartsWith("o"))
                    {
                        lon = lon.Substring(1);
                    }
                }

            double lat_temp;
            double lat_deg;
            double lat_m;
            double lat_final;
            double lon_temp;
            double lon_deg;
            double lon_m;
            double lon_final;

            


            lat_temp = Convert.ToDouble(lat);
            lat_deg = lat_temp / 100;
            lat_m = lat_temp % 100;////miniuts double
            lat_deg = Math.Floor(lat_deg);
            //int lat_d = Convert.ToInt16(lat_deg);////degrees integer
           // lat_deg = Convert.ToDouble(lat_d);///Degrees double
            lat_m = lat_m / 60;
            lat_final = lat_m + lat_deg;
            lat = Convert.ToString(lat_final);
            /////////////////////////////////////////////////


            lon_temp = Convert.ToDouble(lon);
            lon_deg = lon_temp / 100;
            lon_m = lon_temp % 100;////miniuts double
           // int lon_d = Convert.ToInt16(lon_deg);////degrees integer
           // lon_deg = Convert.ToDouble(lon_d);///Degrees double
            lon_deg = Math.Floor(lon_deg);
            lon_m = lon_m / 60;
            lon_final = lon_m + lon_deg;
            lon = Convert.ToString(lon_final);
          */

             if (lat == string.Empty || lon == string.Empty)
            {
                this.Dispose();
            }
             //http://www.bing.com/maps/?v=2&cp=31.208824235~29.9084759&lvl=20&style=a&dir=180
                  
           
                try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://www.bing.com/maps/?v=2&cp=");
 
                if (lat != string.Empty)
                {
                    queryAddress.Append(lat + "~");
                }
 
                if (lon != string.Empty)
                {
                    queryAddress.Append(lon + "&lvl=18&style=a&dir=180&sp=point." + lat + "_" + lon + "_Cansat%203");
                  
                }
                webBrowser1.Navigate(queryAddress.ToString());
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Set text while the page has not yet loaded.
            this.Text = "Navigating";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = "Can-sat location on map";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _spManager.Senda(); //UP
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _spManager.Sendb(); //LEFT
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _spManager.Sendc(); //RIGHT
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _spManager.Sendd(); //DOWN
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            _spManager.Sende(); //DOWN
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _spManager.Sendf(); //DOWN
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _spManager.Sendg(); //DOWN
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _spManager.Sendh(); //DOWN
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _spManager.Sendi(); //DOWN
        }
     }

  



    
    
  
    
}
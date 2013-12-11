//******************************************************************************************************************************
//Name: Shihuan Shao
//ASUID: 1203060451
//Assignment 1, Section 3, Question 4
//Service name: CDYNE Weather - FREE (Web service)
//WSDL Address:	http://ws.cdyne.com/WeatherWS/Weather.asmx?wsdl
//Description: A Windows Forms  Application for CDYNE Weather that allows you to get the seven day forecast of by zipcode of United States.
//How to use: input a five-digit ZIP code, then click the Get Forecast! button or press Enter, you will get the weather information of the 
//corresponding region, including  a general description, probability of precipiation, and lowest and highest temperature. 
//******************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1_4.com.cdyne.wsf;
using System.Net;
using System.IO;

namespace _1_4
{
    public partial class MyWeatherStation : Form
    {      
        GroupBox[] groupBoxes;
        PictureBox[] pictureBoxes;
        Label[] descriptions;
        Label[] rains;
        Label[] lowTemps;
        Label[] highTemps;
        Forecast[] forecasts;   //Used to store weather forecast information
        Weather weather;            
        WeatherDescription[] weatherDescriptions;   //Used to find weather description picture via corresponding WeatherID
        Bitmap pic;
        
        public MyWeatherStation()   //Initialize the components and create arrays to make calling convenient
        {
            InitializeComponent();  
            groupBoxes = new GroupBox[7] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7 };
            descriptions = new Label[7] { description1, description2, description3, description4, description5, description6, description7 };
            rains = new Label[7] { rain1, rain2, rain3, rain4, rain5, rain6, rain7 };
            lowTemps = new Label[7] { lowTemp1, lowTemp2, lowTemp3, lowTemp4, lowTemp5, lowTemp6, lowTemp7 };
            highTemps = new Label[7] { highTemp1, highTemp2, highTemp3, highTemp4, highTemp5, highTemp6, highTemp7 };
            pictureBoxes = new PictureBox[7] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            forecasts = new Forecast[7];
            weather = new Weather();
            weatherDescriptions = weather.GetWeatherInformation();   // GetWeatherInformation() returns a WeatherDescription array which contains     
        }                                                                                                                             // all of the WeatherID and corresponding description and picture URL

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && weather.GetCityForecastByZIP(textBox1.Text).Success == true)
            {
                forecasts = weather.GetCityForecastByZIP(textBox1.Text).ForecastResult;
                label2.Text = weather.GetCityForecastByZIP(textBox1.Text).City + ", " + weather.GetCityForecastByZIP(textBox1.Text).State;
                for (int i = 0; i < 7; i++)
                {
                    groupBoxes[i].Text = forecasts[i].Date.ToString().Substring(0, 9);
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    for (int j = 0; j < weatherDescriptions.Length; j++) {
                        if (forecasts[i].WeatherID < 0 || forecasts[i].WeatherID >= weatherDescriptions.Length) {   //Sometimes the service returns WeatheID < 0 
                            pic = LoadPicture(weatherDescriptions[12].PictureURL);                                                                 //which is not defined
                            pictureBoxes[i].Image = (Image)pic;
                            break;
                        }
                        if (forecasts[i].WeatherID == weatherDescriptions[j].WeatherID) { //Find out the weather description picture with the WeatherID
                            pic = LoadPicture(weatherDescriptions[j].PictureURL);                            
                            pictureBoxes[i].Image = (Image)pic;
                            break;
                        }
                    }

                    if (forecasts[i].WeatherID < 0 || forecasts[i].WeatherID >= weatherDescriptions.Length)
                        descriptions[i].Text = "Unknown";
                    else
                        descriptions[i].Text = forecasts[i].Desciption;
                    if (forecasts[i].ProbabilityOfPrecipiation.Daytime == "00")
                        forecasts[i].ProbabilityOfPrecipiation.Daytime = "0";
                    if (forecasts[i].ProbabilityOfPrecipiation.Nighttime == "00")
                        forecasts[i].ProbabilityOfPrecipiation.Nighttime = "0";
                    rains[i].Text = "D " + forecasts[i].ProbabilityOfPrecipiation.Daytime + "% N " + forecasts[i].ProbabilityOfPrecipiation.Nighttime + "%";
                    lowTemps[i].Text = forecasts[i].Temperatures.MorningLow;
                    highTemps[i].Text = forecasts[i].Temperatures.DaytimeHigh;
                }
            }
            else if (textBox1.Text.Trim() != "" && weather.GetCityForecastByZIP(textBox1.Text).Success == false) {
                MessageBox.Show("Weather forecast is not available or invalid ZIP code!");  //In case weather informaion is unavailable or a wrong ZIP code is entered
            }
            else
            {
                MessageBox.Show("Please enter the ZIP code!");  //The ZIP code textbox should not be empty when pressing the button
            }
        }
        private Bitmap LoadPicture(string url)  //A function used to return the weather description image via the image url
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;          
            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();
                if ((mystream = wresp.GetResponseStream()) != null)
                {
                    bmp = new Bitmap(mystream);
                }
            }
            finally
            {
                if (mystream != null) mystream.Close();
                if (wresp != null) wresp.Close();
            }
            return (bmp);
        }
        private void MyWeatherStation_Load(object sender, EventArgs e) { }
    }
}

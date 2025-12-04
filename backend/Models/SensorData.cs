using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SensorData
    {
        float temperature;
        float humidity;
        int lightIntensity;

        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public float Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        public int LightIntensity
        {
            get { return lightIntensity; }
            set { lightIntensity = value; }
        }

        public SensorData()
        {
        }

        public SensorData(float temperature, float humidity, int lightIntensity)
        {
            Temperature = temperature;
            Humidity = humidity;
            LightIntensity = lightIntensity;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace INTOC
{
    public static class GPS
    {
        public static string PositionToString(float[] position)
        {
            if (position.Length == 2)
            {
                string lat = position[0].ToString(System.Globalization.CultureInfo.InvariantCulture);
                string lon = position[1].ToString(System.Globalization.CultureInfo.InvariantCulture);

                return lat + "," + lon;
            }
            else if (position.Length == 3)
            {
                string lat = position[0].ToString(System.Globalization.CultureInfo.InvariantCulture);
                string lon = position[1].ToString(System.Globalization.CultureInfo.InvariantCulture);
                string alt = position[2].ToString(System.Globalization.CultureInfo.InvariantCulture);

                return lat + "," + lon + "," + alt;
            }

            return "UNDEFINED";
        }

        public static string PositionToLatLonString(float[] position)
        {
            string lat = position[0].ToString(System.Globalization.CultureInfo.InvariantCulture);
            string lon = position[1].ToString(System.Globalization.CultureInfo.InvariantCulture);

            return lat + "," + lon;
        }

        public static string PositionToStringVerbose(float[] position)
        {
            string txt = "";
            if (position.Length == 2)
            {        
                string lat = position[0].ToString(System.Globalization.CultureInfo.InvariantCulture);
                txt += "Latitude: " + lat + "\n";
                string lon = position[1].ToString(System.Globalization.CultureInfo.InvariantCulture);
                txt += "Longitude: " + lon;

                return txt;
            }
            else if (position.Length == 3)
            {
                string lat = position[0].ToString(System.Globalization.CultureInfo.InvariantCulture);
                txt += "Latitude: " + lat + "\n";
                string lon = position[1].ToString(System.Globalization.CultureInfo.InvariantCulture);
                txt += "Longitude: " + lon + "\n";
                string alt = position[2].ToString(System.Globalization.CultureInfo.InvariantCulture);
                txt += "Altitude: " + alt;

                return txt;
            }

            return "UNDEFINED";
        }

        public static float[] StringToPosition(string positionString)
        {
            var splitPosition = positionString.Split(',');
            float[] position;

            if (splitPosition.Length == 2)
            {
                position = new float[]
                {
                    float.Parse(splitPosition[0], System.Globalization.CultureInfo.InvariantCulture),
                    float.Parse(splitPosition[1], System.Globalization.CultureInfo.InvariantCulture)
                };
            }
            else
            {
                position = new float[]
                {
                    float.Parse(splitPosition[0], System.Globalization.CultureInfo.InvariantCulture),
                    float.Parse(splitPosition[1], System.Globalization.CultureInfo.InvariantCulture),
                    float.Parse(splitPosition[2], System.Globalization.CultureInfo.InvariantCulture)
                };
            }

            return position;
        }
    }
}

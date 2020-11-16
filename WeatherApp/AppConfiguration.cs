using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public static class AppConfiguration
    {

        private static IConfiguration configuration;



        public static String GetValue(String key)
        {

            return key;
        }

        private static void initConfig()
        {

        }

    }
}

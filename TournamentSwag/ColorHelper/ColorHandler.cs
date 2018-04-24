using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSwag.ColorHelper
{
    public class ColorHandler
    {
        public ColorTheme colorTheme;

        private static ColorHandler instance;

        private ColorType currentTheme; 


        public enum ColorType
        {
            defaultTheme = 0,
            facebookTheme = 1,
            brightTheme = 2, 
            colorfulTheme = 3

        }



        private ColorHandler()
        {
            colorTheme = new ColorTheme();

            currentTheme = ColorType.defaultTheme;
            SetColorScheme(currentTheme);
            

        }
        public static ColorHandler Instance
        {
            get
            {
                if ( instance == null )
                {
                    instance = new ColorHandler();
                }
                return instance;
            }
        }


        public ColorTheme GetColorTheme()
        {
            return colorTheme;

        }

        public ColorType GetCurrentThemeType()
        {
            return currentTheme;
        }

        public void SetColorScheme(ColorType theme)
        {
            switch (theme)
            {
                case ColorType.defaultTheme:
                    colorTheme.colorOne = Color.FromArgb(194, 172, 97);
                    colorTheme.colorTwo = Color.FromArgb(101, 137, 68);
                    colorTheme.colorThree = Color.FromArgb(200, 82, 82);
                    colorTheme.colorFour = Color.FromArgb(10, 57, 54);
                    colorTheme.colorFive = Color.FromArgb(25, 111, 97);
                    break;
                case ColorType.facebookTheme:
                    colorTheme.colorOne = Color.FromArgb(233, 235, 238);
                    colorTheme.colorTwo = Color.FromArgb(137, 143, 156);
                    colorTheme.colorThree = Color.FromArgb(66, 103, 178);
                    colorTheme.colorFour = Color.FromArgb(54, 88, 153);
                    colorTheme.colorFive = Color.FromArgb(41, 72, 125);
                    break;
                case ColorType.brightTheme:
                    colorTheme.colorOne = Color.FromArgb(203, 246, 255);
                    colorTheme.colorTwo = Color.FromArgb(229, 218, 255);
                    colorTheme.colorThree = Color.FromArgb(255, 218, 218);
                    colorTheme.colorFour = Color.FromArgb(200, 255, 225);
                    colorTheme.colorFive = Color.FromArgb(255,247,212);
                    break;
                case ColorType.colorfulTheme:
                    colorTheme.colorOne = Color.FromArgb(255, 211, 25);
                    colorTheme.colorTwo = Color.FromArgb(255, 144, 31);
                    colorTheme.colorThree = Color.FromArgb(255, 41, 117);
                    colorTheme.colorFour = Color.FromArgb(242, 34, 255);
                    colorTheme.colorFive = Color.FromArgb(140, 30, 255);
                    break;
                default:
                    break;
            }

            currentTheme = theme;
        }




    }
}

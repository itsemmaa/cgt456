﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign04
{
    public partial class Assign04 : System.Web.UI.Page
    {
        bool firstValueChanged; //boolean true/false for bitwise display
        protected void Page_Load(object sender, EventArgs e)
        {
            // page_load runs round trip to the server (postback)
            if (!Page.IsPostBack)
            {
                // initial page load - only runs once at beginning
                // if postback, doesn't execute
                firstValueChanged = false; //no values have been changed
                bit1.Enabled = false; //disable bit1 from use
                bit2.Enabled = false; //disable bit2 from use
                bit3.Enabled = false; //disable bit3 from use
                bitwiseResult.Enabled = false; //disable textbox from use
                bit1.Visible = false; //don't display bit1
                bit2.Visible = false; //don't display bit2
                bit3.Visible = false; //don't display bit3
                bitEqual.Visible = false; //don't display equal sign
                bitwiseResult.Visible = false; //don't display the textbox
            }
        }

        public void ValueChanged(object sender, EventArgs e)
        {
            //declare variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;

            string color = "";

            firstValueChanged = true; //boolean true/false flag usd to show bitwise

            System.Web.UI.WebControls.DropDownList d1;
            d1 = (System.Web.UI.WebControls.DropDownList)sender;

            //check to see if it was a red dropdown that was changed
            if(d1.ID.Contains("red"))
            {
                //it was red, get the data from the red drop downs
                num8 = Convert.ToInt16(red8.SelectedValue);
                num7 = Convert.ToInt16(red7.SelectedValue);
                num6 = Convert.ToInt16(red6.SelectedValue);
                num5 = Convert.ToInt16(red5.SelectedValue);
                num4 = Convert.ToInt16(red4.SelectedValue);
                num3 = Convert.ToInt16(red3.SelectedValue);
                num2 = Convert.ToInt16(red2.SelectedValue);
                num1 = Convert.ToInt16(red1.SelectedValue);

                //set the color to pass it into the next function
                color = "red";
            }

            else if(d1.ID.Contains("blue"))
            {
                //it was blue, get data from blue drop downs
                num8 = Convert.ToInt16(blue8.SelectedValue);
                num7 = Convert.ToInt16(blue7.SelectedValue);
                num6 = Convert.ToInt16(blue6.SelectedValue);
                num5 = Convert.ToInt16(blue5.SelectedValue);
                num4 = Convert.ToInt16(blue4.SelectedValue);
                num3 = Convert.ToInt16(blue3.SelectedValue);
                num2 = Convert.ToInt16(blue2.SelectedValue);
                num1 = Convert.ToInt16(blue1.SelectedValue);

                //set the color to pass it into the next function
                color = "blue";
            }

            else if(d1.ID.Contains("green"))
            {
                //it was green, get the data from the green drop downs
                num8 = Convert.ToInt16(green8.SelectedValue);
                num7 = Convert.ToInt16(green7.SelectedValue);
                num6 = Convert.ToInt16(green6.SelectedValue);
                num5 = Convert.ToInt16(green5.SelectedValue);
                num4 = Convert.ToInt16(green4.SelectedValue);
                num3 = Convert.ToInt16(green3.SelectedValue);
                num2 = Convert.ToInt16(green2.SelectedValue);
                num1 = Convert.ToInt16(green1.SelectedValue);

                //set the color to pass it into the next function
                color = "green";
            }

            //calculate the decimal value
            calculateDecimal(color, num1, num2, num3, num4, num5, num6, num7, num8);

            //change the background color
            changeColor();

            if (firstValueChanged)
            {
                //the first DropDownList was changed, display the bitwise controls
                bit1.Enabled = true;
                bit2.Enabled = true;
                bit3.Enabled = true;
                bit1.Visible = true;
                bit2.Visible = true;
                bit3.Visible = true;
                bitEqual.Visible = true;
                bitwiseResult.Visible = true;
            }

            bitwise(sender, e); //calculate the bitwise value after every change

        } //end ValueChanged function

        //function to calculate the decimal value

        public void calculateDecimal(string color, int b1, int b2, int b3, int b4, int b5, int b6, int b7, int b8)
        {
            //declare variables
            int total;

            //figure out decimal values of each binary number
            b1 = b1 * 1;
            b2 = b2 * 2;
            b3 = b3 * 4;
            b4 = b4 * 8;
            b5 = b5 * 16;
            b6 = b6 * 32;
            b7 = b7 * 64;
            b8 = b8 * 128;

            //figure out final decimal number
            total = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8;

            //send total to calculateHex function
            if (color == "red")
                rHexText.Text = CalculateHex(total);
            else if (color == "blue")
                bHexText.Text = CalculateHex(total);
            else if (color == "green")
                gHexText.Text = CalculateHex(total);

            //print total to the box
            if (color == "red")
                rDecText.Text = total.ToString();
            else if (color == "blue")
                bDecText.Text = total.ToString();
            else if (color == "green")
                gDecText.Text = total.ToString();

        } //end calculateDecimal

        public string getHexFromNum(int num)
        {
            string hexNum = "";

            if (num <= 9)
                hexNum = num.ToString();

            if (num > 9)
            {
                if (num == 10)
                    hexNum = "A";
                if (num == 11)
                    hexNum = "B";
                if (num == 12)
                    hexNum = "C";
                if (num == 13)
                    hexNum = "D";
                if (num == 14)
                    hexNum = "E";
                if (num == 15)
                    hexNum = "F";
            }

            return hexNum;

        } //end getHexFromNum

        public string CalculateHex(int a)
        {
            //declare variables
            int num1 = 0;
            int num2 = 0;
            string firstnum = "";
            string secondnum = "";

            //calculate the hex number (1-16)
            num1 = (a / 16) % 16;
            num2 = a % 16;

            //calculate the web code form (with letters)
            firstnum = getHexFromNum(num1);
            secondnum = getHexFromNum(num2);

            //return value
            return firstnum + secondnum;

        } //end CalculateHex

        public void changeColor()
        {
            string rcolor = "";
            string bcolor = "";
            string gcolor = "";

            //set the colors to zero if not entered
            //red
            if (rHexText.Text.Equals(""))
                rcolor = "00";
            else
                rcolor = rHexText.Text.ToString();

            //green
            if (gHexText.Text.Equals(""))
                gcolor = "00";
            else
                gcolor = gHexText.Text.ToString();

            //blue
            if (bHexText.Text.Equals(""))
                bcolor = "00";
            else
                bcolor = bHexText.Text.ToString();

            //change the box color
            bgColor.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + rcolor + gcolor + bcolor);

        } //end changeColor


        //the bitwise functions
        public void bitwise(object sender, EventArgs e)
        {
            //only calculate the bitwise value if the user has chosen operands and an operator
            if (!bit1.SelectedValue.Equals("--") && !bit2.SelectedValue.Equals("--") && !bit3.SelectedValue.Equals("--"))
            {
                int num1 = 0;
                int num2 = 0;
                int result = 0;

                //to find the value of the first number
                if (bit1.SelectedValue.Equals("R"))
                    num1 = Convert.ToByte(rDecText.Text);

                if (bit1.SelectedValue.Equals("G"))
                    num1 = Convert.ToByte(gDecText.Text);

                if (bit1.SelectedValue.Equals("B"))
                    num1 = Convert.ToByte(bDecText.Text);

                //to find the value of the second number
                if (bit3.SelectedValue.Equals("R"))
                    num1 = Convert.ToByte(rDecText.Text);

                if (bit3.SelectedValue.Equals("G"))
                    num1 = Convert.ToByte(gDecText.Text);

                if (bit3.SelectedValue.Equals("B"))
                    num1 = Convert.ToByte(bDecText.Text);

                //do the calculations
                if (bit2.SelectedValue.Equals("&"))
                    num1 = Convert.ToByte(rDecText.Text);

                if (bit2.SelectedValue.Equals("|"))
                    num1 = Convert.ToByte(rDecText.Text);

                if (bit2.SelectedValue.Equals("^"))
                    num1 = Convert.ToByte(rDecText.Text);

                string inBinary;
                int binNum = result;

                // 128
                if (binNum >= 128)
                {
                    inBinary = "1";
                    binNum = binNum - 128;
                }
                else
                {
                    inBinary = "0";
                }

                // 64
                if (binNum >= 64)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 64;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                // 32
                if (binNum <= 32)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 32;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                // 16
                if (binNum <= 16)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 16;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                // 8
                if (binNum <= 8)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 8;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                // 4
                if (binNum <= 4)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 4;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                // 2
                if (binNum <= 2)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 2;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                // 1
                if (binNum <= 1)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 1;
                }
                else
                {
                    inBinary = inBinary + "0";
                }

                //return inBinary;
                bitwiseResult.Text = inBinary.ToString();
            }
        } // end bitwise
    }
}

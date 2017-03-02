using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ColorMatch
{
    public partial class ColorMatch : Form
    {
        public ColorMatch()
        {
            InitializeComponent();
        }

        #region Variables

        //Boolean
        bool captureColor = false;

        //Color Properties and Variables
        System.Windows.Media.Color myColor;
        System.Drawing.Color customColor;
        public static System.Drawing.Color capturedColor { get; set; }

        #endregion

        #region Methods

        public void OnLoad()
        {
            //UI
            this.Text = this.Text + Application.ProductVersion;
            listColors.Columns[0].Width = 220;
            listColors.Columns[1].Width = 199;
            listColors.Sorting = SortOrder.Ascending;

            //Data
            GetColors();
        }

        public static Dictionary<string, object> GetStaticPropertyBag(Type t)
        {
            //Create a constant that contains the flags for the property iteration
            const BindingFlags bindFlags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

            //Create a Dictionary object to store our color name and hex value
            var colorDictionary = new Dictionary<string, object>();
            foreach (var colorProperty in t.GetProperties(bindFlags))
            {
                colorDictionary[colorProperty.Name] = colorProperty.GetValue(null, null);
            }
            return colorDictionary;
        }

        public void GetColors()
        {
            //Get the colors listed in our property
            var colors = GetStaticPropertyBag(typeof(Colors));

            //Loop through the Dictionary and populate the list of default colors
            foreach (KeyValuePair<string, object> colorPair in colors)
            {
                //Create a string to hold our hex values
                string defaultColorHex = colorPair.Value.ToString();

                //Remove the '#FF' for more uniform conversion
                defaultColorHex = defaultColorHex.Remove(0, 3);

                ListViewItem item = new ListViewItem(colorPair.Key);
                item.SubItems.Add("#" + defaultColorHex);

                listColors.Items.Add(item);
            }
        }

        public void DisplayColor(string r, string g, string b, string hex)
        {
            //Set the text fields to the parameters passed into the DisplayColor method
            txtRed.Text = r;
            txtGreen.Text = g;
            txtBlue.Text = b;
            txtHex.Text = hex;
        }

        public string RGBToHex(int r, int g, int b)
        {
            //Creeate the temporary color to get our hex value from RGB
            System.Drawing.Color tempColor = System.Drawing.Color.FromArgb(r, g, b);
            string hexValue = tempColor.R.ToString("X2") + tempColor.G.ToString("X2") + tempColor.B.ToString("X2");

            return "#" + hexValue;
        }

        public static System.Drawing.Color GetPixel(Point position)
        {
            //Create a new 1x1 bitmap object to capture the color from
            using (var pixelBitmap = new Bitmap(1, 1))
            {
                //Create a graphics object from the bitmap at the cursor position
                using (var pixelGraphics = Graphics.FromImage(pixelBitmap))
                {
                    pixelGraphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }

                //Create a new color object for display
                capturedColor = pixelBitmap.GetPixel(0, 0);
                return pixelBitmap.GetPixel(0, 0);
            }
        }

        #endregion

        #region Event Handlers

        private void ColorMatch_Load(object sender, EventArgs e)
        {
            //Call the OnLoad method
            OnLoad();
        }

        private void listColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listColors.SelectedItems.Count > 0)
            {
                //Get the hex value of the default color
                string rawHex = listColors.SelectedItems[0].SubItems[1].Text;

                //Convert the hex value into a color object, then convert to Drawing object to apply the preview
                myColor = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(rawHex);
                var drawingColor = System.Drawing.Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B);

                //Add the RGB values and hex value into the text fields
                DisplayColor(myColor.R.ToString(), myColor.G.ToString(), myColor.B.ToString(), rawHex);

                //Show the preview of the color
                pnlPreview.BackColor = drawingColor;

            }
            else
            {
                return;
            }
        }

        private void btnCopyRGB_Click(object sender, EventArgs e)
        {
            if(txtRed.TextLength > 1)
            {
                //Copy the RGB value to the clipboard and then show a confirmation messages to the user
                Clipboard.SetText("(" + txtRed.Text + ", " + txtGreen.Text + ", " + txtBlue.Text + ")");
                MessageBox.Show("The RGB value of the color has been copied to your clipboard!\n\nRGB Value - (" + txtRed.Text + ", " + txtGreen.Text + ", " + txtBlue.Text + ")", Application.ProductName + " - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopyHex_Click(object sender, EventArgs e)
        {
            if(txtHex.TextLength > 1)
            {
                //Copy the hex value to the clipboard and then show a confirmation messages to the user
                Clipboard.SetText(txtHex.Text);
                MessageBox.Show("The hex value of the color has been copied to your clipboard!\n\nHex Value - " + txtHex.Text, Application.ProductName + " - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            //Change the cursor to show the end user that color capture is active
            this.Cursor = Cursors.Hand;

            //Set the boolean to true so the next click will invoke the GetPixelColor method
            captureColor = true;
        }

        private void ColorMatch_MouseUp(object sender, MouseEventArgs e)
        {
            //Call the GetPixelColor method
            if (captureColor == true)
            {
                //Get the color of the pixel that was clicked (Console for debug)
                Console.WriteLine(GetPixel(Cursor.Position));

                //Set the color capture back to inactive to prevent the method from continuously invoking
                captureColor = false;
                this.Cursor = Cursors.Default;

                //Show the RGB values of the captured color
                DisplayColor(capturedColor.R.ToString(), capturedColor.G.ToString(), capturedColor.B.ToString(), RGBToHex(capturedColor.R, capturedColor.G, capturedColor.B));

                //Show the preview of the captured color
                pnlPreview.BackColor = capturedColor;
            }
        }

        private void copyRGBValueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (txtRed.TextLength > 1)
            {
                //Copy the RGB value to the clipboard and then show a confirmation messages to the user
                Clipboard.SetText("(" + txtRed.Text + ", " + txtGreen.Text + ", " + txtBlue.Text + ")");
                MessageBox.Show("The RGB value of the color has been copied to your clipboard!\n\nRGB Value - (" + txtRed.Text + ", " + txtGreen.Text + ", " + txtBlue.Text + ")", Application.ProductName + " - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void copyHexValueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (txtHex.TextLength > 1)
            {
                //Copy the hex value to the clipboard and then show a confirmation messages to the user
                Clipboard.SetText(txtHex.Text);
                MessageBox.Show("The hex value of the color has been copied to your clipboard!\n\nHex Value - " + txtHex.Text, Application.ProductName + " - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        private void aboutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Show the about message to the end user 
            MessageBox.Show(Application.ProductName + "\nCreated by Chris Harris, Chris Harris Freeware\n\nBuild Version - " + Application.ProductVersion, Application.ProductName + " - About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Capture the custom color and convert it into a Drawing Color Object
                customColor = colorDialog.Color;

                //Call the DisplayColor method passing in our RGB and Hex values
                DisplayColor(customColor.R.ToString(), customColor.G.ToString(), customColor.B.ToString(), RGBToHex(customColor.R, customColor.G, customColor.B));

                //Show the preview of the custom color
                pnlPreview.BackColor = customColor;
            }
        }

        #endregion
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace GPL_APP
{   
    /// <summary>
    /// Contains objects of all the components of the form
    /// </summary>
    public partial class GplApplication : Form
    {
        private delegate void UpdateUiDelegate();
        //bitmap to draw on which will be displayed in the picturebox
        readonly Bitmap OutputBitmap = new Bitmap(1000, 1000);
        /// <summary>
        /// Temp screen for drawing cursor.
        /// </summary>
        readonly Bitmap temp_screen = new Bitmap(1000, 1000);
        //Canvas for storing colour fills and cordinates.
        readonly Canvas canvass;
        /// <summary>
        /// Parses the command provided.
        /// </summary>
        readonly Parse parser;
        /// <summary>
        /// Stores content of the file loaded.
        /// </summary>
        ArrayList filecontent;




        /// <summary>
        /// Constructor to initialize the form.
        /// </summary>
        public GplApplication()
        {
            
            InitializeComponent();
            canvass = new Canvas(Graphics.FromImage(OutputBitmap), displayWindow);
            parser = new Parse(canvass);//class for handling the drawing, pass the drawing surface to it
            canvass.DrawCursor(Graphics.FromImage(temp_screen));
            canvass.SetRunBtn(btn_run);
            canvass.SetTextBox(console);
        }


        /// <summary>
        /// Event to handle line witten in the cmdLine textbox.
        /// </summary>
        /// <param name="sender">Reference to the object that send the event.</param>
        /// <param name="e">Event data from the event. </param>
        private void cmdLine_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && !cmdLine.Text.Equals(""))
            {
                console.Text = "";
                error_label.Text = "";
                try
                {
                    parser.DrawFromLine(cmdLine.Text, 0); //checks for run command to compile text command

                    if (canvass.run)
                    {
                        btn_run.PerformClick();
                        canvass.run = false;
                    }
                }
                catch(InvalidCommandException a)
                {
                    parser.errors.Add("The command given is invalid. \r\n");
                    Console.WriteLine(a);
                }
                catch(InvalidParameterException a)
                {

                    parser.errors.Add("The parameter given for the command is invalid. \r\n");
                    Console.WriteLine(a);

                }

                if (parser.errors.Count != 0)
                {
                    foreach (var item in parser.errors)
                        console.Text += item.ToString();
                }
                Refresh();  //signify that displayneeds updating

                parser.ClearErrors();
            }
        }

        /// <summary>
        /// Compiles the text in Multiline command textbox
        /// </summary>
        /// <param name="sender">Reference to the object that send the event.</param>
        /// <param name="e">Event data from the event. </param>
        private void textCompile(object sender, EventArgs e)
        {
            Console.WriteLine("****Inside TextCompile*****");
            console.Text = "";
            error_label.Text = "";
            string cmd = cmdText.Text;
            //sends to parser which again sends to syntaxparser
            parser.DrawFromText(cmd);

            Console.WriteLine("*****Text Compiles Ends here*****");
        }




        /// <summary>
        /// Paint event for rendering shapes in the displayWindow Bitmap.
        /// </summary>
        /// <param name="sender">Reference to the object that send the event.</param>
        /// <param name="e">Event data from the event. </param>
        private void displayWindow_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("****Inside DIsplay Window Paint!!*****");
            Graphics g = e.Graphics; //get graphics context of form (which is being displayed)


            //update the cursor position
            canvass.DrawCursor(Graphics.FromImage(temp_screen));


            if (canvass.fill) fillcolor_label.Text = "Fill : ON  Color : " + canvass.colour.Name;
            else fillcolor_label.Text = "Fill : OFF  Color : " + canvass.colour.Name;

            //if syntaxcheck is on draw nothing
            if(!parser.checksyntax)
            {
                g.DrawImageUnscaled(OutputBitmap, 0, 0);//put the off screen bitmap on the form
                g.DrawImageUnscaled(temp_screen, 0, 0);
                temp_screen.MakeTransparent();
            }

            //display error count in error count label
            if (parser.getErrorCount() != 0) error_label.Text = "Error Found: " + parser.getErrorCount();
            

        }



        /// <summary>
        /// Event for handling click in the load submenu item. 
        /// </summary>
        /// <param name="sender">Reference to the object that send the event.</param>
        /// <param name="e">Event data from the event. </param>
        private void loadFile_Click(object sender, EventArgs e)
        {

            cmdText.Text = "";
            filecontent = new FileLoadAndWrite().LoadFile();

            //parser.ColorTextInTextbox(cmdText, filecontent);

            foreach(string s in filecontent) {
                cmdText.Text += s + "\n"; //print text in cmdText textbox
            }



        }


        /// <summary>
        /// Handles event for click in clear submenu item.
        /// </summary>
        /// <param name="sender">Reference to the object that send the event.</param>
        /// <param name="e">Event data from the event. </param>
        private void MenuClearClick(object sender, EventArgs e)
        {
            canvass.Clear();
            Refresh();
        }

        /// <summary>
        /// Handles event for click in reset submenu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuResetClick(object sender, EventArgs e)
        {
            canvass.Reset();
            Refresh();
        }

        /// <summary>
        /// Event handling for click in the save submenu item.
        /// </summary>
        /// <param name="sender">Reference to the object that send the event.</param>
        /// <param name="e">Event data from the event. </param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FileLoadAndWrite().WriteFile(cmdText.Text);
        }

        private void SyntaxCheckEvent(object sender, EventArgs e)
        {
            if(parser.isrunning)
            {
                DialogResult dialogResult = MessageBox.Show("Code is still parsing do you want to stop the parse?", "Program Running", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    parser.terminate = true;

                }

            }
            else
            {
                parser.checksyntax = true;
                Console.WriteLine("Check syntax value changed to : " + parser.checksyntax);
                btn_run.PerformClick();
            }





            Console.WriteLine("*****Another program should start******" + btn_run.Enabled);
        }

        private void TerminateProgramEvent(object sender, EventArgs e)
        {
            parser.terminate = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            if (parser.isrunning)
            {
                DialogResult dialogResult = MessageBox.Show("Code is still parsing do you want to stop the parse?", "Program Running", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    parser.terminate = true;
                    
                }

            }
            else
            {
                this.Close();
            }
        }

        private void cmdText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

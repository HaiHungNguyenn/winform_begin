using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Applicaiton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 1;


        private void Form1_Load(object sender, EventArgs e)
        {
            createMyMainMenu();
        }

        private void createMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();

            this.Controls.Add(mainMenu);

            this.MainMenuStrip = mainMenu;

            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem mnuOpen = new ToolStripMenuItem("&Open");
            ToolStripSeparator separator = new ToolStripSeparator();
            ToolStripMenuItem mnuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem mnuwindow = new ToolStripMenuItem("&Window");

            // mainMenu

            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, mnuwindow });
            mainMenu.MdiWindowListItem = mnuwindow;

            // menuFile

            menuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen, separator, mnuExit });
            // mnuOpen
            mnuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            mnuOpen.Click += new EventHandler(mnuOpen_Click);
            // mnuExit
            mnuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            mnuExit.Click += new EventHandler(mnuExit_Click);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
           // frmChildForm childForm = new frmChildForm();
           // childForm.Text = $"ChildForm {counter++:DZ}";
            //childForm.MdiParent = this;

           // childForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_strips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }

        private void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&File");
            ToolStripMenuItem mnuNew = new ToolStripMenuItem("&New");
            ToolStripMenuItem mnuOpen = new ToolStripMenuItem("&Open");
            ToolStripMenuItem seperator = new ToolStripMenuItem();
            ToolStripMenuItem mnuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem mnuViewAbout = new ToolStripMenuItem("&View About");
            ToolStripMenuItem mnuAbout = new ToolStripMenuItem("&About");
            // mainMenu
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, mnuAbout });
            // menuFile 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, seperator, mnuExit });
            // Menu exit
            mnuAbout.DropDownItems.AddRange(new ToolStripItem[] { mnuViewAbout });

            //mnu New
            mnuNew.ShortcutKeys = (Keys)((Keys.Control | Keys.N));
            // menu open 
            mnuOpen.ShortcutKeys = (Keys)((Keys.Control | Keys.O));
            // mnu Exit
            mnuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            mnuExit.Click += new EventHandler(mnuExit_Click);
            // mnu view about
            mnuViewAbout.ShortcutKeys = Keys.F1;
            mnuViewAbout.Click += new EventHandler(mnuViewDetail_Click);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuViewDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Windows Form Application with .NET", "About");
        }
        
    }
}

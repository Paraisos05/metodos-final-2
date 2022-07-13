using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Project_Metodos
{
    public partial class Form1 : Form
    {

        //campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        //metodos

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color) {

            DisableButton();
            //Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();


            //Current Child Form Icon
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            OpenChildForm(new Dashboard());
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(panelPedidoSubmenu);
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            
        }

       

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            showSubMenu(panelSeguridadSubmenu);
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showSubMenu(panelProduccionSubmenu);

        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }*/

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            //Current Child Form Icon
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Inicio";
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
            hideSubmMenu();

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void customizeDesing() {
            panelPedidoSubmenu.Visible = false;
            panelProduccionSubmenu.Visible = false;
            panelSeguridadSubmenu.Visible = false;
        }

        private void hideSubmMenu() {
            if (panelPedidoSubmenu.Visible == true)
                panelPedidoSubmenu.Visible = false;
            if (panelProduccionSubmenu.Visible == true)
                panelProduccionSubmenu.Visible = false;
            if (panelSeguridadSubmenu.Visible == true)
                panelSeguridadSubmenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubmMenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventarioSeguridad());
        }

        private void btnInventarioPromedio_Click(object sender, EventArgs e)
        {
           
            hideSubmMenu();
        }

        private void btnCostoOrdenar_Click(object sender, EventArgs e)
        {
            hideSubmMenu();
        }

        private void btnCostoAlmacenar_Click(object sender, EventArgs e)
        {
            hideSubmMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmMenu();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CostoAnualPedido());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ISCostoTotal());
        }
    }
}

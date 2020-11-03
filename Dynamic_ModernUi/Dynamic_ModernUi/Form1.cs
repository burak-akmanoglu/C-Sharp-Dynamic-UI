using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dynamic_ModernUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           

        Panel pnl_left = new Panel();
        Panel pnl_top = new Panel();
        Panel pnl1 = new Panel();

        Button btn_close = new Button();
        Button btn_minimize = new Button(); 
        Button btn_fullscreen = new Button();
        

        Button btnhome = new Button();

        Button btn1 = new Button();
        Button btn1_1 = new Button();
        Button btn1_2 = new Button();
        Button btn1_3 = new Button();

        Button btn2 = new Button();
        Button btn2_1 = new Button();
        Button btn2_2 = new Button();
        Button btn2_3 = new Button();

        Button btn3 = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            //  this.FormBorderStyle = FormBorderStyle.None;
          
            btnsize();
            btncolor();
            btntxt();
            btn_dock();
            btn_visible();
            btnflat();

            btn1.Click += viewbtn;
            btn2.Click += wbtn2;
            btnhome.Click += viewhome;

            btn_close.Click += closeform;
            btn_fullscreen.Click += maxform;
            btn_minimize.Click += minform;





            pnl_top.BackColor = Color.FromArgb(11, 7, 17);
            pnl_top.Height = 40;
            pnl_top.Controls.AddRange(new Control[] { btn_minimize, btn_fullscreen, btn_close });
            pnl_top.Dock = DockStyle.Top;

            pnl1.BackColor = Color.FromArgb(32, 30, 45);
            pnl1.Left = 201;
            pnl1.Dock = DockStyle.Fill;

          
            pnl_left.BackColor = Color.FromArgb(11, 7, 17);
            pnl_left.Controls.AddRange(new Control[] { btn3, btn2_3, btn2_2, btn2_1, btn2, btn1_1, btn1_2, btn1_3, btn1, btnhome });
            pnl_left.BackColor = Color.FromArgb(11, 7, 17);
            pnl_left.Dock = DockStyle.Left;
            
            
           

            this.Controls.Add(pnl1);
            this.Controls.Add(pnl_left);
            this.Controls.Add(pnl_top);


        }

        private void closeform(object sender, EventArgs e)
        {
            this.Close();
        }
        private void maxform(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        private void minform(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_visible()
        {
            btn1_3.Visible = false;
            btn1_2.Visible = false;
            btn1_1.Visible = false;
            btn2_3.Visible = false;
            btn2_2.Visible = false;
            btn2_1.Visible = false;

        }


        private void viewbtn(object sender, EventArgs e)
        {

            if (btn1_2.Visible == false)
            {
                btn1_3.Visible = true;
                btn1_2.Visible = true;
                btn1_1.Visible = true;



            }
            else
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
            }

        }
        private void wbtn2(object sender, EventArgs e)
        {

            if (btn2_2.Visible == false)
            {
                btn2_3.Visible = true;
                btn2_2.Visible = true;
                btn2_1.Visible = true;



            }
            else
            {
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
            }

        }


        private void viewhome(object sender, EventArgs e)//form in panel
        {


            Form2 myForm = new Form2();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.Dock = DockStyle.Fill;
            pnl1.Controls.Add(myForm);
            myForm.Show();

        }
        private void btnflat()
        {
            btnhome.FlatStyle = FlatStyle.Flat;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1_1.FlatStyle = FlatStyle.Flat;
            btn1_2.FlatStyle = FlatStyle.Flat;
            btn1_3.FlatStyle = FlatStyle.Flat;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2_1.FlatStyle = FlatStyle.Flat;
            btn2_2.FlatStyle = FlatStyle.Flat;
            btn2_3.FlatStyle = FlatStyle.Flat;
            btn3.FlatStyle = FlatStyle.Flat;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_fullscreen.FlatStyle = FlatStyle.Flat;

            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1_1.FlatAppearance.BorderSize = 0;
            this.btn1_2.FlatAppearance.BorderSize = 0;
            this.btn1_3.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2_1.FlatAppearance.BorderSize = 0;
            this.btn2_2.FlatAppearance.BorderSize = 0;
            this.btn2_3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn_fullscreen.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.BorderSize = 0;


        }
        private void btnsize()
        {
            btn1_1.Size = new Size(200, 50);
            btn1_2.Size = new Size(200, 50);
            btn1_3.Size = new Size(200, 50);
            btn2.Size = new Size(200, 50);
            btn2_1.Size = new Size(200, 50);
            btn2_2.Size = new Size(200, 50);
            btn2_3.Size = new Size(200, 50);
            btn3.Size = new Size(200, 50);
            btnhome.Size = new Size(200, 50);
            btn1.Size = new Size(200, 50);

        }

        private void btncolor()
        {
            btnhome.BackColor = Color.FromArgb(23, 21, 32);

            btn3.BackColor = Color.FromArgb(23, 21, 32);

            btn1.BackColor = Color.FromArgb(23, 21, 32);
            btn1_1.BackColor = Color.FromArgb(35, 32, 39);
            btn1_2.BackColor = Color.FromArgb(35, 32, 39);
            btn1_3.BackColor = Color.FromArgb(35, 32, 39);

            btn2.BackColor = Color.FromArgb(23, 21, 32);
            btn2_1.BackColor = Color.FromArgb(35, 32, 39);
            btn2_2.BackColor = Color.FromArgb(35, 32, 39);
            btn2_3.BackColor = Color.FromArgb(35, 32, 39);



        }

        private void btntxt()
        {
            btnhome.Text = "HOME";
            btn1.Text = "CATEGORİES";

            btn1_1.Text = "Categories 1";
            btn1_2.Text = "Categories 2";
            btn1_3.Text = "Categories 3";

            btn2.Text = "PAGES";
            btn2_1.Text = "Pages 1";
            btn2_2.Text = "Pages 2";
            btn2_3.Text = "Pages 3";

            btn3.Text = "SETTİNGS";

            btn_close.Text = "Close";
            btn_minimize.Text = "Min";
            btn_fullscreen.Text = "Max";

            btn3.ForeColor = Color.LightGray;
            btn1.ForeColor = Color.LightGray;
            btn2.ForeColor = Color.LightGray;
            btnhome.ForeColor = Color.LightGray;
            btn1_1.ForeColor = Color.LightGray;
            btn1_2.ForeColor = Color.LightGray;
            btn1_3.ForeColor = Color.LightGray;
            btn2_1.ForeColor = Color.LightGray;
            btn2_2.ForeColor = Color.LightGray;
            btn2_3.ForeColor = Color.LightGray;
            btn_close.ForeColor = Color.LightGray;
            btn_fullscreen.ForeColor = Color.LightGray;
            btn_minimize.ForeColor = Color.LightGray;


        


        }

        private void btn_dock()
        {

            btnhome.Dock = DockStyle.Top;
            btn1.Dock = DockStyle.Top;
            btn1_3.Dock = DockStyle.Top;
            btn1_2.Dock = DockStyle.Top;
            btn1_1.Dock = DockStyle.Top;



            btn2.Dock = DockStyle.Top;
            btn2_1.Dock = DockStyle.Top;
            btn2_2.Dock = DockStyle.Top;
            btn2_3.Dock = DockStyle.Top;

            btn3.Dock = DockStyle.Bottom;

            btn_minimize.Dock = DockStyle.Right;
            btn_fullscreen.Dock = DockStyle.Right;
            btn_close.Dock = DockStyle.Right;

        }

    }
}
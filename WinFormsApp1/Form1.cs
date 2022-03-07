namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        float val1 = 0, val2 = 0, set = 0, res;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmain.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "3";
        }
        private void bnt4_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblmain.Text = lblmain.Text + "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            set = 1;
            val1 = float.Parse(lblmain.Text);
            lblmain.Text = "";
        }
        private void btnminus_Click(object sender, EventArgs e)
        {

            set = 2;
            val1 = float.Parse(lblmain.Text);
            lblmain.Text = "";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {

            set = 3;
            val1 = float.Parse(lblmain.Text);
            lblmain.Text = "";
        }
        private void btndivide_Click(object sender, EventArgs e)
        {
            set = 4;
            val1 = float.Parse(lblmain.Text);
            lblmain.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            set = 0;
            lblmain.Text = "";
            val1 = 0;
            val2 = 0;
            res = 0;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (val1 != 0)
            {
                val2 = float.Parse(lblmain.Text);
                switch (set)
                {
                    case 1:
                        res = val1 + val2;
                        lblmain.Text = String.Format("" + res);
                        break;
                    case 2:
                        res = val1 - val2;
                        lblmain.Text = String.Format("" + res);
                        break;
                    case 3:
                        res = val1 * val2;
                        lblmain.Text = String.Format("" + res);
                        break;
                    case 4:
                        res = val1 / val2;
                        lblmain.Text = String.Format("" + res);
                        break;
                }
            }
            else
                MessageBox.Show("Enter Value 1");
        }
    }
}
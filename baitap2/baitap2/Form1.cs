namespace baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[] dv = { 500000, 1200000, 1500000 };
            float[] phong = { 500000, 300000, 200000 };
            int songay;
            float tienphong = 0, tiendv = 0;
            //
            if (checkXe.Checked)
                tiendv += dv[0];
            if (checkAnUong.Checked)
                tiendv += dv[2];
            if (checkHDV.Checked)
                tiendv += dv[1];
            //
            if ((txtsngay.Text == "") || (txtsngay.Text == null)) return;
            songay = Convert.ToInt16(txtsngay.Text);
            if (radioS.Checked)
                tienphong = phong[0];
            if (radioTr.Checked)
                tienphong = phong[1];
            if (radioTh.Checked)
                tienphong = phong[2];
            //
            txtTientra.Text = ((tienphong + tiendv) * songay).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            txtcmnd.Text = "";
            txtsngay.Text = "";
            txtten.Focus();
        }
        private void txtsngay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double _iHizi,_tb, _st, _cHizi;
            _tb = Convert.ToInt32(tb.Text);
            _st = Convert.ToInt32(st.Text);
            _iHizi = Convert.ToInt32(i_hizi.Text); 
            _cHizi = Convert.ToInt32(ch.Text);
            double pi = 3.14;
            int MegaHZ = 100000000;

            double vMax = _iHizi * (_st*_st / 300 );
            double b_doppler = ((pi * pi * (vMax * _tb) * (vMax * _tb)) / (2))/ MegaHZ;
            double tb_kare = (_st * _st) / (_tb * _tb);
            double b_delay = ((4* tb_kare) / 9)*100;
            label8.Text = b_delay.ToString() + " x 10^(-2)";
            label10.Text = b_doppler.ToString() + " x 10^(-4)";
            //MessageBox.Show("Doppler MHZ üzerinden hesaplanmistir.","Bilgilendirme");
        }

        #region ----
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void i_hizi_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
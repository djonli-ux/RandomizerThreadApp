namespace Randomizer_threads
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private int min;
        private int max;
        public Form1()
        {
            InitializeComponent();
        }

        void RandomizeNumber(int min, int max) 
        {
            try 
            {
                int result = rand.Next(min, max);
                showNumber.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int min = string.IsNullOrEmpty(minValue.Text) ? 2 : int.Parse(minValue.Text);
            int max = string.IsNullOrEmpty(maxValue.Text) ? int.MaxValue : int.Parse(maxValue.Text);

            if (min > max)
            {
                MessageBox.Show("Invalid range: min should be less than max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RandomizeNumber(min, max);
        }
    }
}
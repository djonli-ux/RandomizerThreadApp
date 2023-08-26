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
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(minValue.Text, out min) && int.TryParse(maxValue.Text, out max))
                RandomizeNumber(min, max);
            else
                MessageBox.Show("Invalid input for min or max value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
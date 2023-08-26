namespace Randomizer_threads
{
    public partial class Form1 : Form
    {
        private bool stopGenerating = false;
        private Random rand = new Random();
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

        private void GenerateRandomNumberInThread(int min, int max)
        {
            Thread t = new Thread(() =>
            {
                while (!stopGenerating) 
                { 
                    Thread.Sleep(500);
                    RandomizeNumber(min, max);
                }
            });

            t.Start();
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

            GenerateRandomNumberInThread(min, max);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopGenerating = true;
        }
    }
}
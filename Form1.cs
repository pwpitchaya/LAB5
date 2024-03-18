namespace LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Gpacalculator gpacalculator = new Gpacalculator();
        private void button1_Click(object sender, EventArgs e)
        {
            string studentname = textBoxName.Text;
            string gpa = textBoxgpa.Text;

            double dGPA = 0;
            double.TryParse(gpa, out dGPA);
            if(dGPA == 0 )
            {
                return;
            }
            Student newstudent = new Student(studentname, dGPA);
            gpacalculator.setStudent(newstudent);

            Boxname.Text = studentname.ToString();

            BoxtHigh.Text = gpacalculator.GetHighScore().ToString();
            BoxLow.Text= gpacalculator.GetLowScore().ToString();
            Boxav.Text = gpacalculator.avScore().ToString();
            Boxgpa.Text = gpacalculator.getGPAX().ToString() ;





        }
    }
}

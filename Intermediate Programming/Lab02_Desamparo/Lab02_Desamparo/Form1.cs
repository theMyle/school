namespace Lab02_Desamparo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal HOMEWORKS = .1M;
        private const decimal PROJECTS = .35M;
        private const decimal QUIZZES = .1M;
        private const decimal EXAMS = .3M;
        private const decimal FINAL_EXAM = .15M;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal decHomework, decProjects, decQuizzes, decExams, decFinalExam;
            decimal WeigthedAverage;

            decHomework = decimal.Parse(txtHomework.Text);
            decProjects = decimal.Parse(txtProject.Text);
            decQuizzes = decimal.Parse(txtQuiz.Text);
            decExams = decimal.Parse(txtExam.Text);
            decFinalExam = decimal.Parse(txtFinalExam.Text);

            WeigthedAverage = (decHomework * HOMEWORKS) +
                (decProjects * PROJECTS) +
                (decQuizzes * QUIZZES) +
                (decExams * EXAMS) +
                (decFinalExam * FINAL_EXAM);

            txtWA.Text = WeigthedAverage.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHomework.Text = "";
            txtProject.Text = "";
            txtQuiz.Text = "";
            txtExam.Text = "";
            txtFinalExam.Text = "";
            txtWA.Text = "";

            txtHomework.Focus();
        }

    }
}

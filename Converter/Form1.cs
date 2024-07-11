using Manager;
namespace Converter
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            
        }
        

        public string Item1 { get => Input.Text; }
        public string Item2 { get => OutPut.Text; }

        public string num { get => number.Text; }

        private Presenter presenter;
        public void SetPresenter(Presenter presenter)
        {
            this.presenter = presenter;
        }


        private void ButtonCalc(object sender, EventArgs e)
        {

            presenter.Calculate(Item1, Item2, num);


        }

        public void GetResult(string res)
        {
            resultLable.Text = res;
        }
    }
}

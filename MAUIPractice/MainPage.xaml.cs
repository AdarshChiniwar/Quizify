using System.Collections.ObjectModel;

namespace MAUIPractice
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            Initialize();
            AddData();  
           
    
        }
        private void Initialize()
        {
            QuestionList = new ObservableCollection<QuestionModel>();
        }

        private void AddData()
        {
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
            QuestionList.Add(new QuestionModel());
        }
        private ObservableCollection<QuestionModel> questionList;

        public ObservableCollection<QuestionModel> QuestionList
        {
            get { return questionList; }
            set { questionList = value; OnPropertyChanged("QuestionList"); }
        }


    }

    public class QuestionModel
    {
        public string Question { get; set; } = "If you're a fitness walker, there is no need for a commute to a health club. Your neighborhood can be your health club. " +
            "You don't need a lot of fancy equipment to get a good workout either. All you need is a well-designed pair of athletic shoes." +
            "This paragraph best supports the statement that";
        public string ImageSource { get; set; } = "https://assets-global.website-files.com/5e6bef9160e290b99b7644b5/65fc076f425fdeb0c40994e5_Critical%20Thinking_%2010%20Ways%20to%20Improve.png";

        public string Answer { get; set; } = "In the past, consumers would rarely walk into an ice cream store and order low-fat ice cream. But that isn't the case today.";

        public string Header { get; set; } = "Stay Fit!!!";
    }

}

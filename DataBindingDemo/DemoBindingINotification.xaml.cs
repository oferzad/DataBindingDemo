using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoBindingINotification : ContentPage
    {
        private Student ReadStudentInfo()
        {
            return new Student()
            {
                Name = "Ofer",
                Grade = 70
            };
        }
        public DemoBindingINotification()
        {
            this.BindingContext = ReadStudentInfo();
            InitializeComponent();
        }

        private void btnBonus_Clicked(object sender, EventArgs e)
        {
            Student student = (Student)this.BindingContext;
            student.Grade += 20;
        }
    }
}
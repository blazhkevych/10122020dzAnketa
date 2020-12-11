using System;
using System.IO;
using System.Windows.Forms;

namespace _10122020dzAnketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //buttonSeeResults.Click += ButtonSeeResults_Click;
            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //private void ButtonSeeResults_Click(object sender, EventArgs e)
        //{

        //    //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        //    //    return;
        //    //// получаем выбранный файл
        //    //string filename = saveFileDialog1.FileName;
        //    //// сохраняем текст в файл
        //    //System.IO.File.WriteAllText(filename, textBoxName.Text);
        //    //MessageBox.Show("Файл сохранен");
        //}

        private void buttonSeeResults_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists("questionnaires.txt"))
                using (var sw = File.CreateText(Application.StartupPath + @"\" + "questionnaires.txt"))
                {
                    sw.WriteLine($"\t***Анкета создана {DateTime.Now}***");
                    sw.WriteLine("Фамилия : " + textBoxSurname.Text);
                    sw.WriteLine("Имя : " + textBoxName.Text);
                    sw.WriteLine("Отчество : " + textBoxPatronymic.Text);
                    sw.WriteLine("Страна : " + textBoxCountry.Text);
                    sw.WriteLine("Город : " + textBoxCity.Text);
                    sw.WriteLine("Телефон : " + textBoxPhone.Text);
                    sw.WriteLine("Дата рождения : " + dateTimePickerBirthday.Text);

                    var value = "";
                    var isChecked = radioButtonFemale.Checked;
                    if (isChecked)
                        value = radioButtonFemale.Text;
                    else
                        value = radioButtonMale.Text;

                    sw.WriteLine($"Пол : {value}");
                    sw.WriteLine('\n');
                }
            else
                using (var sw = File.AppendText(Application.StartupPath + @"\" + "questionnaires.txt"))
                {
                    sw.WriteLine($"\t***Анкета создана {DateTime.Now}***");
                    sw.WriteLine("Фамилия : " + textBoxSurname.Text);
                    sw.WriteLine("Имя : " + textBoxName.Text);
                    sw.WriteLine("Отчество : " + textBoxPatronymic.Text);
                    sw.WriteLine("Страна : " + textBoxCountry.Text);
                    sw.WriteLine("Город : " + textBoxCity.Text);
                    sw.WriteLine("Телефон : " + textBoxPhone.Text);
                    sw.WriteLine("Дата рождения : " + dateTimePickerBirthday.Text);

                    var value = "";
                    var isChecked = radioButtonFemale.Checked;
                    if (isChecked)
                        value = radioButtonFemale.Text;
                    else
                        value = radioButtonMale.Text;

                    sw.WriteLine($"Пол : {value}");
                    sw.WriteLine('\n');
                }
            //обнуляем поля
            textBoxSurname.Clear();
            textBoxName.Clear();
            textBoxPatronymic.Clear();
            textBoxCountry.Clear();
            textBoxCity.Clear();
            textBoxPhone.Clear();
            dateTimePickerBirthday.Value = DateTime.Now;
        }
    }
}
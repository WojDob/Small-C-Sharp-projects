using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace formularz
{
    public partial class Form1 : Form
    {
        int index;
        List<Person> people = new List<Person>();


        public Form1()
        {
            InitializeComponent();
            index = 0;
            XDocument xml = XDocument.Load("People.xml");

            people = (
                from person in xml.Root.Elements("person")
                select new Person(
                    person.Element("name").Value,
                    person.Element("surname").Value,
                    person.Element("dateOfBirth").Value,
                    person.Element("height").Value,
                    person.Element("position").Value,
                    Convert.ToBoolean(person.Element("isMale").Value),
                    Convert.ToInt32(person.Element("salary").Value)
                    )
                ).ToList<Person>();
            if(people.Count>0)
                fillForm(people.ElementAt(0));
            Console.Write("=====DEBUG=====\n");
            printCurrentIndex();

        }


        //======================Bottom buttons======================

        private void newButton_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool formNotFilled = false;
            if(nameBox.Text == "")
            {
                nameBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if (surnameBox.Text == "")
            {
                surnameBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if (dateBox.Text == "")
            {
                dateBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if (heightBox.Text == "")
            {
                heightBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if (positionComboBox.Text == "")
            {
                positionComboBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if (salaryBox.Text == "")
            {
                salaryBox.BackColor = Color.Red;
                formNotFilled = true;
            }
            if(!mRadioButton.Checked && !kRadioButton.Checked)
            {
                mRadioButton.BackColor = Color.Red;
                kRadioButton.BackColor = Color.Red;
                formNotFilled = true;
            }

            if(formNotFilled)
            {
                MessageBox.Show("Prosze uzupelnic wszystkie pola formularza przed dodaniem osoby");
                return;
            }

            int tempSalary = 0;
            try
            {
               tempSalary = System.Convert.ToInt32(salaryBox.Text);
            }
            catch (FormatException)
            {
                // the FormatException is thrown when the string text does 
                // not represent a valid integer.
                MessageBox.Show("Do pola wynagrodzenie prosze wpisac liczbe");
                salaryBox.BackColor = Color.Red;
                return;
            }
            catch (OverflowException)
            {

                MessageBox.Show("OverflowException");
                return;
            }

            Person person = new Person(
                nameBox.Text,
                surnameBox.Text,
                dateBox.Text,
                heightBox.Text, 
                positionComboBox.Text, 
                mRadioButton.Checked,
                tempSalary);

            people.Add(person);
            index = people.Count - 1;
            fillForm(people.ElementAt(index));
            printList();
            printCurrentIndex();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (people.Count > 0)
            {
                people.RemoveAt(index);
                if(index!=0)
                    index--;
                if (people.Count > 0)
                    fillForm(people.ElementAt(index));
                else
                    clearForm();
            }
            printList();
            printCurrentIndex();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("people",
                    from person in people
                    select new XElement("person",
                        new XElement("name",person.Name),
                        new XElement("surname", person.Surname),
                        new XElement("dateOfBirth", person.DateOfBirth),
                        new XElement("height", person.Height),
                        new XElement("isMale", person.IsMale),
                        new XElement("position", person.Position),
                        new XElement("salary", person.Salary)
                        )
                    )
                );
            xml.Save("People.xml");
            Console.Write("Saved to file\n");
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                fillForm(people.ElementAt(index));
            }
            printCurrentIndex();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if( index < people.Count -1)
                index++;
            if (index < people.Count && people.Count > 0)
                fillForm(people.ElementAt(index));
            printCurrentIndex();
        }
        private void goToEnd_Click(object sender, EventArgs e)
        {

            
            
            if (people.Count > 0)
            {
                index = people.Count - 1;
                fillForm(people.ElementAt(index));
            }
            printCurrentIndex();
        }

        private void goToStart_Click(object sender, EventArgs e)
        {
            index = 0;
            printCurrentIndex();
            if(people.Count>0)
                fillForm(people.ElementAt(index));
        }

        //======================Form fields======================

        private void mRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mRadioButton.BackColor = Color.WhiteSmoke;
            kRadioButton.BackColor = Color.WhiteSmoke;
        }

        private void kRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mRadioButton.BackColor = Color.WhiteSmoke;
            kRadioButton.BackColor = Color.WhiteSmoke;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            nameBox.BackColor = Color.White;
        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            surnameBox.BackColor = Color.White;
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {
            dateBox.BackColor = Color.White;
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            heightBox.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionComboBox.BackColor = Color.White;
        }
        private void salaryBox_TextChanged(object sender, EventArgs e)
        {
            salaryBox.BackColor = Color.White;
        }

        private void fillForm(Person person)
        {
            nameBox.Text = person.Name;
            surnameBox.Text = person.Surname;
            dateBox.Text = person.DateOfBirth;
            heightBox.Text = person.Height;
            positionComboBox.Text = person.Position;
            salaryBox.Text = person.Salary.ToString() + " zł";
            if (person.IsMale)
                mRadioButton.Checked = true;
            else if (person.IsMale == false)
                kRadioButton.Checked = true;

        }
        private void clearForm()
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            dateBox.Text = "";
            heightBox.Text = "";
            positionComboBox.Text = "";
            salaryBox.Text = "";
            mRadioButton.Checked = false;
            kRadioButton.Checked = false;

        }


        //===============DEBUGGING===============

        public void printList()
        {
            Console.Write("LIST:\n");
            foreach (Person boio in people)
            {
                printPerson(boio);
            }
            Console.Write("\n");
        }
        private void printPerson(Person person)
        {
            Console.Write(
                person.Name + " " +
                person.Surname + " " +
                person.DateOfBirth + " " +
                person.Height + " " +
                person.Position + " " +
                person.IsMale + " " +
                person.Salary.ToString() + "\n");
        }
        private void printCurrentIndex()
        {
            Console.Write("current index: " + index + "\n");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

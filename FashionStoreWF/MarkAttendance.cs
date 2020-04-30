using FashionStoreWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStoreWF
{
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            List<Employee> empList = db.GetAllEmployees();

            //SelectEmp.Items.Add(empList);
            
            foreach (var item in empList)
            {
                ComboboxItem comboItem = new ComboboxItem();

                comboItem.Text = item.e_name;
                comboItem.Value = item.e_id;

                SelectEmp.Items.Add(comboItem);
            }
            SelectEmp.SelectedIndex = -1;
        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            if (SelectEmp.SelectedIndex == -1)
            {
                errorProvider1.SetError(SelectEmp, "Required!");
            }
            else
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy H:mm");

                Attendance attendance = new Attendance();

                attendance.e_id = (SelectEmp.SelectedItem as ComboboxItem).Value;
                attendance.e_name = (SelectEmp.SelectedItem as ComboboxItem).Text;
                attendance.a_date = date;

                DataAccess db = new DataAccess();
                db.AddAttendance(attendance);
                SelectEmp.SelectedIndex = -1;
            }
        }
    }

    public class ComboboxItem 
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

using Assignment401AZ.DBOperations;
using Assignment401AZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment401AZ.GUI
{
    public partial class EngineerForm : Form
    {
        private EngineerOperations engineerOperations = new EngineerOperations();
        public EngineerForm()
        {
            InitializeComponet();
        }



        private void ADD_Click(object sender, EventArgs e)
        {
            Engineers newEngineer = new Engineers
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Tel = txtTel.Text,
                Dateofbirth = dateTimePickerDOB.Value,
                AddressID = txtAddressID.Text
            };

            engineerOperations.AddEngineers(newEngineer);
            LoadEngineers();
        }


        private void LoadEngineers()
        {
            dataGridViewEngineers.DataSource = engineerOperations.GetEngineerss();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                Engineers selectedEngineer = GetSelectedRowEngineer();

                if (selectedEngineer != null)
                {
                    selectEngineer.FirstName = txtFirstName.Text;
                    selectEngineer.LastName = txtLastName.Text;
                    selectEngineer.Tel = txtTel.Text;
                    selectEngineer.Dateofbirth = dateTimePickerDOB.Value;
                    selectEngineer.AddressID = txtAddressID.Text;


                    engineerOperations.UpdateEngineers(selectedEngineer);
                    LoadEngineers();
                    ClearEngineerFields();
                }
                else
                {
                    MessageBox.Show("Please select a engineer to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a engineer to update.");
            }
        }

        private Engineers GetSelectedRowEngineer()
        {
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEngineers.SelectedRows[0];
                return new Engineers
                {
                    ManagerID = Convert.ToInt32(selectedRow.Cells["ManagerID"].Value),
                    FirstName = Convert.ToString(selectedRow.Cells["FirstName"].Value),
                    LastName = Convert.ToString(selectedRow.Cells["LastName"].Value),
                    AddressID = Convert.ToString(selectedRow.Cells["AddressID"].Value),
                    DateofBirth = Convert.ToDateTime(selectedRow.Cells["DateofBirth"].Value),
                    Tel = Convert.ToInt32(selectedRow.Cells["Tel"].Value)
                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                int EngineerId = GetSelectedRowEngineerId();

                if (EngineerId != -1)
                {
                    engineerOperations.DeleteEngineers(EngineerId);
                    LoadEngineers();
                    ClearEngineerFields();
                }
                else
                {
                    MessageBox.Show("Please select a customer to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }


        private void EngineerForm_Load_1(object sender, EventArgs e)
        {
            LoadEngineers();
        }


        private int GetSelectedRowEngineerId()
        {
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewEngineers.SelectedRows[0].Cells["EngineerID"].Value);
            }

            return -1;
        }

        private void ClearEngineerFields()
        {
                txtFirstName.Clear;
                txtLastName.Clear;
                txtTel.Clear;
                dateTimePickerDOB.Value = DateTime.Now;
                txtAddressID.Clear;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingParkingApp
{
    public partial class Form1 : Form
    {
        private int Count = 0;
        private string button = "";
        private string vehicleType;
        ParkingHouse house = new ParkingHouse();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            new ParkingHouse();
            btnLoad.Enabled = false;
            grpMenu.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                button = "park";
                grpSubmenu.Visible = true;
                Count++;
            }
            else
            {
                grpInput.Visible = false;
                grpSubmenu.Visible = false;
                Count--;
            }
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                vehicleType = "Car";
                grpInput.Visible = true;
                Count++;
            }
            else
            {
                grpInput.Visible = false;
                Count--;
            }
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                vehicleType = "Mc";
                grpInput.Visible = true;
                Count++;
            }
            else
            {
                grpInput.Visible = false;
                Count--;
            }
        }

        private void btnBike_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                vehicleType = "Bike";
                grpInput.Visible = true;
                Count++;
            }
            else
            {
                grpInput.Visible = false;
                Count--;
            }
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                vehicleType = "Bus";
                grpInput.Visible = true;
                Count++;
            }
            else
            {
                grpInput.Visible = false;
                Count--;
            }
        }

        private void txtRegBox_TextChanged(object sender, EventArgs e)
        {
            txtRegBox.MaxLength = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button == "park")
            {
                string output = house.CreateVehicle(txtRegBox.Text.ToUpper(), vehicleType);
                MessageBox.Show(output);
                txtRegBox.Text = "";
                grpInput.Visible = false;
                grpSubmenu.Visible = false;
            }
            else if (button == "Remove")
            {
                string removed = house.RemoveVehicle(txtRegBox.Text.ToUpper());
                MessageBox.Show(removed);
                txtRegBox.Text = "";
                grpInput.Visible = false;
            }
            else if (button == "Search Vehicle")
            {
                string search = house.SearchForeVehicle(txtRegBox.Text.ToUpper());
                MessageBox.Show(search);
                txtRegBox.Text = "";
                grpInput.Visible = false;
                Count--;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            grpInput.Visible = true;
            button = "Remove";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                Count++;
                foreach (ParkingSpot spot in house.ParkingList)
                {
                    if (spot.AvailableSize == 4)
                    {
                        lstPHouse.Items.Add($"{spot.SpotNumber}: Empty");
                    }
                    foreach (Vehicle vehicle in spot.vehicles)
                    {
                        lstPHouse.Items.Add($"{spot.SpotNumber}: {vehicle.RegNumber}");
                    }
                }
                lstPHouse.Visible = true;
            }
            else
            {
                lstPHouse.Visible = false;
                Count--;
            }

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            
            lstPHouse.Visible = true;
            foreach (var item in house.ParkingList)
            {
                lstPHouse.Items.Add(item.SpotNumber);
            }
            lstPHouse.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                button = "Search Vehicle";
                grpInput.Visible = true;
                Count++;
            }
            else
            {
                grpInput.Visible = false;
                Count--;
            }
        }
    }
    public enum SelectedType
    {
        parkbtn,
        removebtn,
        movebtn,
        searchbtn,
        showbtn,
    }
}

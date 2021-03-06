﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKK_controls;

namespace IKK
{
    public partial class View1Main : IKK_controls.View
    {
        public View1Main()
        {
            InitializeComponent();
        }

        private void navMenu1_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (navMenu1.SelectedItem)
            {
                case "Főoldal":
                    viewContainer1.SetView(new View2Front());
                    break;
                case "Profil":
                    viewContainer1.SetView(new View2Profile());
                    break;
                case "Verses fal":
                    if (IKK_storage.Storage.OfflineMode)
                    {
                        MsgBox.Show("Offline mód", "A verses fal offline nem használható.");
                        navMenu1.SelectedItem = "Főoldal";
                    }
                    else viewContainer1.SetView(new View2Feed());
                    break;
                case "Művek":
                    viewContainer1.SetView(new View2Projects());
                    break;
            }
        }
    }
}

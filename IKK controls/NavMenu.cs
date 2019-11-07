using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK_controls
{
    public partial class NavMenu : UserControl
    {
        public bool Collapsed { get => collapsed; set { collapsed = value; Width = collapsed ? nmiMenuTitle.Height : 250; } }
        public ImageList ItemIcons { get => itemIcons; set { itemIcons = value; RefreshItems(); } }
        public string Items { get => items; set { items = value; RefreshItems(); } }
        public string SelectedItem
        {
            get => flp.Controls.Cast<NavMenuItem>().First(r => r.Selected).Text;
            set
            {
                if (flp.Controls.Cast<NavMenuItem>().Count(r => r.Text == value) < 1) return;

                ClickItem(flp.Controls.Cast<NavMenuItem>().First(r => r.Text == value), new EventArgs());
            }
        }

        bool collapsed = false;
        ImageList itemIcons = new ImageList();
        string items = "";

        public event EventHandler SelectedItemChanged;

        public NavMenu()
        {
            InitializeComponent();
        }

        private void nmiMenuTitle_Click(object sender, EventArgs e)
        {
            Collapsed = !Collapsed;

            nmiMenuTitle.Refresh();

            foreach (Control item in flp.Controls)
            {
                item.Refresh();
            }
        }

        void ClickItem(object sender, EventArgs e)
        {
            foreach (NavMenuItem item in flp.Controls)
            {
                item.Selected = false;
                item.Refresh();
            }

            ((NavMenuItem)sender).Selected = true;
            ((NavMenuItem)sender).Refresh();

            SelectedItemChanged?.Invoke(this, new EventArgs());
        }

        void RefreshItems()
        {
            flp.Controls.Clear();

            NavMenuItem nextItem;

            for (int i = 0; i < items.Split(';').Length; i++)
            {
                nextItem = new NavMenuItem(items.Split(';')[i]);
                if (itemIcons.Images.Count > i) nextItem.Icon = itemIcons.Images[i];
                nextItem.Click += ClickItem;
                flp.Controls.Add(nextItem);
            }

            ((NavMenuItem)flp.Controls[0]).Selected = true;
        }

        private void NavMenu_Paint(object sender, PaintEventArgs e)
        {
            RefreshItems();
        }
    }
}

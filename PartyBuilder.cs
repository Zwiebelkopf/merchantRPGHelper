using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant_RPG {
    public partial class PartyBuilder : Form {

        private Form1 parent;
        private Hero pos1, pos2, pos3, pos4, pos5, pos6;
        private int removeFrom;

        public PartyBuilder() {
            InitializeComponent();
        }

        public PartyBuilder(Form1 parent, ListBox box) {
            InitializeComponent();
            this.parent = parent;
            foreach (Hero entry in box.Items) {
                listBox1.Items.Add(entry);
            }
        }

        // Begin DragDrop at the listBox1
        private void listBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy | DragDropEffects.Move);
        }

        // every label has this event that checks, wether it accepts the item or not
        private void labels_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(Hero)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // label specific Drop function: Put hero in action
        private void label1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom == 0) {
                pos1 = (Hero)e.Data.GetData(typeof(Hero));
                label1.Text = pos1.Name;
                listBox1.Items.Remove(pos1);
            }
        }
        private void label2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom == 0) {
                pos2 = (Hero)e.Data.GetData(typeof(Hero));
                label2.Text = pos2.Name;
                listBox1.Items.Remove(pos2);
            }
        }
        private void label3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom == 0) {
                pos3 = (Hero)e.Data.GetData(typeof(Hero));
                label3.Text = pos3.Name;
                listBox1.Items.Remove(pos3);
            } 
        }
        private void label4_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom == 0) {
                pos4 = (Hero)e.Data.GetData(typeof(Hero));
                label4.Text = pos4.Name;
                listBox1.Items.Remove(pos4);
                GoodToGo.Text = "Let's Go!";
            } 
        }
        private void label5_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom == 0) {
                pos5 = (Hero)e.Data.GetData(typeof(Hero));
                label5.Text = pos5.Name;
                listBox1.Items.Remove(pos5);
            } 
        }
        private void label6_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom == 0) {
                pos6 = (Hero)e.Data.GetData(typeof(Hero));
                label6.Text = pos6.Name;
                listBox1.Items.Remove(pos6);
            } 
        }

        // AAAAAAAND back to the bench again

        // remove Heroes from position
        private void labels_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            try {
                switch (((System.Windows.Forms.Control)(sender)).Name) {
                    case "label1":
                        removeFrom = 1;
                        label1.DoDragDrop(pos1, DragDropEffects.Copy | DragDropEffects.Move);
                        break;
                    case "label2":
                        removeFrom = 2;
                        label2.DoDragDrop(pos2, DragDropEffects.Copy | DragDropEffects.Move);
                        break;
                    case "label3":
                        removeFrom = 3;
                        label3.DoDragDrop(pos3, DragDropEffects.Copy | DragDropEffects.Move);
                        break;
                    case "label4":
                        removeFrom = 4;
                        label4.DoDragDrop(pos4, DragDropEffects.Copy | DragDropEffects.Move);
                        break;
                    case "label5":
                        removeFrom = 5;
                        label5.DoDragDrop(pos5, DragDropEffects.Copy | DragDropEffects.Move);
                        break;
                    case "label6":
                        removeFrom = 6;
                        label6.DoDragDrop(pos6, DragDropEffects.Copy | DragDropEffects.Move);
                        break;
                }
            }
            catch (NullReferenceException ex) { }
        }

        private void listBox1_DragEnter(object Ssender, System.Windows.Forms.DragEventArgs e) {
            if (e.Data.GetDataPresent(typeof(Hero)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            if (removeFrom > 0) {
                listBox1.Items.Add(e.Data.GetData(typeof(Hero)));
                switch (removeFrom) {
                    case 1:
                        label1.Text = "Position 1";
                        pos1 = null;
                        break;
                    case 2:
                        label2.Text = "Position 2";
                        pos2 = null;
                        break;
                    case 3:
                        label3.Text = "Position 3";
                        pos3 = null;
                        break;
                    case 4:
                        label4.Text = "Position 4";
                        GoodToGo.Text = "Cancel";
                        pos4 = null;
                        break;
                    case 5:
                        label5.Text = "Position 5";
                        pos5 = null;
                        break;
                    case 6:
                        label6.Text = "Position 6";
                        pos6 = null;
                        break;
                }
                removeFrom = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (GoodToGo.Text == "Cancel") {
                parent.PartyUp(null);
                this.Close();
            }
            else {
                Dictionary<int, Hero> order = new Dictionary<int, Hero>();
                if (pos1 != null)
                    order.Add(1, pos1);
                if (pos2 != null)
                    order.Add(2, pos2);
                if (pos3 != null)
                    order.Add(3, pos3);
                if (pos4 != null)
                    order.Add(4, pos4);
                if (pos5 != null)
                    order.Add(5, pos5);
                if (pos6 != null)
                    order.Add(6, pos6);

                parent.PartyUp(order);
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Merchant_RPG {

    public partial class Form1 : Form {

        private Hero activeHero;
        private int selectedHeroList;
        private Library bibo = new Library();
        private EditItem editItem;
        private List<Hero> activeHeroes = new List<Hero>();

        public Form1() {
            InitializeComponent();
            Fill_HeroChooser();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        #region Allgemein

        private void Fill_HeroChooser() {
            foreach (Hero entry in bibo.Heroes) {
                //HeroChooserValue hcv = new HeroChooserValue(Library.Heroes[i]);
                HeroChooser.Items.Add(entry);
            }

            for (int i = 1; i <= 60; i++) {
                LevelPicker.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            // Plus
            if (HeroChooser.SelectedItem != null) {
                Hero temp = new Hero(bibo.Heroes.First(x => x.Name.Equals(HeroChooser.SelectedItem.ToString())));

                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Weapon")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Helm")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Chest")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Gloves")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Boots")));
                temp.Equip(bibo.Items.First(x => x.Name.Equals("Worn Trinket")));

                HeroList.Items.Add(temp);
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            // Minus
            if (HeroList.SelectedIndex >= 0)
                HeroList.Items.RemoveAt(HeroList.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e) {

            /*Monster enemy = Library.Monsters.First(x => x.Name == "Forest Gathering");
            double enemyHP = enemy.HP;
            double runden = 0;

            while (enemyHP > 0) {
                double dmg = myHero.Level * myHero.LevelAttack;
                double def = enemy.Defense;
                enemyHP -= dmg;
                runden++;
            }
            Console.WriteLine("HUHU");*/
        }

        #endregion

        #region Tabpage1 => Attribute

        private void HeroList_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (HeroList.SelectedIndex >= 0) {
                activeHero = (Hero)HeroList.SelectedItem;
                selectedHeroList = HeroList.SelectedIndex;
                HeroNameLabel.Text = activeHero.Name;
                LevelPicker.SelectedIndex = activeHero.Level - 1;
                att_str.Text = activeHero.Strength.ToString();
                att_int.Text = activeHero.Intelligence.ToString();
                att_dex.Text = activeHero.Dexterity.ToString();
                updateStats();
                updateEquipment();
            }
        }

        private void updateStats() {
            att_patk.Text = activeHero.GetRealValue("Attack").ToString();
            att_matk.Text = activeHero.GetRealValue("MagicAttack").ToString();
            att_acc.Text = activeHero.GetRealValue("Accuracy").ToString();
            att_crit.Text = activeHero.GetRealValue("Critical").ToString(); 
            att_mdef.Text = activeHero.GetRealValue("MagicDefense").ToString();
            att_pdef.Text = activeHero.GetRealValue("Defense").ToString();
            att_dmg.Text = (double.Parse(att_patk.Text) + double.Parse(att_matk.Text)).ToString();
        }

        private void LevelPicker_SelectedItemChanged(object sender, EventArgs e) {
            activeHero.Level = int.Parse(LevelPicker.Text);
            updateStats();
            HeroList.Items[selectedHeroList] = activeHero;
        }

        #endregion

        #region TabPage2 => Equipment

        private void updateEquipment() {
            Equip_weapon_label.Text = activeHero.Inventar.GetSlot(ItemSlot.Weapon).ToString() + "\n" + activeHero.Inventar.GetSlot(ItemSlot.Weapon).Description();
            Equip_helm_label.Text = activeHero.Inventar.GetSlot(ItemSlot.Helm).ToString() + "\n" + activeHero.Inventar.GetSlot(ItemSlot.Helm).Description();
            Equip_chest_label.Text = activeHero.Inventar.GetSlot(ItemSlot.Chest).ToString() + "\n" + activeHero.Inventar.GetSlot(ItemSlot.Chest).Description();
            Equip_gloves_label.Text = activeHero.Inventar.GetSlot(ItemSlot.Gloves).ToString() + "\n" + activeHero.Inventar.GetSlot(ItemSlot.Gloves).Description();
            Equip_boots_label.Text = activeHero.Inventar.GetSlot(ItemSlot.Boots).ToString() + "\n" + activeHero.Inventar.GetSlot(ItemSlot.Boots).Description();
            Equip_trinket_label.Text = activeHero.Inventar.GetSlot(ItemSlot.Trinket).ToString() + "\n" + activeHero.Inventar.GetSlot(ItemSlot.Trinket).Description();
        }

        private void button4_Click(object sender, EventArgs e) {
            // Change Weapon
            Equip_weapon_label.Text = "Dies ist ein langer Text um zu prüfen,\nwas genau das Programm damit macht.";
            editItem = new EditItem(this, ItemSlot.Weapon, activeHero.Inventar.GetSlot(ItemSlot.Weapon));
            editItem.Show();
        }
        private void button5_Click(object sender, EventArgs e) {
            // Change Helm
            editItem = new EditItem(this, ItemSlot.Helm, activeHero.Inventar.GetSlot(ItemSlot.Helm));
            editItem.Show();
        }
        
        private void button6_Click(object sender, EventArgs e) {
            // Change Chest
            editItem = new EditItem(this, ItemSlot.Chest, activeHero.Inventar.GetSlot(ItemSlot.Chest));
            editItem.Show();
        }

        private void button7_Click(object sender, EventArgs e) {
            // Change Gloves
            editItem = new EditItem(this, ItemSlot.Gloves, activeHero.Inventar.GetSlot(ItemSlot.Gloves));
            editItem.Show();
        }

        private void button8_Click(object sender, EventArgs e) {
            // Change Boots
            editItem = new EditItem(this, ItemSlot.Boots, activeHero.Inventar.GetSlot(ItemSlot.Boots));
            editItem.Show();
        }

        private void button9_Click(object sender, EventArgs e) {
            // Change Trinket
            editItem = new EditItem(this, ItemSlot.Trinket, activeHero.Inventar.GetSlot(ItemSlot.Trinket));
            editItem.Show();
            HeroList.Enabled = false;
        }

        public void CreateItemAndEquip(Item item) {
            if (item != null) {
                activeHero.Equip(item);
                updateEquipment();
                updateStats();
            }
            HeroList.Enabled = true;
        }

        #endregion

        public void SaveToFile(List<Hero> heroes, string fileName){
            if (heroes.Count == 0){ return; }
            
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Hero>));
            using (MemoryStream stream = new MemoryStream()) {
                serializer.Serialize(stream, heroes);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(fileName);
            }
            

        }

        public void LoadFromFile(int slot) {
            string path = "save_" + slot + ".xml";
            if (File.Exists(path)) {
                activeHeroes = new List<Hero>();
                XmlSerializer x = new XmlSerializer(typeof(List<Hero>));
                StreamReader reader = new StreamReader(path);
                activeHeroes = (List<Hero>)x.Deserialize(reader);
                reader.Close();

                if (activeHeroes.Count > 0) {
                    HeroList.Items.Clear();
                    foreach (Hero hero in activeHeroes) {
                        HeroList.Items.Add(hero);
                    }
                }
                else {
                    MessageBox.Show("Found no Heroes");
                }
            }
            else {
                MessageBox.Show("File " + path + " not found.");
            }

            

        }

        private void Save(int slot) {
            activeHeroes = new List<Hero>();
            foreach (Hero entry in HeroList.Items) {
                activeHeroes.Add(entry);
            }
            
            SaveToFile(activeHeroes, "save_" + slot + ".xml");
        }

        // Save Slots
        private void slot1ToolStripMenuItem_Click(object sender, EventArgs e) {
            Save(1);
        }

        private void slot2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Save(2);
        }

        private void slot3ToolStripMenuItem_Click(object sender, EventArgs e) {
            Save(3);
        }

        // Open Slots
        private void slot1ToolStripMenuItem1_Click(object sender, EventArgs e) {
            LoadFromFile(1);
        }

        private void slot2ToolStripMenuItem1_Click(object sender, EventArgs e) {
            LoadFromFile(2);
        }

        private void slot3ToolStripMenuItem1_Click(object sender, EventArgs e) {
            LoadFromFile(3);
        }
       

    }
}

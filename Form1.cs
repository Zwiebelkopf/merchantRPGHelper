﻿using System;
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
        private PartyBuilder party;
        private List<Hero> activeHeroes = new List<Hero>();
        private Dictionary<int, Hero> gruppe;
        public Skill basicSkill;

        public Form1() {
            InitializeComponent();
            Fill_HeroChooser();
            Fill_EnemyChooser();
            basicSkill = bibo.Skills.First(x => x.Name.Equals("Basic"));
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

        private void HeroList_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (HeroList.SelectedIndex >= 0) {
                activeHero = (Hero)HeroList.SelectedItem;
                selectedHeroList = HeroList.SelectedIndex;
                HeroNameLabel.Text = activeHero.Name;
                LevelPicker.SelectedIndex = activeHero.Level - 1;
                updateEquipment();
                Fill_SkillChooser();
                updateStats();
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

                temp.SelectSkill('1', bibo.Skills.First(x => x.Name.Equals("Basic")));
                temp.SelectSkill('2', bibo.Skills.First(x => x.Name.Equals("Basic")));
                temp.SelectSkill('3', bibo.Skills.First(x => x.Name.Equals("Basic")));
                temp.SelectSkill('4', bibo.Skills.First(x => x.Name.Equals("Basic")));
                temp.SelectSkill('5', bibo.Skills.First(x => x.Name.Equals("Basic")));

                HeroList.Items.Add(temp);
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            // Minus
            if (HeroList.SelectedIndex >= 0)
                HeroList.Items.RemoveAt(HeroList.SelectedIndex);
        }

        public void SaveToFile(List<Hero> heroes, string fileName) {
            if (heroes.Count == 0) { return; }

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

        #endregion

        #region Tabpage1 => Attribute

        private void updateStats() {
            att_patk.Text = activeHero.GetRealValue("Attack", true).ToString();
            att_matk.Text = activeHero.GetRealValue("MagicAttack", true).ToString();
            att_acc.Text = activeHero.GetRealValue("Accuracy", true).ToString();
            att_crit.Text = activeHero.GetRealValue("Critical", true).ToString(); 
            att_mdef.Text = activeHero.GetRealValue("MagicDefense", true).ToString();
            att_pdef.Text = activeHero.GetRealValue("Defense", true).ToString();
            att_str.Text = activeHero.GetRealValue("Strength", true).ToString();
            att_int.Text = activeHero.GetRealValue("Intelligence", true).ToString();
            att_dex.Text = activeHero.GetRealValue("Dexterity", true).ToString();
            maxHP.Text = activeHero.GetRealValue("HP", true).ToString();
            att_dmg.Text = Math.Round(activeHero.GetRealValue("Attack", false) + activeHero.GetRealValue("MagicAttack", false),0).ToString(); //(double.Parse(att_patk.Text) + double.Parse(att_matk.Text)).ToString();
         }

        private void LevelPicker_SelectedItemChanged(object sender, EventArgs e) {
            activeHero.Level = int.Parse(LevelPicker.Text);
            updateStats();
            HeroList.Items[selectedHeroList] = activeHero;
            tabControl1.TabPages[2].Enabled = activeHero.Level >= 10 ? true : false;
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

        #region TabPage3 => Skills

        public void Fill_SkillChooser() {
            // Passive
            SkillChooser.Items.Clear();
            foreach (Skill entry in bibo.Skills.Where(x=> x.AvailableFor.Contains(activeHero.Id) && !x.IsActive)) {
                SkillChooser.Items.Add(entry);
            }

            // Rounds
            Round1Chooser.Items.Clear();
            Round2Chooser.Items.Clear();
            Round4Chooser.Items.Clear();
            Round3Chooser.Items.Clear();
            Round5Chooser.Items.Clear();
            foreach (Skill entry in bibo.Skills.Where(x => x.AvailableFor.Contains(activeHero.Id) && x.IsActive || x.AvailableFor.Count() == 0)){
                Round1Chooser.Items.Add(entry);
                Round2Chooser.Items.Add(entry);
                Round3Chooser.Items.Add(entry);
                Round4Chooser.Items.Add(entry);
                Round5Chooser.Items.Add(entry);
            }

            // Set the Skills
            if (activeHero.Skills.Passive != null) {
                SkillChooser.SelectedItem = SkillChooser.FindString(activeHero.Skills.Passive.Name);
            }
            Skill temp = bibo.Skills.First(x => x.Name.Equals("Basic"));
            Round1Chooser.SelectedIndex = Round1Chooser.FindString((activeHero.Skills.Round1 ?? temp).Name);
            Round2Chooser.SelectedIndex = Round2Chooser.FindString((activeHero.Skills.Round2 ?? temp).Name);
            Round3Chooser.SelectedIndex = Round3Chooser.FindString((activeHero.Skills.Round3 ?? temp).Name);
            Round4Chooser.SelectedIndex = Round4Chooser.FindString((activeHero.Skills.Round4 ?? temp).Name);
            Round5Chooser.SelectedIndex = Round5Chooser.FindString((activeHero.Skills.Round5 ?? temp).Name);
        }

        private void SkillChooser_SelectedIndexChanged(object sender, EventArgs e) {
            Skill temp = (Skill)SkillChooser.SelectedItem;
            SkillDescription.Text = temp.Description;
            activeHero.SelectSkill('P', temp);
            updateStats();
        }

        private void Round1Chooser_SelectedIndexChanged(object sender, EventArgs e) {
            Skill temp = (Skill)Round1Chooser.SelectedItem;
            Round1Description.Text = temp.Description;
            activeHero.SelectSkill('1', temp);
            UpdateAPInfo();
        }

        private void Round2Chooser_SelectedIndexChanged(object sender, EventArgs e) {
            Skill temp = (Skill)Round2Chooser.SelectedItem;
            Round2Description.Text = temp.Description;
            activeHero.SelectSkill('2', temp);
            UpdateAPInfo();
        }

        private void Round3Chooser_SelectedIndexChanged(object sender, EventArgs e) {
            Skill temp = (Skill)Round3Chooser.SelectedItem;
            Round3Description.Text = temp.Description;
            activeHero.SelectSkill('3', temp);
            UpdateAPInfo();
        }

        private void Round4Chooser_SelectedIndexChanged(object sender, EventArgs e) {
            Skill temp = (Skill)Round4Chooser.SelectedItem;
            Round4Description.Text = temp.Description;
            activeHero.SelectSkill('4', temp);
            UpdateAPInfo();
        }

        private void Round5Chooser_SelectedIndexChanged(object sender, EventArgs e) {
            Skill temp = (Skill)Round5Chooser.SelectedItem;
            Round5Description.Text = temp.Description;
            activeHero.SelectSkill('5', temp);
            UpdateAPInfo();
        }

        private void UpdateAPInfo() {
            usedAP.Text = "AP used: " + activeHero.Skills.info(activeHero.Level);
        }
        #endregion


        #region TabPage4 => Battles

        public void Fill_EnemyChooser() {
            foreach (Monster mon in bibo.Monsters) {
                EnemyChooser.Items.Add(mon);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            party = new PartyBuilder(this, HeroList);
            party.Show();
        }

        public void PartyUp(Dictionary<int, Hero> gruppe) {
            this.gruppe = gruppe;
            label8.Text = gruppe.Count + " against";
        }

        // Battle Area
        private void button10_Click(object sender, EventArgs e) {
            bool empty = false;
            if (gruppe == null && activeHero != null) {
                this.gruppe = new Dictionary<int, Hero>();
                this.gruppe.Add(4, activeHero);
                empty = true;
            }

            if (gruppe != null && EnemyChooser.SelectedItem != null) {
                Battle fight = new Battle(this, gruppe, (Monster)EnemyChooser.SelectedItem);
                FightingLog.Text = fight.Fight();
            }
            else if (gruppe == null)
                MessageBox.Show("No party created.");
            else if (EnemyChooser.SelectedItem == null)
                MessageBox.Show("No enemy selected.");

            gruppe = empty ? null : gruppe;
        }

        #endregion

        

        
    }
}

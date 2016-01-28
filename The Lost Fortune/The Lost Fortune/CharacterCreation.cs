﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Lost_Fortune
{
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();

        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            ButtonToggleVisibility();
            lblDesc.Text = "Excellent choice";
            lblDesc.Text = "The Mage is a ranged spell caster, who excells at dealing damage with magic powers \r\n "
                + "\r\n The mage starts with the following base stats: \r\n -100 Health \r\n -100 Mana \r\n -5 Magic Damage \r\n      "
                + "\r\n \r\n  The Mage has 3 different abilities: " 
                + "\r\n - Frostbolt is a ranged frozen bolt, that is fired at the opponent, dealing x Damage"
                + "\r\n - Fireball is a ranged fiery bolt, that is fired at the opponent dealing x Damage"
                + " \r\n - Iceblock - A protective icebubble is cast, making the caster invurnable to the opponent next attack"
                + " \r\n Iceblock also deals x dmg when being attacked, while iceblocked. Iceblock lasts 2 rounds (Note: This ability has a cooldown of 4 minutes) ";
                
            
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            ButtonToggleVisibility();
            lblDesc.Text = "The warrior is awesome blah blah blah blah...\r\nHe gains following bonuses:";
        }

        private void btnHunter_Click(object sender, EventArgs e)
        {
            ButtonToggleVisibility();
            lblDesc.Text = "The hunter is awesome blah blah blah blah...\r\nHe gains following bonuses:";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ButtonToggleVisibility();
            lblDesc.Text = "Each class has a numerous of different abilitie, which will help you as you progress.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmCharacterName cForm = new ConfirmCharacterName();
            cForm.Show();
        }

        private void ButtonToggleVisibility()
        {
            btnHunter.Visible = !btnHunter.Visible;
            btnWarrior.Visible = !btnWarrior.Visible;
            btnMage.Visible = !btnMage.Visible;
            btnBack.Visible = !btnBack.Visible;
            btnConfirm.Visible = !btnConfirm.Visible;
            lblChooseC.Visible = !lblChooseC.Visible;
            lblExcellent.Visible = !lblExcellent.Visible;
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {

        }

        private void lblExcellent_Click(object sender, EventArgs e)
        {

        }
    }
}

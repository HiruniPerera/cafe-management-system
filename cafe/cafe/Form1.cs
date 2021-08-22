using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox16_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox15_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox11_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void checkBox12_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "";
			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "0";
			textBox6.Text = "0";
			textBox7.Text = "0";
			textBox8.Text = "0";
			textBox9.Text = "0";
			textBox10.Text = "0";
			textBox11.Text = "0";
			textBox12.Text = "0";
			textBox13.Text = "0";
			textBox14.Text = "0";
			textBox15.Text = "0";
			textBox16.Text = "0";
			textBox17.Text = "";
			textBox18.Text = "1.75";
			textBox19.Text = "";
			textBox20.Text = "";
			textBox21.Text = "";
			textBox22.Text = "";


			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			checkBox4.Checked = false;
			checkBox5.Checked = false;
			checkBox6.Checked = false;
			checkBox7.Checked = false;
			checkBox8.Checked = false;
			checkBox9.Checked = false;
			checkBox10.Checked = false;
			checkBox11.Checked = false;
			checkBox12.Checked = false;
			checkBox13.Checked = false;
			checkBox14.Checked = false;
			checkBox15.Checked = false;
			checkBox16.Checked = false;
			




		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label5.Text = DateTime.Now.ToLongDateString();
			timer1.Start();

			textBox1.Text = "0";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "0";
			textBox6.Text = "0";
			textBox7.Text = "0";
			textBox8.Text = "0";
			textBox9.Text = "0";
			textBox10.Text = "0";
			textBox11.Text = "0";
			textBox12.Text = "0";
			textBox13.Text = "0";
			textBox14.Text = "0";
			textBox15.Text = "0";
			textBox16.Text = "0";
			textBox17.Text = "";
			textBox18.Text = "1.75";
			textBox19.Text = "";

			textBox1.Enabled = false;
			textBox2.Enabled = false;
			textBox3.Enabled = false;
			textBox4.Enabled = false;
			textBox5.Enabled = false;
			textBox6.Enabled = false;
			textBox7.Enabled = false;
			textBox8.Enabled = false;
			textBox16.Enabled = false;
			textBox15.Enabled = false;
			textBox14.Enabled = false;
			textBox13.Enabled = false;
			textBox12.Enabled = false;
			textBox11.Enabled = false;
			textBox10.Enabled = false;
			textBox9.Enabled = false;
		}

		private void label3_Click(object sender, EventArgs e)
		{
			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				textBox1.Enabled = true;

			}
			if (checkBox1.Checked == false)
			{
				textBox1.Enabled = false;
				textBox1.Text = "0";
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox1.Focus();

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked == true)
			{
				textBox2.Enabled = true;
			}
			if (checkBox2.Checked == false)
			{
				textBox2.Enabled = false;
				textBox2.Text = "0";
			}
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			textBox2.Focus();

		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked == true)
			{
				textBox3.Enabled = true;
			}
			if (checkBox3.Checked == false)
			{
				textBox3.Enabled = false;
				textBox3.Text = "0";
			}
		}

		private void textBox3_Click(object sender, EventArgs e)
		{
			textBox3.Text = "";
			textBox3.Focus();
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox5.Checked == true)
			{
				textBox4.Enabled = true;
			}
			if (checkBox5.Checked == false)
			{
				textBox4.Enabled = false;
				textBox4.Text = "0";
			}
		}

		private void textBox4_Click(object sender, EventArgs e)
		{
			textBox4.Text = "";
			textBox4.Focus();
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox4.Checked == true)
			{
				textBox5.Enabled = true;
			}
			if (checkBox4.Checked == false)
			{
				textBox5.Enabled = false;
				textBox5.Text = "0";
			}
		}

		private void textBox5_Click(object sender, EventArgs e)
		{
			textBox5.Text = "";
			textBox5.Focus();
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox8.Checked == true)
			{
				textBox6.Enabled = true;
			}
			if (checkBox8.Checked == false)
			{
				textBox6.Enabled = false;
				textBox6.Text = "0";
			}
		}

		private void textBox6_Click(object sender, EventArgs e)
		{
			textBox6.Text = "";
			textBox6.Focus();
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox7.Checked == true)
			{
				textBox7.Enabled = true;
			}
			if (checkBox7.Checked == false)
			{
				textBox7.Enabled = false;
				textBox7.Text = "0";
			}
		}

		private void textBox7_Click(object sender, EventArgs e)
		{
			textBox7.Text = "";
			textBox7.Focus();
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox6.Checked == true)
			{
				textBox8.Enabled = true;
			}
			if (checkBox6.Checked == false)
			{
				textBox8.Enabled = false;
				textBox8.Text = "0";
			}
		}

		private void textBox8_Click(object sender, EventArgs e)
		{
			textBox8.Text = "";
			textBox8.Focus();
		}

		private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox9.Checked == true)
			{
				textBox16.Enabled = true;
			}
			if (checkBox9.Checked == false)
			{
				textBox16.Enabled = false;
				textBox16.Text = "0";
			}
		}

		private void textBox16_Click(object sender, EventArgs e)
		{
			textBox16.Text = "";
			textBox16.Focus();
		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox10.Checked == true)
			{
				textBox15.Enabled = true;
			}
			if (checkBox10.Checked == false)
			{
				textBox15.Enabled = false;
				textBox15.Text = "0";
			}
		}

		private void textBox15_Click(object sender, EventArgs e)
		{
			textBox15.Text = "";
			textBox15.Focus();
		}

		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox11.Checked == true)
			{
				textBox14.Enabled = true;
			}
			if (checkBox11.Checked == false)
			{
				textBox14.Enabled = false;
				textBox14.Text = "0";
			}
		}

		private void textBox14_Click(object sender, EventArgs e)
		{
			textBox14.Text = "";
			textBox14.Focus();
		}

		private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox12.Checked == true)
			{
				textBox13.Enabled = true;
			}
			if (checkBox12.Checked == false)
			{
				textBox13.Enabled = false;
				textBox13.Text = "0";
			}
		}

		private void textBox13_Click(object sender, EventArgs e)
		{
			textBox13.Text = "";
			textBox13.Focus();
		}

		private void checkBox13_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox13.Checked == true)
			{
				textBox12.Enabled = true;
			}
			if (checkBox13.Checked == false)
			{
				textBox12.Enabled = false;
				textBox12.Text = "0";
			}
		}

		private void textBox12_Click(object sender, EventArgs e)
		{
			textBox12.Text = "";
			textBox12.Focus();
		}

		private void checkBox14_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox14.Checked == true)
			{
				textBox11.Enabled = true;
			}
			if (checkBox14.Checked == false)
			{
				textBox11.Enabled = false;
				textBox11.Text = "0";
			}
		}

		private void textBox11_Click(object sender, EventArgs e)
		{
			textBox11.Text = "";
			textBox11.Focus();
		}

		private void checkBox15_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox15.Checked == true)
			{
				textBox10.Enabled = true;
			}
			if (checkBox15.Checked == false)
			{
				textBox10.Enabled = false;
				textBox10.Text = "0";
			}
		}

		private void textBox10_Click(object sender, EventArgs e)
		{
			textBox10.Text = "";
			textBox10.Focus();
		}

		private void checkBox16_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox16.Checked == true)
			{
				textBox9.Enabled = true;
			}
			if (checkBox16.Checked == false)
			{
				textBox9.Enabled = false;
				textBox19.Text = "0";
			}
		}

		private void textBox9_Click(object sender, EventArgs e)
		{
			textBox9.Text = "";
			textBox9.Focus();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
					}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label3.Text = DateTime.Now.ToLongTimeString();
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
		}

		private void printToolStripButton_Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();

		}

		private void cutToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();

		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();

		}

		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
			if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.FileName = "Notepad Text";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
					sw.WriteLine(richTextBox1.Text);
			}
				
		}

		private void button5_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox1.AppendText(Environment.NewLine);
			richTextBox1.AppendText("\t\t...................................." + Environment.NewLine);
			richTextBox1.AppendText("\t\t" + "        Just Do Cafe" + Environment.NewLine);
			richTextBox1.AppendText("\t\t...................................." + Environment.NewLine + Environment.NewLine);
			richTextBox1.AppendText(" LATTE\t\t\t    " + textBox1.Text + Environment.NewLine);
			richTextBox1.AppendText(" ESSPRESSO\t\t    "     + textBox2.Text + Environment.NewLine);
			richTextBox1.AppendText(" ICED LATTE\t\t    " + textBox3.Text + Environment.NewLine);
			richTextBox1.AppendText(" VALE COFFEE\t\t    " + textBox4.Text + Environment.NewLine);
			richTextBox1.AppendText(" CAPPUCCINO   \t\t    " + textBox5.Text + Environment.NewLine);
			richTextBox1.AppendText(" AFRICAN COFFEE \t    " + textBox6.Text + Environment.NewLine);
			richTextBox1.AppendText(" AMERICAN COFFEE \t    " + textBox7.Text + Environment.NewLine);
			richTextBox1.AppendText(" ICED CAPPUCCINO\t    " + textBox8.Text + Environment.NewLine);
			richTextBox1.AppendText(" COFFEE CAKE\t\t    " + textBox9.Text + Environment.NewLine);
			richTextBox1.AppendText(" APPLE CAKE        \t\t    " + textBox10.Text + Environment.NewLine);
			richTextBox1.AppendText(" VANILLA CAKE  \t\t    " + textBox11.Text + Environment.NewLine);
			richTextBox1.AppendText(" RIBBON CAKE \t\t    " + textBox12.Text + Environment.NewLine);
			richTextBox1.AppendText(" RED VELVET CAKE \t    " + textBox13.Text + Environment.NewLine);
			richTextBox1.AppendText(" BLACK FOREST CAKE \t    " + textBox14.Text + Environment.NewLine);
			richTextBox1.AppendText(" BOSTON CREAM CAKE\t    " + textBox15.Text + Environment.NewLine);
			richTextBox1.AppendText(" LAGOS CREAM CAKE\t    " + textBox16.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t...................................." + Environment.NewLine);
			richTextBox1.AppendText("SERVICE CHARGES \t   " + textBox18.Text + Environment.NewLine);
			richTextBox1.AppendText("\t\t...................................." + Environment.NewLine);
			richTextBox1.AppendText("TAX \t\t\t " +textBox22.Text+Environment.NewLine );
			richTextBox1.AppendText("SUB TOTAL \t\t " + textBox21.Text + Environment.NewLine);
			richTextBox1.AppendText("TOTAL \t\t " + textBox17.Text + Environment.NewLine);
			richTextBox1.AppendText( label5.Text +" \t\t\t\t     "+ label3.Text);
			richTextBox1.AppendText("\t\t...................................." + Environment.NewLine);
			richTextBox1.AppendText("\t\t       THANK YOU" + Environment.NewLine);

		}

		private void button4_Click(object sender, EventArgs e)
		{

			double tax;
			tax = 20;
			double latte, esspresso, ilatte, vale, acoffee, amcoffee, capp, icapp;
			double ccake, rvelvet, bforest, cboston, clagos, ckilburn, ccaelton, cqueen;
			latte = 60;
			esspresso = 70;
			ilatte = 65;
			vale = 50;
			acoffee = 70;
			amcoffee = 100;
			capp = 55;
			icapp = 75;

			double latte_coff = Convert.ToDouble(textBox1.Text) ;
			double esspress_coffee = Convert.ToDouble(textBox2.Text) ;
			double ilatt_coff = Convert.ToDouble(textBox3.Text) ;
			double vale_coff = Convert.ToDouble(textBox4.Text);
			double acof_coff = Convert.ToDouble(textBox5.Text) ;
			double amco_coff = Convert.ToDouble(textBox6.Text) ;
			double c_capp = Convert.ToDouble(textBox7.Text) ;
			double icap_coff = Convert.ToDouble(textBox8.Text);



			ccake = 200;
			rvelvet = 350;
			bforest = 450;
			cboston = 300;
			clagos = 250;
			ckilburn = 500;
			ccaelton = 420;
			cqueen = 480;

			double c_cake = Convert.ToDouble(textBox16.Text) ;
			double r_velvet = Convert.ToDouble(textBox15.Text) ;
			double b_forest = Convert.ToDouble(textBox14.Text) ;
			double c_bos = Convert.ToDouble(textBox13.Text) ;
			double c_lagos = Convert.ToDouble(textBox12.Text);
			double c_kilb = Convert.ToDouble(textBox11.Text) ;
			double c_cael = Convert.ToDouble(textBox10.Text) ;
			double c_queen = Convert.ToDouble(textBox9.Text) ;


			Cafe eat_in_Cafe = new Cafe(latte_coff,esspress_coffee,ilatt_coff,vale_coff,acof_coff,amco_coff,c_capp,icap_coff,
				c_cake,r_velvet,b_forest,c_bos,c_lagos,c_kilb,c_cael,c_queen);

			double cost_of_drinks = (latte_coff * latte) + (esspress_coffee * esspresso) + (ilatt_coff * ilatte) + (vale_coff * vale) + (acof_coff * acoffee) +
				(amco_coff * amcoffee) + (c_capp * capp) + (icap_coff * icapp);
			textBox20.Text = Convert.ToString(cost_of_drinks);

			double cost_of_cakes = (c_cake * ccake) + (r_velvet * rvelvet) + (b_forest * bforest) + (c_bos * cboston) + (c_lagos * clagos) +
				(c_kilb * ckilburn) + (c_cael * ccaelton) + (c_queen * cqueen);
			textBox19.Text = Convert.ToString(cost_of_cakes);

			double service_charge = Convert.ToDouble(textBox19.Text);
			textBox21.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + service_charge);
			textBox22.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + service_charge) * tax) / 100);
			double iTax = Convert.ToDouble(textBox22.Text);
			textBox17.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + iTax+service_charge);


		}
	}
}

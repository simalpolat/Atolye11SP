using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_asmaca_vol_5
{
	public partial class Form1 : Form
	{

		Random randm = new Random();
		string[] kelimeler = new string[] { "KÖPEK", "TAPİR", "LAGOSE", "BABİL", "BİZON", "TIRTIL", "BOĞA", "SİVRİSİNEK ", "YENGEÇ", "TAVUK" };
		public string randomkelime;
		public int rastgele;
		public string[] harf;
		public int imageNumber = 1;
		public int kalancan;
	    public string secilenkelime;

		//hocam kodu yazarken  Çınar Çok   ve  Yavuzdan yardım aldım ama kodu tamamen kendim yazdım. Söz veriyorum daha çok çalışacağım
	    // nice seneler <3
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			pictureBox1.Image = imageList1.Images[imageNumber];
			//hocam burada aldığım hatayu bir türlü çözemedim :/ 
			// başlangıç değerim ile alaklı olduğnunu düşünüyordum ama değişsem de olmadı.
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

			listBox1.Items.Clear();
			rastgele = randm.Next(0, kelimeler.Length);
			randomkelime = kelimeler[rastgele];
			randomkelime = randomkelime.ToUpper();
			listBox1.Items.Add(randomkelime);
			harf = new string[randomkelime.Length];
			kalancan = 3;
			label2.Text = " ";
			label3.Text = kalancan.ToString();
			for (int a = 0; a < randomkelime.Length; a++)
			{
				harf[a] = "_";
				label2.Text += harf[a] + " ";
			}
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			string secilenkelime = textBox1.Text.ToUpper();

			if (secilenkelime == randomkelime)
			{
				for (int i = 0; i < randomkelime.Length; i++)
				{
					harf[i] = secilenkelime[i].ToString();
				}
			}

			else
			{
				kalancan--;
				imageNumber++;
				pictureBox1.Image = imageList1.Images[imageNumber];

				if (kalancan == 0)
				{
					MessageBox.Show("Üzgünüm kaybettiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
					label2.Text = "";
				}
			}
			if (randomkelime == secilenkelime)
			{
				MessageBox.Show("Terkler kazandınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				label2.Text = "";
			}

			label3.Text = kalancan.ToString();
			label2.Text = " ";

			for (int k = 0; k < randomkelime.Length; k++)
			{
				label2.Text += harf[k] + " ";
			}
		}
          

		private void button3_Click_1(object sender, EventArgs e)
		{

			string secilenkelime = textBox1.Text.ToUpper();
			bool döngü = false;

			for (int i = 0; i < randomkelime.Length; i++)
			{
				if (secilenkelime[0] == randomkelime[i])
				{
					harf[i] = secilenkelime[0].ToString();
					döngü = true;
				}
			}

			if (döngü == false)
			{
				kalancan--;
				imageNumber++;
				pictureBox1.Image = imageList1.Images[imageNumber];
			}
			label3.Text = kalancan.ToString();

	    	if (kalancan == 0)
			{
				MessageBox.Show("Üzgünüm kaybettiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				label2.Text = "";
			}

			else if (randomkelime == secilenkelime)
			{
				MessageBox.Show("Tebrikler kazandınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				label2.Text = "";
			}

			label2.Text = " ";
			for (int j = 0; j < randomkelime.Length; j++)
			{
				label2.Text += harf[j] + " ";
			}
		}

	}
}
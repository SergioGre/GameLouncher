using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLouncher.Properties;
using System.IO;
using System.Xml.Serialization;




namespace GameLouncher
{
    public partial class Form2 : Form
    {
        string processWay2;
        string processName2;

        string mWay;

        string mainScrn = null;
        string scrn1 = null;
        string scrn2 = null;
        string scrn3 = null;

        public static List<Form1.GameApp> gameList = new List<Form1.GameApp>();
        

        public Form2()
        {
            InitializeComponent();
            
            
            mWay = Settings.Default.folderWay;
            mainWay.Text = Settings.Default.folderWay;
            

        }

        private void nameApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameWay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if(nameApp.Text.Length != 0 && nameWay.Text.Length != 0)
            {
                processWay2 = nameWay.Text;
                processName2 = nameApp.Text;
                //Directory.CreateDirectory(mWay + "\\" + processName);

                scrBut1.Visible = true;
                scrBut2.Visible = true;
                scrBut3.Visible = true;
                scrBut4.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                button2.Visible = true;

                nameWay.Visible = false;
                nameApp.Visible = false;
                nameAppLabel.Visible = false;
                nameWayLabel.Visible = false;
                buttonGo.Visible = false;
                
                
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void nameAppLabel_Click(object sender, EventArgs e)
        {

        }

        private void wayBut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            mWay = dialog.SelectedPath;
            mainWay.Text = mWay;
            Settings.Default.folderWay = mWay;
            
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            Settings.Default.folderWay = mWay;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mWay);
        }

        private void scrBut1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                mainScrn = Path.GetDirectoryName(ofd.FileName) + "\\" + ofd.SafeFileName; ;
                label1.Text = "Загружено";
                label1.ForeColor = Color.Green;
            }
        }

        private void scrBut2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                scrn1 = Path.GetDirectoryName(ofd.FileName) + "\\" + ofd.SafeFileName;


                label2.Text = "Загружено";
                label2.ForeColor = Color.Green;
                
            }
        }

        private void scrBut3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                scrn2 = Path.GetDirectoryName(ofd.FileName) + "\\" + ofd.SafeFileName; ;


                label3.Text = "Загружено";
                label3.ForeColor = Color.Green;
            }    
        }

        private void scrBut4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                scrn3 = Path.GetDirectoryName(ofd.FileName) + "\\" + ofd.SafeFileName; ;


                label4.Text = "Загружено";
                label4.ForeColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainScrn != null && scrn1 != null && scrn2 != null && scrn3 != null)
            {
                
                gameList.Add(new Form1.GameApp(processName2, processWay2, mainScrn, scrn1, scrn2, scrn3));
                MessageBox.Show("Готово!");

                scrBut1.Visible = false;
                scrBut2.Visible = false;
                scrBut3.Visible = false;
                scrBut4.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                button2.Visible = false;

                nameWay.Visible = true;
                nameApp.Visible = true;
                nameAppLabel.Visible = true;
                nameWayLabel.Visible = true;
                buttonGo.Visible = true;

                processName2 = null;
                processWay2 = null;
                mainScrn = null;
                scrn1 = null;
                scrn2 = null;
                scrn3 = null;

               
                Form1.Serializ.Save(gameList);
                //serializeList(gamAps);
            }
            else
            {
                MessageBox.Show("Не все картинки загружены!");
            }

            
        }
    }

    
}
